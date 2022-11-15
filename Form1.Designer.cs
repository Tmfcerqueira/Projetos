
namespace SuperMercado
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.LblQtd = new System.Windows.Forms.Label();
            this.NupQtd = new System.Windows.Forms.NumericUpDown();
            this.LblPreco = new System.Windows.Forms.Label();
            this.TxtPreco = new System.Windows.Forms.TextBox();
            this.BttnLb = new System.Windows.Forms.Button();
            this.LstRes = new System.Windows.Forms.ListBox();
            this.LblTotal = new System.Windows.Forms.Label();
            this.BttnPagar = new System.Windows.Forms.Button();
            this.BttnFecho = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.NupQtd)).BeginInit();
            this.SuspendLayout();
            // 
            // LblQtd
            // 
            this.LblQtd.AutoSize = true;
            this.LblQtd.Location = new System.Drawing.Point(12, 9);
            this.LblQtd.Name = "LblQtd";
            this.LblQtd.Size = new System.Drawing.Size(27, 13);
            this.LblQtd.TabIndex = 0;
            this.LblQtd.Text = "Qtd.";
            // 
            // NupQtd
            // 
            this.NupQtd.DecimalPlaces = 3;
            this.NupQtd.Location = new System.Drawing.Point(15, 25);
            this.NupQtd.Name = "NupQtd";
            this.NupQtd.Size = new System.Drawing.Size(49, 20);
            this.NupQtd.TabIndex = 1;
            // 
            // LblPreco
            // 
            this.LblPreco.AutoSize = true;
            this.LblPreco.Location = new System.Drawing.Point(81, 9);
            this.LblPreco.Name = "LblPreco";
            this.LblPreco.Size = new System.Drawing.Size(59, 13);
            this.LblPreco.TabIndex = 2;
            this.LblPreco.Text = "Pr. Unitário";
            // 
            // TxtPreco
            // 
            this.TxtPreco.Location = new System.Drawing.Point(84, 24);
            this.TxtPreco.Name = "TxtPreco";
            this.TxtPreco.Size = new System.Drawing.Size(84, 20);
            this.TxtPreco.TabIndex = 3;
            this.TxtPreco.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TxtPreco_KeyPress);
            // 
            // BttnLb
            // 
            this.BttnLb.Location = new System.Drawing.Point(188, 23);
            this.BttnLb.Name = "BttnLb";
            this.BttnLb.Size = new System.Drawing.Size(70, 21);
            this.BttnLb.TabIndex = 4;
            this.BttnLb.Text = "> >";
            this.BttnLb.UseVisualStyleBackColor = true;
            this.BttnLb.Click += new System.EventHandler(this.BttnLb_Click);
            // 
            // LstRes
            // 
            this.LstRes.FormattingEnabled = true;
            this.LstRes.Location = new System.Drawing.Point(264, 23);
            this.LstRes.Name = "LstRes";
            this.LstRes.Size = new System.Drawing.Size(174, 199);
            this.LstRes.TabIndex = 5;
            // 
            // LblTotal
            // 
            this.LblTotal.AutoSize = true;
            this.LblTotal.Location = new System.Drawing.Point(12, 178);
            this.LblTotal.Name = "LblTotal";
            this.LblTotal.Size = new System.Drawing.Size(67, 13);
            this.LblTotal.TabIndex = 6;
            this.LblTotal.Text = "Total: 0.00 €";
            // 
            // BttnPagar
            // 
            this.BttnPagar.Location = new System.Drawing.Point(12, 199);
            this.BttnPagar.Name = "BttnPagar";
            this.BttnPagar.Size = new System.Drawing.Size(243, 23);
            this.BttnPagar.TabIndex = 7;
            this.BttnPagar.Text = "Pagar";
            this.BttnPagar.UseVisualStyleBackColor = true;
            this.BttnPagar.Click += new System.EventHandler(this.BttnPagar_Click);
            // 
            // BttnFecho
            // 
            this.BttnFecho.Location = new System.Drawing.Point(15, 245);
            this.BttnFecho.Name = "BttnFecho";
            this.BttnFecho.Size = new System.Drawing.Size(423, 23);
            this.BttnFecho.TabIndex = 8;
            this.BttnFecho.Text = "Fecho de Caixa";
            this.BttnFecho.UseVisualStyleBackColor = true;
            this.BttnFecho.Click += new System.EventHandler(this.BttnFecho_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(450, 280);
            this.Controls.Add(this.BttnFecho);
            this.Controls.Add(this.BttnPagar);
            this.Controls.Add(this.LblTotal);
            this.Controls.Add(this.LstRes);
            this.Controls.Add(this.BttnLb);
            this.Controls.Add(this.TxtPreco);
            this.Controls.Add(this.LblPreco);
            this.Controls.Add(this.NupQtd);
            this.Controls.Add(this.LblQtd);
            this.Name = "Form1";
            this.Text = "Super Mercado";
            ((System.ComponentModel.ISupportInitialize)(this.NupQtd)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label LblQtd;
        private System.Windows.Forms.NumericUpDown NupQtd;
        private System.Windows.Forms.Label LblPreco;
        private System.Windows.Forms.TextBox TxtPreco;
        private System.Windows.Forms.Button BttnLb;
        private System.Windows.Forms.ListBox LstRes;
        private System.Windows.Forms.Label LblTotal;
        private System.Windows.Forms.Button BttnPagar;
        private System.Windows.Forms.Button BttnFecho;
    }
}

