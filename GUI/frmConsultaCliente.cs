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
    public partial class frmConsultaCliente : Form
    {
        public frmConsultaCliente()
        {
            InitializeComponent();
        }

        private void frmConsultaCliente_Load(object sender, EventArgs e)
        {
            button1_Click(sender, e);
            dataGridView1.Columns[0].HeaderText = "Codigo";
            dataGridView1.Columns[0].Width = 50;
            dataGridView1.Columns[1].HeaderText = "Nome";
            dataGridView1.Columns[1].Width = 200;
            dataGridView1.Columns[2].HeaderText = "CPF";
            dataGridView1.Columns[2].Width = 150;
            dataGridView1.Columns[3].HeaderText = "CNH";
            dataGridView1.Columns[3].Width = 150;
            dataGridView1.Columns[4].HeaderText = "DataNascimento";
            dataGridView1.Columns[4].Width = 150;
            dataGridView1.Columns[5].HeaderText = "CEP";
            dataGridView1.Columns[5].Width = 100;
            dataGridView1.Columns[6].HeaderText = "Logradouro";
            dataGridView1.Columns[6].Width = 100;
            dataGridView1.Columns[7].HeaderText = "Complemento";
            dataGridView1.Columns[7].Width = 50;
            dataGridView1.Columns[8].HeaderText = "Numero";
            dataGridView1.Columns[8].Width = 50;
            dataGridView1.Columns[9].HeaderText = "Bairro";
            dataGridView1.Columns[9].Width = 100;
            dataGridView1.Columns[10].HeaderText = "Cidade";
            dataGridView1.Columns[10].Width = 100;
            dataGridView1.Columns[11].HeaderText = "UF";
            dataGridView1.Columns[11].Width = 100;
            dataGridView1.Columns["Foto"].Visible = false;
            dataGridView1.Columns["CaminhoFoto"].Visible = false;
            dataGridView1.Columns[12].HeaderText = "RG";
            dataGridView1.Columns[12].Width = 100;

       
        }

        private void button1_Click(object sender, EventArgs e)
        {
            DALConexao cx = new DALConexao(DadosDaConexao.StringDeConexao);
            BLLClientes bll = new BLLClientes(cx);
            dataGridView1.DataSource = bll.Localizar(textBox1.Text);
        }
       

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
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
    }
}
