
namespace GUI
{
    partial class frmCadastroVeiculos
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.txtCodigo = new System.Windows.Forms.TextBox();
            this.cbCodigoDeFab = new System.Windows.Forms.ComboBox();
            this.txtModelo = new System.Windows.Forms.TextBox();
            this.cbTipoDeVeiculo = new System.Windows.Forms.ComboBox();
            this.txtAno = new System.Windows.Forms.TextBox();
            this.txtRenavan = new System.Windows.Forms.TextBox();
            this.txtChassi = new System.Windows.Forms.TextBox();
            this.cbCor = new System.Windows.Forms.ComboBox();
            this.cbTipoDeTransmissão = new System.Windows.Forms.ComboBox();
            this.txtValorDiário = new System.Windows.Forms.TextBox();
            this.pbImagem = new System.Windows.Forms.PictureBox();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.label12 = new System.Windows.Forms.Label();
            this.txtPlaca = new System.Windows.Forms.TextBox();
            this.label13 = new System.Windows.Forms.Label();
            this.cbFabricante = new System.Windows.Forms.ComboBox();
            this.panel2.SuspendLayout();
            this.pnDados.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbImagem)).BeginInit();
            this.SuspendLayout();
            // 
            // btCancelar
            // 
            this.btCancelar.Click += new System.EventHandler(this.btCancelar_Click);
            // 
            // btSalvar
            // 
            this.btSalvar.Click += new System.EventHandler(this.btSalvar_Click);
            // 
            // btAlterar
            // 
            this.btAlterar.Click += new System.EventHandler(this.btAlterar_Click);
            // 
            // btLocalizar
            // 
            this.btLocalizar.Click += new System.EventHandler(this.btLocalizar_Click);
            // 
            // btInserir
            // 
            this.btInserir.Click += new System.EventHandler(this.btInserir_Click);
            // 
            // pnDados
            // 
            this.pnDados.Controls.Add(this.cbFabricante);
            this.pnDados.Controls.Add(this.label13);
            this.pnDados.Controls.Add(this.txtPlaca);
            this.pnDados.Controls.Add(this.label12);
            this.pnDados.Controls.Add(this.button2);
            this.pnDados.Controls.Add(this.button1);
            this.pnDados.Controls.Add(this.pbImagem);
            this.pnDados.Controls.Add(this.txtValorDiário);
            this.pnDados.Controls.Add(this.cbTipoDeTransmissão);
            this.pnDados.Controls.Add(this.cbCor);
            this.pnDados.Controls.Add(this.txtChassi);
            this.pnDados.Controls.Add(this.txtRenavan);
            this.pnDados.Controls.Add(this.txtAno);
            this.pnDados.Controls.Add(this.cbTipoDeVeiculo);
            this.pnDados.Controls.Add(this.txtModelo);
            this.pnDados.Controls.Add(this.cbCodigoDeFab);
            this.pnDados.Controls.Add(this.txtCodigo);
            this.pnDados.Controls.Add(this.label11);
            this.pnDados.Controls.Add(this.label10);
            this.pnDados.Controls.Add(this.label9);
            this.pnDados.Controls.Add(this.label8);
            this.pnDados.Controls.Add(this.label7);
            this.pnDados.Controls.Add(this.label6);
            this.pnDados.Controls.Add(this.label5);
            this.pnDados.Controls.Add(this.label4);
            this.pnDados.Controls.Add(this.label3);
            this.pnDados.Controls.Add(this.label2);
            this.pnDados.Controls.Add(this.label1);
            this.pnDados.Paint += new System.Windows.Forms.PaintEventHandler(this.pnDados_Paint);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(21, 22);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(40, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Código";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(21, 61);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(42, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Modelo";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(204, 22);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(108, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Codigo do Fabricante";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(21, 139);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(38, 13);
            this.label4.TabIndex = 3;
            this.label4.Text = "Chassi";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(204, 178);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(23, 13);
            this.label5.TabIndex = 4;
            this.label5.Text = "Cor";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(204, 217);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(105, 13);
            this.label6.TabIndex = 5;
            this.label6.Text = "Tipo de Transmissão";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(204, 139);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(51, 13);
            this.label7.TabIndex = 6;
            this.label7.Text = "Renavan";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(21, 178);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(61, 13);
            this.label8.TabIndex = 7;
            this.label8.Text = "Valor Diário";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(401, 22);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(28, 13);
            this.label9.TabIndex = 8;
            this.label9.Text = "Foto";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(204, 100);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(83, 13);
            this.label10.TabIndex = 9;
            this.label10.Text = "Tipo de Veículo";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(21, 100);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(26, 13);
            this.label11.TabIndex = 10;
            this.label11.Text = "Ano";
            // 
            // txtCodigo
            // 
            this.txtCodigo.Location = new System.Drawing.Point(24, 38);
            this.txtCodigo.Name = "txtCodigo";
            this.txtCodigo.Size = new System.Drawing.Size(126, 20);
            this.txtCodigo.TabIndex = 11;
            this.txtCodigo.TextChanged += new System.EventHandler(this.txtCodigo_TextChanged);
            // 
            // cbCodigoDeFab
            // 
            this.cbCodigoDeFab.FormattingEnabled = true;
            this.cbCodigoDeFab.Location = new System.Drawing.Point(207, 38);
            this.cbCodigoDeFab.Name = "cbCodigoDeFab";
            this.cbCodigoDeFab.Size = new System.Drawing.Size(138, 21);
            this.cbCodigoDeFab.TabIndex = 12;
            this.cbCodigoDeFab.SelectedIndexChanged += new System.EventHandler(this.cbCodigoDeFab_SelectedIndexChanged);
            // 
            // txtModelo
            // 
            this.txtModelo.Location = new System.Drawing.Point(24, 77);
            this.txtModelo.Name = "txtModelo";
            this.txtModelo.Size = new System.Drawing.Size(126, 20);
            this.txtModelo.TabIndex = 13;
            // 
            // cbTipoDeVeiculo
            // 
            this.cbTipoDeVeiculo.FormattingEnabled = true;
            this.cbTipoDeVeiculo.Location = new System.Drawing.Point(207, 116);
            this.cbTipoDeVeiculo.Name = "cbTipoDeVeiculo";
            this.cbTipoDeVeiculo.Size = new System.Drawing.Size(138, 21);
            this.cbTipoDeVeiculo.TabIndex = 14;
            // 
            // txtAno
            // 
            this.txtAno.Location = new System.Drawing.Point(24, 116);
            this.txtAno.Name = "txtAno";
            this.txtAno.Size = new System.Drawing.Size(126, 20);
            this.txtAno.TabIndex = 15;
            // 
            // txtRenavan
            // 
            this.txtRenavan.Location = new System.Drawing.Point(207, 155);
            this.txtRenavan.Name = "txtRenavan";
            this.txtRenavan.Size = new System.Drawing.Size(138, 20);
            this.txtRenavan.TabIndex = 16;
            // 
            // txtChassi
            // 
            this.txtChassi.Location = new System.Drawing.Point(24, 155);
            this.txtChassi.Name = "txtChassi";
            this.txtChassi.Size = new System.Drawing.Size(126, 20);
            this.txtChassi.TabIndex = 17;
            // 
            // cbCor
            // 
            this.cbCor.FormattingEnabled = true;
            this.cbCor.Location = new System.Drawing.Point(207, 194);
            this.cbCor.Name = "cbCor";
            this.cbCor.Size = new System.Drawing.Size(138, 21);
            this.cbCor.TabIndex = 18;
            // 
            // cbTipoDeTransmissão
            // 
            this.cbTipoDeTransmissão.FormattingEnabled = true;
            this.cbTipoDeTransmissão.Location = new System.Drawing.Point(207, 232);
            this.cbTipoDeTransmissão.Name = "cbTipoDeTransmissão";
            this.cbTipoDeTransmissão.Size = new System.Drawing.Size(138, 21);
            this.cbTipoDeTransmissão.TabIndex = 19;
            // 
            // txtValorDiário
            // 
            this.txtValorDiário.Location = new System.Drawing.Point(24, 194);
            this.txtValorDiário.Name = "txtValorDiário";
            this.txtValorDiário.Size = new System.Drawing.Size(126, 20);
            this.txtValorDiário.TabIndex = 20;
            // 
            // pbImagem
            // 
            this.pbImagem.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pbImagem.Location = new System.Drawing.Point(404, 38);
            this.pbImagem.Name = "pbImagem";
            this.pbImagem.Size = new System.Drawing.Size(324, 199);
            this.pbImagem.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.pbImagem.TabIndex = 21;
            this.pbImagem.TabStop = false;
            this.pbImagem.Click += new System.EventHandler(this.pbImagem_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(404, 243);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(123, 34);
            this.button1.TabIndex = 22;
            this.button1.Text = "Inserir Foto";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(605, 243);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(123, 34);
            this.button2.TabIndex = 23;
            this.button2.Text = "Remover Foto";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(21, 217);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(34, 13);
            this.label12.TabIndex = 24;
            this.label12.Text = "Placa";
            // 
            // txtPlaca
            // 
            this.txtPlaca.Location = new System.Drawing.Point(24, 233);
            this.txtPlaca.Name = "txtPlaca";
            this.txtPlaca.Size = new System.Drawing.Size(126, 20);
            this.txtPlaca.TabIndex = 25;
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(204, 60);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(103, 13);
            this.label13.TabIndex = 26;
            this.label13.Text = "Nome do Fabricante";
            // 
            // cbFabricante
            // 
            this.cbFabricante.FormattingEnabled = true;
            this.cbFabricante.Location = new System.Drawing.Point(207, 76);
            this.cbFabricante.Name = "cbFabricante";
            this.cbFabricante.Size = new System.Drawing.Size(138, 21);
            this.cbFabricante.TabIndex = 27;
            this.cbFabricante.SelectedIndexChanged += new System.EventHandler(this.cbFabricante_SelectedIndexChanged);
            // 
            // frmCadastroVeiculos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Name = "frmCadastroVeiculos";
            this.Text = "Cadastro de Veiculos";
            this.Load += new System.EventHandler(this.frmCadastroVeiculos_Load);
            this.panel2.ResumeLayout(false);
            this.pnDados.ResumeLayout(false);
            this.pnDados.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbImagem)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.PictureBox pbImagem;
        private System.Windows.Forms.TextBox txtValorDiário;
        private System.Windows.Forms.ComboBox cbTipoDeTransmissão;
        private System.Windows.Forms.ComboBox cbCor;
        private System.Windows.Forms.TextBox txtChassi;
        private System.Windows.Forms.TextBox txtRenavan;
        private System.Windows.Forms.TextBox txtAno;
        private System.Windows.Forms.ComboBox cbTipoDeVeiculo;
        private System.Windows.Forms.TextBox txtModelo;
        private System.Windows.Forms.ComboBox cbCodigoDeFab;
        private System.Windows.Forms.TextBox txtCodigo;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtPlaca;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.ComboBox cbFabricante;
        private System.Windows.Forms.Label label13;
    }
}
