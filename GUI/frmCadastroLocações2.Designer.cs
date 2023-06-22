
namespace GUI
{
    partial class frmCadastroLocações2
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
            this.cbLocação = new System.Windows.Forms.ComboBox();
            this.cbVeiculo = new System.Windows.Forms.ComboBox();
            this.txtCodigo = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.cbVeiculoNome = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.panel2.SuspendLayout();
            this.pnDados.SuspendLayout();
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
            // btInserir
            // 
            this.btInserir.Click += new System.EventHandler(this.btInserir_Click);
            // 
            // panel2
            // 
            this.panel2.Paint += new System.Windows.Forms.PaintEventHandler(this.panel2_Paint);
            // 
            // pnDados
            // 
            this.pnDados.Controls.Add(this.label5);
            this.pnDados.Controls.Add(this.cbVeiculoNome);
            this.pnDados.Controls.Add(this.label4);
            this.pnDados.Controls.Add(this.txtCodigo);
            this.pnDados.Controls.Add(this.cbVeiculo);
            this.pnDados.Controls.Add(this.cbLocação);
            this.pnDados.Controls.Add(this.label3);
            this.pnDados.Controls.Add(this.label2);
            this.pnDados.Controls.Add(this.label1);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(29, 11);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(43, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Código:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(29, 51);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(103, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Código de Locação:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(29, 131);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(93, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Código de Veiculo";
            // 
            // cbLocação
            // 
            this.cbLocação.FormattingEnabled = true;
            this.cbLocação.Location = new System.Drawing.Point(32, 67);
            this.cbLocação.Name = "cbLocação";
            this.cbLocação.Size = new System.Drawing.Size(121, 21);
            this.cbLocação.TabIndex = 3;
            this.cbLocação.SelectedIndexChanged += new System.EventHandler(this.cbLocação_SelectedIndexChanged);
            // 
            // cbVeiculo
            // 
            this.cbVeiculo.FormattingEnabled = true;
            this.cbVeiculo.Location = new System.Drawing.Point(32, 147);
            this.cbVeiculo.Name = "cbVeiculo";
            this.cbVeiculo.Size = new System.Drawing.Size(121, 21);
            this.cbVeiculo.TabIndex = 4;
            // 
            // txtCodigo
            // 
            this.txtCodigo.Location = new System.Drawing.Point(32, 28);
            this.txtCodigo.Name = "txtCodigo";
            this.txtCodigo.Size = new System.Drawing.Size(121, 20);
            this.txtCodigo.TabIndex = 5;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(29, 91);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(164, 13);
            this.label4.TabIndex = 6;
            this.label4.Text = "Nome do Veiculo que foi alugado";
            // 
            // cbVeiculoNome
            // 
            this.cbVeiculoNome.FormattingEnabled = true;
            this.cbVeiculoNome.Location = new System.Drawing.Point(32, 107);
            this.cbVeiculoNome.Name = "cbVeiculoNome";
            this.cbVeiculoNome.Size = new System.Drawing.Size(170, 21);
            this.cbVeiculoNome.TabIndex = 7;
            this.cbVeiculoNome.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(29, 128);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(0, 13);
            this.label5.TabIndex = 8;
            // 
            // frmCadastroLocações2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Name = "frmCadastroLocações2";
            this.Text = "Locação Linha";
            this.Load += new System.EventHandler(this.frmCadastroLocações2_Load);
            this.panel2.ResumeLayout(false);
            this.pnDados.ResumeLayout(false);
            this.pnDados.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TextBox txtCodigo;
        private System.Windows.Forms.ComboBox cbVeiculo;
        private System.Windows.Forms.ComboBox cbLocação;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ComboBox cbVeiculoNome;
        private System.Windows.Forms.Label label4;
    }
}
