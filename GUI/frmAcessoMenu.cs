using GUI;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GUI
{
    public partial class frmAcessoMenu : Form
    {
        public frmAcessoMenu()
        {
            InitializeComponent();
        }

        private void clientesToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void Acessomenu_Load(object sender, EventArgs e)
        {

        }

        private void cadastroDeLocaçãoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmCadastroLocações p = new frmCadastroLocações();
            p.ShowDialog();
            p.Dispose();
        }

        private void consultaDeLocaçãoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmCadastroCliente p = new frmCadastroCliente();
            p.ShowDialog();
            p.Dispose();
        }

        private void locaçõesToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void fabricantesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmCadastroFabricantes p = new frmCadastroFabricantes();
            p.ShowDialog();
            p.Dispose();
        }

        private void veículosToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            frmCadastroVeiculos p = new frmCadastroVeiculos();
            p.ShowDialog();
            p.Dispose();
        }

        private void consultaDeClientesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmConsultaCliente p = new frmConsultaCliente();
            p.ShowDialog();
            p.Dispose();
        }

        private void fabricantesToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            frmConsultaFabricantes p = new frmConsultaFabricantes();
            p.ShowDialog();
            p.Dispose();
        }

        private void veículosToolStripMenuItem2_Click(object sender, EventArgs e)
        {
            frmConsultaVeiculos p = new frmConsultaVeiculos();
            p.ShowDialog();
            p.Dispose();
        }

        private void cadastroDeClientesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmConsultaLocações p = new frmConsultaLocações();
            p.ShowDialog();
            p.Dispose();
        }
    }
}
