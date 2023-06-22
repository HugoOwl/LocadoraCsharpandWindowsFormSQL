using BLL;
using DAL;
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
    public partial class frmConsultaFabricantes : Form
    {
        public int codigo = 0;

        public frmConsultaFabricantes()
        {
            InitializeComponent();
        }

        private void frmConsultaFabricantes_Load(object sender, EventArgs e)
        {
            button1_Click(sender, e);
            dataGridView1.Columns[0].HeaderText = "Código";
            dataGridView1.Columns[0].Width = 50;
            dataGridView1.Columns[1].HeaderText = "Nome";
            dataGridView1.Columns[1].Width = 150;

        }

        private void button1_Click(object sender, EventArgs e)
        {
            DALConexao cx = new DALConexao(DadosDaConexao.StringDeConexao);
            BLLFabricantes bll = new BLLFabricantes(cx);
            dataGridView1.DataSource = bll.Localizar(textBox1.Text);
        }

        private void dataGridView1_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                this.codigo = Convert.ToInt32(dataGridView1.Rows[e.RowIndex].Cells[0].Value);
                this.Close();
            }
        }
    }
}
