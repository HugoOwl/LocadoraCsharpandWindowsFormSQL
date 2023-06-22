
namespace GUI
{
    partial class frmCadastroCliente
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
            this.cbUF = new System.Windows.Forms.ComboBox();
            this.mtbData = new System.Windows.Forms.MaskedTextBox();
            this.txtNome = new System.Windows.Forms.TextBox();
            this.txtCNH = new System.Windows.Forms.TextBox();
            this.txtCEP = new System.Windows.Forms.TextBox();
            this.txtNumero = new System.Windows.Forms.TextBox();
            this.txtLogradouro = new System.Windows.Forms.TextBox();
            this.pbDados = new System.Windows.Forms.PictureBox();
            this.btInserirFoto = new System.Windows.Forms.Button();
            this.btRemoverFoto = new System.Windows.Forms.Button();
            this.txtComplemento = new System.Windows.Forms.TextBox();
            this.label12 = new System.Windows.Forms.Label();
            this.txtBairro = new System.Windows.Forms.TextBox();
            this.maskedTextBox1 = new System.Windows.Forms.MaskedTextBox();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.txtRG = new System.Windows.Forms.TextBox();
            this.label13 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.txtCodigo = new System.Windows.Forms.TextBox();
            this.panel2.SuspendLayout();
            this.pnDados.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbDados)).BeginInit();
            this.SuspendLayout();
            // 
            // btCancelar
            // 
            this.btCancelar.Click += new System.EventHandler(this.btCancelar_Click);
            // 
            // btSalvar
            // 
            this.btSalvar.Click += new System.EventHandler(this.btSalvar_Click_1);
            // 
            // btExcluir
            // 
            this.btExcluir.Click += new System.EventHandler(this.btExcluir_Click);
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
            this.pnDados.Controls.Add(this.txtCodigo);
            this.pnDados.Controls.Add(this.label14);
            this.pnDados.Controls.Add(this.label13);
            this.pnDados.Controls.Add(this.txtRG);
            this.pnDados.Controls.Add(this.comboBox1);
            this.pnDados.Controls.Add(this.maskedTextBox1);
            this.pnDados.Controls.Add(this.txtBairro);
            this.pnDados.Controls.Add(this.label12);
            this.pnDados.Controls.Add(this.btRemoverFoto);
            this.pnDados.Controls.Add(this.btInserirFoto);
            this.pnDados.Controls.Add(this.pbDados);
            this.pnDados.Controls.Add(this.txtComplemento);
            this.pnDados.Controls.Add(this.txtLogradouro);
            this.pnDados.Controls.Add(this.txtNumero);
            this.pnDados.Controls.Add(this.txtCEP);
            this.pnDados.Controls.Add(this.txtCNH);
            this.pnDados.Controls.Add(this.txtNome);
            this.pnDados.Controls.Add(this.mtbData);
            this.pnDados.Controls.Add(this.cbUF);
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
            this.label1.Location = new System.Drawing.Point(13, 49);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(35, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Nome";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(13, 88);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(27, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "CPF";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(13, 127);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(30, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "CNH";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(13, 166);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(104, 13);
            this.label4.TabIndex = 3;
            this.label4.Text = "Data de Nascimento";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(171, 127);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(28, 13);
            this.label5.TabIndex = 4;
            this.label5.Text = "CEP";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(13, 205);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(40, 13);
            this.label6.TabIndex = 5;
            this.label6.Text = "Cidade";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(171, 166);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(21, 13);
            this.label7.TabIndex = 6;
            this.label7.Text = "UF";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(13, 244);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(61, 13);
            this.label8.TabIndex = 7;
            this.label8.Text = "Logradouro";
            this.label8.Click += new System.EventHandler(this.label8_Click);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(171, 206);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(44, 13);
            this.label9.TabIndex = 8;
            this.label9.Text = "Número";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(13, 283);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(71, 13);
            this.label10.TabIndex = 9;
            this.label10.Text = "Complemento";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(400, 14);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(28, 13);
            this.label11.TabIndex = 10;
            this.label11.Text = "Foto";
            // 
            // cbUF
            // 
            this.cbUF.FormattingEnabled = true;
            this.cbUF.Location = new System.Drawing.Point(174, 182);
            this.cbUF.Name = "cbUF";
            this.cbUF.Size = new System.Drawing.Size(171, 21);
            this.cbUF.TabIndex = 11;
            this.cbUF.SelectedIndexChanged += new System.EventHandler(this.cbUF_SelectedIndexChanged);
            this.cbUF.TextChanged += new System.EventHandler(this.cbUF_TextChanged);
            this.cbUF.Validating += new System.ComponentModel.CancelEventHandler(this.cbUF_Validating);
            // 
            // mtbData
            // 
            this.mtbData.Location = new System.Drawing.Point(16, 182);
            this.mtbData.Mask = "00/00/0000";
            this.mtbData.Name = "mtbData";
            this.mtbData.Size = new System.Drawing.Size(134, 20);
            this.mtbData.TabIndex = 12;
            this.mtbData.ValidatingType = typeof(System.DateTime);
            this.mtbData.KeyDown += new System.Windows.Forms.KeyEventHandler(this.mtbData_KeyDown);
            // 
            // txtNome
            // 
            this.txtNome.Location = new System.Drawing.Point(16, 65);
            this.txtNome.Name = "txtNome";
            this.txtNome.Size = new System.Drawing.Size(329, 20);
            this.txtNome.TabIndex = 13;
            this.txtNome.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtNome_KeyDown);
            // 
            // txtCNH
            // 
            this.txtCNH.Location = new System.Drawing.Point(16, 143);
            this.txtCNH.Name = "txtCNH";
            this.txtCNH.Size = new System.Drawing.Size(134, 20);
            this.txtCNH.TabIndex = 15;
            this.txtCNH.TextChanged += new System.EventHandler(this.txtCNH_TextChanged);
            this.txtCNH.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtCNH_KeyDown);
            this.txtCNH.Validating += new System.ComponentModel.CancelEventHandler(this.txtCNH_Validating);
            // 
            // txtCEP
            // 
            this.txtCEP.Location = new System.Drawing.Point(174, 143);
            this.txtCEP.Name = "txtCEP";
            this.txtCEP.Size = new System.Drawing.Size(171, 20);
            this.txtCEP.TabIndex = 16;
            this.txtCEP.TextChanged += new System.EventHandler(this.txtCEP_TextChanged);
            this.txtCEP.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtCEP_KeyDown);
            this.txtCEP.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtCEP_KeyPress);
            // 
            // txtNumero
            // 
            this.txtNumero.Location = new System.Drawing.Point(174, 221);
            this.txtNumero.Name = "txtNumero";
            this.txtNumero.Size = new System.Drawing.Size(171, 20);
            this.txtNumero.TabIndex = 17;
            this.txtNumero.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtNumero_KeyDown);
            // 
            // txtLogradouro
            // 
            this.txtLogradouro.Location = new System.Drawing.Point(16, 260);
            this.txtLogradouro.Name = "txtLogradouro";
            this.txtLogradouro.Size = new System.Drawing.Size(134, 20);
            this.txtLogradouro.TabIndex = 19;
            this.txtLogradouro.TextChanged += new System.EventHandler(this.txtLogradouro_TextChanged);
            this.txtLogradouro.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtLogradouro_KeyDown);
            // 
            // pbDados
            // 
            this.pbDados.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pbDados.Location = new System.Drawing.Point(403, 31);
            this.pbDados.Name = "pbDados";
            this.pbDados.Size = new System.Drawing.Size(359, 230);
            this.pbDados.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.pbDados.TabIndex = 21;
            this.pbDados.TabStop = false;
            this.pbDados.Click += new System.EventHandler(this.pbDados_Click);
            // 
            // btInserirFoto
            // 
            this.btInserirFoto.Location = new System.Drawing.Point(403, 267);
            this.btInserirFoto.Name = "btInserirFoto";
            this.btInserirFoto.Size = new System.Drawing.Size(148, 25);
            this.btInserirFoto.TabIndex = 22;
            this.btInserirFoto.Text = "Inserir Foto";
            this.btInserirFoto.UseVisualStyleBackColor = true;
            this.btInserirFoto.Click += new System.EventHandler(this.btInserirFoto_Click);
            // 
            // btRemoverFoto
            // 
            this.btRemoverFoto.Location = new System.Drawing.Point(611, 267);
            this.btRemoverFoto.Name = "btRemoverFoto";
            this.btRemoverFoto.Size = new System.Drawing.Size(151, 25);
            this.btRemoverFoto.TabIndex = 23;
            this.btRemoverFoto.Text = "Remover Foto";
            this.btRemoverFoto.UseVisualStyleBackColor = true;
            this.btRemoverFoto.Click += new System.EventHandler(this.btRemoverFoto_Click);
            // 
            // txtComplemento
            // 
            this.txtComplemento.Location = new System.Drawing.Point(16, 305);
            this.txtComplemento.Multiline = true;
            this.txtComplemento.Name = "txtComplemento";
            this.txtComplemento.Size = new System.Drawing.Size(329, 20);
            this.txtComplemento.TabIndex = 20;
            this.txtComplemento.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtComplemento_KeyDown);
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(171, 244);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(34, 13);
            this.label12.TabIndex = 24;
            this.label12.Text = "Bairro";
            // 
            // txtBairro
            // 
            this.txtBairro.Location = new System.Drawing.Point(174, 260);
            this.txtBairro.Name = "txtBairro";
            this.txtBairro.Size = new System.Drawing.Size(171, 20);
            this.txtBairro.TabIndex = 25;
            this.txtBairro.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtBairro_KeyDown);
            // 
            // maskedTextBox1
            // 
            this.maskedTextBox1.Location = new System.Drawing.Point(16, 104);
            this.maskedTextBox1.Name = "maskedTextBox1";
            this.maskedTextBox1.Size = new System.Drawing.Size(134, 20);
            this.maskedTextBox1.TabIndex = 26;
            this.maskedTextBox1.MaskInputRejected += new System.Windows.Forms.MaskInputRejectedEventHandler(this.maskedTextBox1_MaskInputRejected);
            this.maskedTextBox1.TextChanged += new System.EventHandler(this.maskedTextBox1_TextChanged);
            this.maskedTextBox1.KeyDown += new System.Windows.Forms.KeyEventHandler(this.maskedTextBox1_KeyDown);
            this.maskedTextBox1.Validating += new System.ComponentModel.CancelEventHandler(this.maskedTextBox1_Validating);
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(16, 221);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(134, 21);
            this.comboBox1.TabIndex = 27;
            this.comboBox1.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // txtRG
            // 
            this.txtRG.Location = new System.Drawing.Point(174, 104);
            this.txtRG.Name = "txtRG";
            this.txtRG.Size = new System.Drawing.Size(171, 20);
            this.txtRG.TabIndex = 28;
            this.txtRG.TextChanged += new System.EventHandler(this.txtRG_TextChanged);
            this.txtRG.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtRG_KeyDown);
            this.txtRG.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtRG_KeyPress);
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(171, 88);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(23, 13);
            this.label13.TabIndex = 29;
            this.label13.Text = "RG";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(13, 10);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(40, 13);
            this.label14.TabIndex = 30;
            this.label14.Text = "Código";
            // 
            // txtCodigo
            // 
            this.txtCodigo.Location = new System.Drawing.Point(16, 26);
            this.txtCodigo.Name = "txtCodigo";
            this.txtCodigo.Size = new System.Drawing.Size(101, 20);
            this.txtCodigo.TabIndex = 31;
            // 
            // frmCadastroCliente
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Name = "frmCadastroCliente";
            this.Text = "Cadastro de Clientes";
            this.Load += new System.EventHandler(this.frmCadastroCliente_Load);
            this.panel2.ResumeLayout(false);
            this.pnDados.ResumeLayout(false);
            this.pnDados.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbDados)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label label1;
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
        private System.Windows.Forms.TextBox txtNome;
        private System.Windows.Forms.MaskedTextBox mtbData;
        private System.Windows.Forms.ComboBox cbUF;
        private System.Windows.Forms.TextBox txtNumero;
        private System.Windows.Forms.TextBox txtCEP;
        private System.Windows.Forms.TextBox txtCNH;
        private System.Windows.Forms.Button btInserirFoto;
        private System.Windows.Forms.PictureBox pbDados;
        private System.Windows.Forms.TextBox txtLogradouro;
        private System.Windows.Forms.TextBox txtComplemento;
        private System.Windows.Forms.Button btRemoverFoto;
        private System.Windows.Forms.TextBox txtBairro;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.MaskedTextBox maskedTextBox1;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.TextBox txtRG;
        private System.Windows.Forms.TextBox txtCodigo;
        private System.Windows.Forms.Label label14;
    }
}
