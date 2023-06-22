
namespace GUI
{
    partial class frmCadastroLocações
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
            this.txtCodigo = new System.Windows.Forms.TextBox();
            this.mtbCriação = new System.Windows.Forms.MaskedTextBox();
            this.mtbRetirada = new System.Windows.Forms.MaskedTextBox();
            this.mtbDevolução = new System.Windows.Forms.MaskedTextBox();
            this.txtValorTotal = new System.Windows.Forms.TextBox();
            this.cbCodigoDoCliente = new System.Windows.Forms.ComboBox();
            this.cbLocação = new System.Windows.Forms.ComboBox();
            this.label8 = new System.Windows.Forms.Label();
            this.cbNomeCliente = new System.Windows.Forms.ComboBox();
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
            this.pnDados.Controls.Add(this.cbNomeCliente);
            this.pnDados.Controls.Add(this.label8);
            this.pnDados.Controls.Add(this.cbLocação);
            this.pnDados.Controls.Add(this.cbCodigoDoCliente);
            this.pnDados.Controls.Add(this.txtValorTotal);
            this.pnDados.Controls.Add(this.mtbDevolução);
            this.pnDados.Controls.Add(this.mtbRetirada);
            this.pnDados.Controls.Add(this.mtbCriação);
            this.pnDados.Controls.Add(this.txtCodigo);
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
            this.label1.Location = new System.Drawing.Point(28, 24);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(40, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Código";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(28, 63);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(84, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Data de Criação";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(28, 102);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(88, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Data de Retirada";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(28, 141);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(100, 13);
            this.label4.TabIndex = 3;
            this.label4.Text = "Data de Devolução";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(273, 24);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(90, 13);
            this.label5.TabIndex = 4;
            this.label5.Text = "Código do Cliente";
            this.label5.Click += new System.EventHandler(this.label5_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(273, 102);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(58, 13);
            this.label6.TabIndex = 5;
            this.label6.Text = "Valor Total";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(273, 141);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(97, 13);
            this.label7.TabIndex = 6;
            this.label7.Text = "Status da Locação";
            // 
            // txtCodigo
            // 
            this.txtCodigo.Location = new System.Drawing.Point(31, 40);
            this.txtCodigo.Name = "txtCodigo";
            this.txtCodigo.Size = new System.Drawing.Size(133, 20);
            this.txtCodigo.TabIndex = 7;
            // 
            // mtbCriação
            // 
            this.mtbCriação.Location = new System.Drawing.Point(31, 79);
            this.mtbCriação.Mask = "00/00/0000";
            this.mtbCriação.Name = "mtbCriação";
            this.mtbCriação.Size = new System.Drawing.Size(133, 20);
            this.mtbCriação.TabIndex = 9;
            this.mtbCriação.ValidatingType = typeof(System.DateTime);
            // 
            // mtbRetirada
            // 
            this.mtbRetirada.Location = new System.Drawing.Point(31, 118);
            this.mtbRetirada.Mask = "00/00/0000";
            this.mtbRetirada.Name = "mtbRetirada";
            this.mtbRetirada.Size = new System.Drawing.Size(133, 20);
            this.mtbRetirada.TabIndex = 10;
            this.mtbRetirada.ValidatingType = typeof(System.DateTime);
            // 
            // mtbDevolução
            // 
            this.mtbDevolução.Location = new System.Drawing.Point(31, 157);
            this.mtbDevolução.Mask = "00/00/0000";
            this.mtbDevolução.Name = "mtbDevolução";
            this.mtbDevolução.Size = new System.Drawing.Size(133, 20);
            this.mtbDevolução.TabIndex = 12;
            this.mtbDevolução.ValidatingType = typeof(System.DateTime);
            // 
            // txtValorTotal
            // 
            this.txtValorTotal.Location = new System.Drawing.Point(276, 118);
            this.txtValorTotal.Name = "txtValorTotal";
            this.txtValorTotal.Size = new System.Drawing.Size(133, 20);
            this.txtValorTotal.TabIndex = 13;
            // 
            // cbCodigoDoCliente
            // 
            this.cbCodigoDoCliente.FormattingEnabled = true;
            this.cbCodigoDoCliente.Location = new System.Drawing.Point(276, 40);
            this.cbCodigoDoCliente.Name = "cbCodigoDoCliente";
            this.cbCodigoDoCliente.Size = new System.Drawing.Size(133, 21);
            this.cbCodigoDoCliente.TabIndex = 15;
            this.cbCodigoDoCliente.SelectedIndexChanged += new System.EventHandler(this.cbCodigoDoCliente_SelectedIndexChanged);
            // 
            // cbLocação
            // 
            this.cbLocação.FormattingEnabled = true;
            this.cbLocação.Location = new System.Drawing.Point(276, 156);
            this.cbLocação.Name = "cbLocação";
            this.cbLocação.Size = new System.Drawing.Size(133, 21);
            this.cbLocação.TabIndex = 16;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(273, 64);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(85, 13);
            this.label8.TabIndex = 17;
            this.label8.Text = "Nome do Cliente";
            // 
            // cbNomeCliente
            // 
            this.cbNomeCliente.FormattingEnabled = true;
            this.cbNomeCliente.Location = new System.Drawing.Point(276, 80);
            this.cbNomeCliente.Name = "cbNomeCliente";
            this.cbNomeCliente.Size = new System.Drawing.Size(133, 21);
            this.cbNomeCliente.TabIndex = 18;
            this.cbNomeCliente.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // frmCadastroLocações
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Name = "frmCadastroLocações";
            this.Text = "Cadastro de Locações";
            this.Load += new System.EventHandler(this.frmCadastroLocações_Load);
            this.panel2.ResumeLayout(false);
            this.pnDados.ResumeLayout(false);
            this.pnDados.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cbCodigoDoCliente;
        private System.Windows.Forms.TextBox txtValorTotal;
        private System.Windows.Forms.MaskedTextBox mtbDevolução;
        private System.Windows.Forms.MaskedTextBox mtbRetirada;
        private System.Windows.Forms.MaskedTextBox mtbCriação;
        private System.Windows.Forms.TextBox txtCodigo;
        private System.Windows.Forms.ComboBox cbLocação;
        private System.Windows.Forms.ComboBox cbNomeCliente;
        private System.Windows.Forms.Label label8;
    }
}
