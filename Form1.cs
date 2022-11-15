using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SuperMercado
{
    public partial class Form1 : Form
    {
        #region Variaveis
        double Valor_Preco = 0;
        double Res = 0, auxiliar = 0;
        double[][] Customer = new double[500][];
        double[] Total = new double[500];
        double[,] Produtos = new double[500, 1];
        int Valor_NupDown = 0;
        int e1 = 0, e2 = 0;
        string Result_List;
        #endregion

        public Form1()
        {
            InitializeComponent();
            #region Index do array
            for (int idx = 0; idx < 500; idx++)
            {
                Customer[idx] = new double[500];
            }
            #endregion
        }

        private void TxtPreco_KeyPress(object sender, KeyPressEventArgs e)
        {
            #region Proibição de caracteres e permissão de digitos e o Ponto
            e.Handled = !Char.IsDigit(e.KeyChar) && !Char.IsControl(e.KeyChar) && e.KeyChar != '.';
            #endregion
        }

        private void BttnFecho_Click(object sender, EventArgs e)
        {
            #region Ciclo para indexar o array com verificação de qual é que é o maior ou menor
            int M = 0, m = 0;
            for (int i = 0; i < e1; i++)
            {
                if (Total[M] < Total[i])
                    M = i;

                if (Total[m] > Total[i])
                    m = i;
            }
            MessageBox.Show("\tA maior compra foi " + Total[M] + "€" + "Do cliente " + M + "\n\t" + "A menor compra foi " + Total[m] + "€" +" Do cliente " + m, "Fecho",
                MessageBoxButtons.OK, MessageBoxIcon.Information);
            this.Close();
            #endregion
        }

        private void BttnLb_Click(object sender, EventArgs e)
        {
            #region Verificações, Uso de variaveis para armazenar valores pedidos e acrescentando-os na listbox com o objetivo de um super mercado
            if (TxtPreco.Text == "" || NupQtd.Value == 0)
            {
                MessageBox.Show("Deve indicar o Preço unitário ou a Quantidade!", "Erro",
                    MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                Valor_Preco = Convert.ToDouble(TxtPreco.Text);
                Valor_NupDown = Convert.ToInt32(NupQtd.Value);
                Res = Valor_NupDown * Valor_Preco;
                auxiliar += Res;
                if (Res == 0)
                {
                    // Verificação caso aconteça !
                    MessageBox.Show("Os valores devem ser superior que 0 !", "Erro",
                        MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    Result_List = Valor_NupDown.ToString() + " x " + Valor_Preco.ToString() + " = " + Res.ToString();
                    LstRes.Items.Add(Result_List);
                    Customer[e1][e2] = Res;
                    e2++;
                    LblTotal.Text = "Total: " + auxiliar.ToString() + "€";
                }
            }
            #endregion
        }

        private void BttnPagar_Click(object sender, EventArgs e)
        {
            #region Array Produtos armazena 
            Produtos[e1, 0] = e2;
            LstRes.Items.Clear();
            LblTotal.Text = "Total: 0.00" + "€";
            Total[e1] = auxiliar;
            e1++;
            e2 = 0;
            MessageBox.Show("O Total a pagar pelos Produtos e': " + auxiliar + "€", "Fecho de Compra", MessageBoxButtons.OK, MessageBoxIcon.Information);
            auxiliar = 0;
            TxtPreco.Clear();
            NupQtd.Value = 0;
            #endregion
        }
    }
}
/* 
        * Aba dos rascunhos / caso queira utilizar
            listbox.items.addrange(new object[] { nUpQTD.value.ToString() + " * " + txtValor.text + " = " + {}})
*/
