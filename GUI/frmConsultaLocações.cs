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
    public partial class frmConsultaLocações : Form
    {
        public frmConsultaLocações()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            DALConexao cx = new DALConexao(DadosDaConexao.StringDeConexao);
            BLLLocaçoes bll = new BLLLocaçoes(cx);
            dataGridView1.DataSource = bll.Localizar(textBox1.Text);
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }
        public int codigo = 0;

        private void dataGridView1_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                this.codigo = Convert.ToInt32(dataGridView1.Rows[e.RowIndex].Cells[0].Value);
                this.Close();
            }
        }

        private void frmConsultaLocações_Load(object sender, EventArgs e)
        {
            button1_Click(sender, e);
            dataGridView1.Columns[0].HeaderText = "Codigo";
            dataGridView1.Columns[0].Width = 50;
            dataGridView1.Columns[1].HeaderText = "CodigoCliente";
            dataGridView1.Columns[1].Width = 200;
            dataGridView1.Columns[2].HeaderText = "DataCriacao";
            dataGridView1.Columns[2].Width = 150;
            dataGridView1.Columns[3].HeaderText = "DataRetirada";
            dataGridView1.Columns[3].Width = 150;
            dataGridView1.Columns[4].HeaderText = "DataDevolucao";
            dataGridView1.Columns[4].Width = 150;
            dataGridView1.Columns[5].HeaderText = "ValorTotal";
            dataGridView1.Columns[5].Width = 100;
            dataGridView1.Columns[6].HeaderText = "StatusLocacao";
            dataGridView1.Columns[6].Width = 100;

            dataGridView1.Columns[7].HeaderText = "CodigoVeiculo";
            dataGridView1.Columns[7].Width = 100;
        }
    }
}
