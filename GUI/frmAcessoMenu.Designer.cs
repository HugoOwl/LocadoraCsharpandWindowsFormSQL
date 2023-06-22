
namespace GUI
{
    partial class frmAcessoMenu
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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.locaçõesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.cadastroDeLocaçãoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.consultaDeLocaçãoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.veículosToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.fabricantesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.clientesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.cadastroDeClientesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.consultaDeClientesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.veículosToolStripMenuItem2 = new System.Windows.Forms.ToolStripMenuItem();
            this.fabricantesToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.locaçõesToolStripMenuItem,
            this.clientesToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(800, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // locaçõesToolStripMenuItem
            // 
            this.locaçõesToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.cadastroDeLocaçãoToolStripMenuItem,
            this.consultaDeLocaçãoToolStripMenuItem,
            this.veículosToolStripMenuItem1,
            this.fabricantesToolStripMenuItem});
            this.locaçõesToolStripMenuItem.Name = "locaçõesToolStripMenuItem";
            this.locaçõesToolStripMenuItem.Size = new System.Drawing.Size(66, 20);
            this.locaçõesToolStripMenuItem.Text = "Cadastro";
            this.locaçõesToolStripMenuItem.Click += new System.EventHandler(this.locaçõesToolStripMenuItem_Click);
            // 
            // cadastroDeLocaçãoToolStripMenuItem
            // 
            this.cadastroDeLocaçãoToolStripMenuItem.Name = "cadastroDeLocaçãoToolStripMenuItem";
            this.cadastroDeLocaçãoToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.cadastroDeLocaçãoToolStripMenuItem.Text = "Locações";
            this.cadastroDeLocaçãoToolStripMenuItem.Click += new System.EventHandler(this.cadastroDeLocaçãoToolStripMenuItem_Click);
            // 
            // consultaDeLocaçãoToolStripMenuItem
            // 
            this.consultaDeLocaçãoToolStripMenuItem.Name = "consultaDeLocaçãoToolStripMenuItem";
            this.consultaDeLocaçãoToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.consultaDeLocaçãoToolStripMenuItem.Text = "Clientes";
            this.consultaDeLocaçãoToolStripMenuItem.Click += new System.EventHandler(this.consultaDeLocaçãoToolStripMenuItem_Click);
            // 
            // veículosToolStripMenuItem1
            // 
            this.veículosToolStripMenuItem1.Name = "veículosToolStripMenuItem1";
            this.veículosToolStripMenuItem1.Size = new System.Drawing.Size(180, 22);
            this.veículosToolStripMenuItem1.Text = "Veículos";
            this.veículosToolStripMenuItem1.Click += new System.EventHandler(this.veículosToolStripMenuItem1_Click);
            // 
            // fabricantesToolStripMenuItem
            // 
            this.fabricantesToolStripMenuItem.Name = "fabricantesToolStripMenuItem";
            this.fabricantesToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.fabricantesToolStripMenuItem.Text = "Fabricantes";
            this.fabricantesToolStripMenuItem.Click += new System.EventHandler(this.fabricantesToolStripMenuItem_Click);
            // 
            // clientesToolStripMenuItem
            // 
            this.clientesToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.cadastroDeClientesToolStripMenuItem,
            this.consultaDeClientesToolStripMenuItem,
            this.veículosToolStripMenuItem2,
            this.fabricantesToolStripMenuItem1});
            this.clientesToolStripMenuItem.Name = "clientesToolStripMenuItem";
            this.clientesToolStripMenuItem.Size = new System.Drawing.Size(66, 20);
            this.clientesToolStripMenuItem.Text = "Consulta";
            this.clientesToolStripMenuItem.Click += new System.EventHandler(this.clientesToolStripMenuItem_Click);
            // 
            // cadastroDeClientesToolStripMenuItem
            // 
            this.cadastroDeClientesToolStripMenuItem.Name = "cadastroDeClientesToolStripMenuItem";
            this.cadastroDeClientesToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.cadastroDeClientesToolStripMenuItem.Text = "Locadoras";
            this.cadastroDeClientesToolStripMenuItem.Click += new System.EventHandler(this.cadastroDeClientesToolStripMenuItem_Click);
            // 
            // consultaDeClientesToolStripMenuItem
            // 
            this.consultaDeClientesToolStripMenuItem.Name = "consultaDeClientesToolStripMenuItem";
            this.consultaDeClientesToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.consultaDeClientesToolStripMenuItem.Text = "Clientes";
            this.consultaDeClientesToolStripMenuItem.Click += new System.EventHandler(this.consultaDeClientesToolStripMenuItem_Click);
            // 
            // veículosToolStripMenuItem2
            // 
            this.veículosToolStripMenuItem2.Name = "veículosToolStripMenuItem2";
            this.veículosToolStripMenuItem2.Size = new System.Drawing.Size(180, 22);
            this.veículosToolStripMenuItem2.Text = "Veículos";
            this.veículosToolStripMenuItem2.Click += new System.EventHandler(this.veículosToolStripMenuItem2_Click);
            // 
            // fabricantesToolStripMenuItem1
            // 
            this.fabricantesToolStripMenuItem1.Name = "fabricantesToolStripMenuItem1";
            this.fabricantesToolStripMenuItem1.Size = new System.Drawing.Size(180, 22);
            this.fabricantesToolStripMenuItem1.Text = "Fabricantes";
            this.fabricantesToolStripMenuItem1.Click += new System.EventHandler(this.fabricantesToolStripMenuItem1_Click);
            // 
            // frmAcessoMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "frmAcessoMenu";
            this.Text = "Menu";
            this.Load += new System.EventHandler(this.Acessomenu_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem locaçõesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem consultaDeLocaçãoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem clientesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem cadastroDeClientesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem consultaDeClientesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem veículosToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem veículosToolStripMenuItem2;
        public System.Windows.Forms.ToolStripMenuItem cadastroDeLocaçãoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem fabricantesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem fabricantesToolStripMenuItem1;
    }
}