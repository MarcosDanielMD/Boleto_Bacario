namespace Boleto_Bancário
{
    partial class FormBoleto
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.lbValor = new System.Windows.Forms.Label();
            this.lbVenci = new System.Windows.Forms.Label();
            this.lbPag = new System.Windows.Forms.Label();
            this.lbMulta = new System.Windows.Forms.Label();
            this.lbJuros = new System.Windows.Forms.Label();
            this.lbDesconto = new System.Windows.Forms.Label();
            this.txtbValor = new System.Windows.Forms.TextBox();
            this.txtbMulta = new System.Windows.Forms.TextBox();
            this.txtbJuros = new System.Windows.Forms.TextBox();
            this.txtbDesc = new System.Windows.Forms.TextBox();
            this.lbDA = new System.Windows.Forms.Label();
            this.lbVM = new System.Windows.Forms.Label();
            this.lbVJ = new System.Windows.Forms.Label();
            this.lbVD = new System.Windows.Forms.Label();
            this.lbAcre = new System.Windows.Forms.Label();
            this.lbTotal = new System.Windows.Forms.Label();
            this.txtbDA = new System.Windows.Forms.TextBox();
            this.txtbVM = new System.Windows.Forms.TextBox();
            this.txtbVJ = new System.Windows.Forms.TextBox();
            this.txtbVD = new System.Windows.Forms.TextBox();
            this.txtbAcre = new System.Windows.Forms.TextBox();
            this.txtbTotal = new System.Windows.Forms.TextBox();
            this.btnCalc = new System.Windows.Forms.Button();
            this.btnLimpar = new System.Windows.Forms.Button();
            this.brnSair = new System.Windows.Forms.Button();
            this.txtbVenc = new System.Windows.Forms.MaskedTextBox();
            this.txtbPag = new System.Windows.Forms.MaskedTextBox();
            this.SuspendLayout();
            // 
            // lbValor
            // 
            this.lbValor.AutoSize = true;
            this.lbValor.Location = new System.Drawing.Point(95, 47);
            this.lbValor.Name = "lbValor";
            this.lbValor.Size = new System.Drawing.Size(36, 15);
            this.lbValor.TabIndex = 0;
            this.lbValor.Text = "Valor:";
            // 
            // lbVenci
            // 
            this.lbVenci.AutoSize = true;
            this.lbVenci.Location = new System.Drawing.Point(95, 109);
            this.lbVenci.Name = "lbVenci";
            this.lbVenci.Size = new System.Drawing.Size(73, 15);
            this.lbVenci.TabIndex = 1;
            this.lbVenci.Text = "Vencimento:";
            // 
            // lbPag
            // 
            this.lbPag.AutoSize = true;
            this.lbPag.Location = new System.Drawing.Point(95, 181);
            this.lbPag.Name = "lbPag";
            this.lbPag.Size = new System.Drawing.Size(71, 15);
            this.lbPag.TabIndex = 2;
            this.lbPag.Text = "Pagamento:";
            // 
            // lbMulta
            // 
            this.lbMulta.AutoSize = true;
            this.lbMulta.Location = new System.Drawing.Point(95, 249);
            this.lbMulta.Name = "lbMulta";
            this.lbMulta.Size = new System.Drawing.Size(41, 15);
            this.lbMulta.TabIndex = 3;
            this.lbMulta.Text = "Multa:";
            // 
            // lbJuros
            // 
            this.lbJuros.AutoSize = true;
            this.lbJuros.Location = new System.Drawing.Point(95, 316);
            this.lbJuros.Name = "lbJuros";
            this.lbJuros.Size = new System.Drawing.Size(37, 15);
            this.lbJuros.TabIndex = 4;
            this.lbJuros.Text = "Juros:";
            // 
            // lbDesconto
            // 
            this.lbDesconto.AutoSize = true;
            this.lbDesconto.Location = new System.Drawing.Point(95, 379);
            this.lbDesconto.Name = "lbDesconto";
            this.lbDesconto.Size = new System.Drawing.Size(60, 15);
            this.lbDesconto.TabIndex = 5;
            this.lbDesconto.Text = "Desconto:";
            // 
            // txtbValor
            // 
            this.txtbValor.Location = new System.Drawing.Point(95, 65);
            this.txtbValor.Name = "txtbValor";
            this.txtbValor.Size = new System.Drawing.Size(100, 23);
            this.txtbValor.TabIndex = 6;
            // 
            // txtbMulta
            // 
            this.txtbMulta.Location = new System.Drawing.Point(95, 279);
            this.txtbMulta.Name = "txtbMulta";
            this.txtbMulta.Size = new System.Drawing.Size(100, 23);
            this.txtbMulta.TabIndex = 9;
            // 
            // txtbJuros
            // 
            this.txtbJuros.Location = new System.Drawing.Point(95, 342);
            this.txtbJuros.Name = "txtbJuros";
            this.txtbJuros.Size = new System.Drawing.Size(100, 23);
            this.txtbJuros.TabIndex = 10;
            // 
            // txtbDesc
            // 
            this.txtbDesc.Location = new System.Drawing.Point(95, 415);
            this.txtbDesc.Name = "txtbDesc";
            this.txtbDesc.Size = new System.Drawing.Size(100, 23);
            this.txtbDesc.TabIndex = 11;
            // 
            // lbDA
            // 
            this.lbDA.AutoSize = true;
            this.lbDA.Location = new System.Drawing.Point(515, 47);
            this.lbDA.Name = "lbDA";
            this.lbDA.Size = new System.Drawing.Size(87, 15);
            this.lbDA.TabIndex = 12;
            this.lbDA.Text = "Dias Atrasados:";
            // 
            // lbVM
            // 
            this.lbVM.AutoSize = true;
            this.lbVM.Location = new System.Drawing.Point(515, 109);
            this.lbVM.Name = "lbVM";
            this.lbVM.Size = new System.Drawing.Size(86, 15);
            this.lbVM.TabIndex = 13;
            this.lbVM.Text = "Valor da Multa:";
            // 
            // lbVJ
            // 
            this.lbVJ.AutoSize = true;
            this.lbVJ.Location = new System.Drawing.Point(515, 181);
            this.lbVJ.Name = "lbVJ";
            this.lbVJ.Size = new System.Drawing.Size(83, 15);
            this.lbVJ.TabIndex = 14;
            this.lbVJ.Text = "Valor do Juros:";
            // 
            // lbVD
            // 
            this.lbVD.AutoSize = true;
            this.lbVD.Location = new System.Drawing.Point(515, 249);
            this.lbVD.Name = "lbVD";
            this.lbVD.Size = new System.Drawing.Size(103, 15);
            this.lbVD.TabIndex = 15;
            this.lbVD.Text = "Valor do Desconto";
            // 
            // lbAcre
            // 
            this.lbAcre.AutoSize = true;
            this.lbAcre.Location = new System.Drawing.Point(515, 316);
            this.lbAcre.Name = "lbAcre";
            this.lbAcre.Size = new System.Drawing.Size(67, 15);
            this.lbAcre.TabIndex = 16;
            this.lbAcre.Text = "Acressimos";
            // 
            // lbTotal
            // 
            this.lbTotal.AutoSize = true;
            this.lbTotal.Location = new System.Drawing.Point(515, 379);
            this.lbTotal.Name = "lbTotal";
            this.lbTotal.Size = new System.Drawing.Size(35, 15);
            this.lbTotal.TabIndex = 17;
            this.lbTotal.Text = "Total:";
            // 
            // txtbDA
            // 
            this.txtbDA.Enabled = false;
            this.txtbDA.Location = new System.Drawing.Point(515, 74);
            this.txtbDA.Name = "txtbDA";
            this.txtbDA.Size = new System.Drawing.Size(100, 23);
            this.txtbDA.TabIndex = 18;
            // 
            // txtbVM
            // 
            this.txtbVM.Enabled = false;
            this.txtbVM.Location = new System.Drawing.Point(515, 139);
            this.txtbVM.Name = "txtbVM";
            this.txtbVM.Size = new System.Drawing.Size(100, 23);
            this.txtbVM.TabIndex = 19;
            // 
            // txtbVJ
            // 
            this.txtbVJ.Enabled = false;
            this.txtbVJ.Location = new System.Drawing.Point(515, 215);
            this.txtbVJ.Name = "txtbVJ";
            this.txtbVJ.Size = new System.Drawing.Size(100, 23);
            this.txtbVJ.TabIndex = 20;
            // 
            // txtbVD
            // 
            this.txtbVD.Enabled = false;
            this.txtbVD.Location = new System.Drawing.Point(515, 279);
            this.txtbVD.Name = "txtbVD";
            this.txtbVD.Size = new System.Drawing.Size(100, 23);
            this.txtbVD.TabIndex = 21;
            // 
            // txtbAcre
            // 
            this.txtbAcre.Enabled = false;
            this.txtbAcre.Location = new System.Drawing.Point(515, 342);
            this.txtbAcre.Name = "txtbAcre";
            this.txtbAcre.Size = new System.Drawing.Size(100, 23);
            this.txtbAcre.TabIndex = 22;
            // 
            // txtbTotal
            // 
            this.txtbTotal.Enabled = false;
            this.txtbTotal.Location = new System.Drawing.Point(515, 415);
            this.txtbTotal.Name = "txtbTotal";
            this.txtbTotal.Size = new System.Drawing.Size(100, 23);
            this.txtbTotal.TabIndex = 23;
            // 
            // btnCalc
            // 
            this.btnCalc.Location = new System.Drawing.Point(329, 181);
            this.btnCalc.Name = "btnCalc";
            this.btnCalc.Size = new System.Drawing.Size(75, 23);
            this.btnCalc.TabIndex = 24;
            this.btnCalc.Text = "Calcular";
            this.btnCalc.UseVisualStyleBackColor = true;
            this.btnCalc.Click += new System.EventHandler(this.btnCalc_Click);
            // 
            // btnLimpar
            // 
            this.btnLimpar.Location = new System.Drawing.Point(329, 231);
            this.btnLimpar.Name = "btnLimpar";
            this.btnLimpar.Size = new System.Drawing.Size(75, 23);
            this.btnLimpar.TabIndex = 25;
            this.btnLimpar.Text = "Limpar";
            this.btnLimpar.UseVisualStyleBackColor = true;
            this.btnLimpar.Click += new System.EventHandler(this.btnLimpar_Click);
            // 
            // brnSair
            // 
            this.brnSair.Location = new System.Drawing.Point(329, 278);
            this.brnSair.Name = "brnSair";
            this.brnSair.Size = new System.Drawing.Size(75, 23);
            this.brnSair.TabIndex = 26;
            this.brnSair.Text = "Sair";
            this.brnSair.UseVisualStyleBackColor = true;
            this.brnSair.Click += new System.EventHandler(this.brnSair_Click);
            // 
            // txtbVenc
            // 
            this.txtbVenc.Location = new System.Drawing.Point(95, 139);
            this.txtbVenc.Mask = "00/00/0000";
            this.txtbVenc.Name = "txtbVenc";
            this.txtbVenc.Size = new System.Drawing.Size(100, 23);
            this.txtbVenc.TabIndex = 27;
            this.txtbVenc.ValidatingType = typeof(System.DateTime);
            // 
            // txtbPag
            // 
            this.txtbPag.Location = new System.Drawing.Point(95, 215);
            this.txtbPag.Mask = "00/00/0000";
            this.txtbPag.Name = "txtbPag";
            this.txtbPag.Size = new System.Drawing.Size(100, 23);
            this.txtbPag.TabIndex = 28;
            this.txtbPag.ValidatingType = typeof(System.DateTime);
            // 
            // FormBoleto
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.txtbPag);
            this.Controls.Add(this.txtbVenc);
            this.Controls.Add(this.brnSair);
            this.Controls.Add(this.btnLimpar);
            this.Controls.Add(this.btnCalc);
            this.Controls.Add(this.txtbTotal);
            this.Controls.Add(this.txtbAcre);
            this.Controls.Add(this.txtbVD);
            this.Controls.Add(this.txtbVJ);
            this.Controls.Add(this.txtbVM);
            this.Controls.Add(this.txtbDA);
            this.Controls.Add(this.lbTotal);
            this.Controls.Add(this.lbAcre);
            this.Controls.Add(this.lbVD);
            this.Controls.Add(this.lbVJ);
            this.Controls.Add(this.lbVM);
            this.Controls.Add(this.lbDA);
            this.Controls.Add(this.txtbDesc);
            this.Controls.Add(this.txtbJuros);
            this.Controls.Add(this.txtbMulta);
            this.Controls.Add(this.txtbValor);
            this.Controls.Add(this.lbDesconto);
            this.Controls.Add(this.lbJuros);
            this.Controls.Add(this.lbMulta);
            this.Controls.Add(this.lbPag);
            this.Controls.Add(this.lbVenci);
            this.Controls.Add(this.lbValor);
            this.Name = "FormBoleto";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label lbValor;
        private Label lbVenci;
        private Label lbPag;
        private Label lbMulta;
        private Label lbJuros;
        private Label lbDesconto;
        private TextBox txtbValor;
        private TextBox txtbMulta;
        private TextBox txtbJuros;
        private TextBox txtbDesc;
        private Label lbDA;
        private Label lbVM;
        private Label lbVJ;
        private Label lbVD;
        private Label lbAcre;
        private Label lbTotal;
        private TextBox txtbDA;
        private TextBox txtbVM;
        private TextBox txtbVJ;
        private TextBox txtbVD;
        private TextBox txtbAcre;
        private TextBox txtbTotal;
        private Button btnCalc;
        private Button btnLimpar;
        private Button brnSair;
        private MaskedTextBox txtbVenc;
        private MaskedTextBox txtbPag;
    }
}