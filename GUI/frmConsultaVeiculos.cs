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
    public partial class frmConsultaVeiculos : Form
    {
        public frmConsultaVeiculos()
        {
            InitializeComponent();
        }

        private void frmConsultaVeiculos_Load(object sender, EventArgs e)
        {
            button1_Click(sender, e);
            dataGridView1.Columns[0].HeaderText = "Codigo";
            dataGridView1.Columns[0].Width = 50;
            dataGridView1.Columns[1].HeaderText = "Modelo";
            dataGridView1.Columns[1].Width = 200;
            dataGridView1.Columns[2].HeaderText = "CodFabricante";
            dataGridView1.Columns[2].Width = 150;
            dataGridView1.Columns[3].HeaderText = "Chassi";
            dataGridView1.Columns[3].Width = 150;
            dataGridView1.Columns[4].HeaderText = "Cor";
            dataGridView1.Columns[4].Width = 150;
            dataGridView1.Columns[5].HeaderText = "TipoTransmissao";
            dataGridView1.Columns[5].Width = 100;
            dataGridView1.Columns[6].HeaderText = "Renavan";
            dataGridView1.Columns[6].Width = 100;
     
            
            dataGridView1.Columns["Imagem"].Visible = false;
            dataGridView1.Columns["CaminhoImagem"].Visible = false;
            dataGridView1.Columns[12].HeaderText = "ValorDiaria";
            dataGridView1.Columns[12].Width = 100;
            dataGridView1.Columns[11].HeaderText = "TipoVeiculo";
            dataGridView1.Columns[11].Width = 100;
            dataGridView1.Columns[10].HeaderText = "Placa";
            dataGridView1.Columns[10].Width = 100;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            DALConexao cx = new DALConexao(DadosDaConexao.StringDeConexao);
            BLLVeiculos bll = new BLLVeiculos(cx);
            dataGridView1.DataSource = bll.Localizar(textBox1.Text);
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
