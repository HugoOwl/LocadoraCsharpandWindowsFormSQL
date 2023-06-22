using BLL;
using DAL;
using Modelo;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Globalization;
using System.IO;
using System.Text;
using System.Windows.Forms;

namespace GUI
{
    public partial class frmCadastroLocações : GUI.frmModelo
    {
        public frmCadastroLocações()
        {
            InitializeComponent();
           
        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void btInserir_Click(object sender, EventArgs e)
        {
            txtCodigo.Enabled = false;
            cbCodigoDoCliente.Enabled = false;

            this.operacao = "inserir";
            this.alteraBotoes(2);
        }
        private void comboboxcodcliente()
        {
            try
            {
                string connectionString = "Data Source=VMOKSTS32;initial catalog=Locadora;User ID=sa;Password=B1Admin@;"; 
                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    connection.Open();

                    string query = "SELECT Codigo, Nome FROM Clientes";
                    SqlCommand command = new SqlCommand(query, connection);
                    SqlDataReader reader = command.ExecuteReader();

                    while (reader.Read())
                    {
                        int codigoCliente = reader.GetInt32(0);
                        string nomeCliente = reader["Nome"].ToString();
                        cbNomeCliente.Items.Add(nomeCliente);

                        cbCodigoDoCliente.Items.Add(codigoCliente.ToString());
                    }

                    reader.Close();
                    connection.Close();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro ao carregar os códigos de cliente: " + ex.Message);
            }

        }
        private void LimpaTela()
        {
            txtCodigo.Clear();
            cbCodigoDoCliente.Text = null;
            cbNomeCliente.Text = null;
            txtValorTotal.Clear();
            mtbCriação.Clear();
            mtbDevolução.Clear();
            mtbRetirada.Clear();
            

        }
        private void frmCadastroLocações_Load(object sender, EventArgs e)
        {             
            this.alteraBotoes(1);
            mtbCriação.Text = DateTime.Now.ToString("dd/MM/yyyy");
            cbLocação.Items.Add("true");
            cbLocação.Items.Add("false");
            comboboxcodcliente();

        }

        private void btCancelar_Click(object sender, EventArgs e)
        {
            this.alteraBotoes(1);
            this.LimpaTela();
        }

        private void btSalvar_Click(object sender, EventArgs e)
        {
            try
            {

                DateTime dataCriacao;
                if (!DateTime.TryParseExact(mtbCriação.Text, "dd/MM/yyyy", CultureInfo.InvariantCulture, DateTimeStyles.None, out dataCriacao))
                {
                    MessageBox.Show("Data de criação inválida. Por favor, insira uma data válida no formato dd/MM/yyyy.");
                    mtbCriação.Focus();
                    return;
                }

                DateTime dataRetirada;
                if (!DateTime.TryParseExact(mtbRetirada.Text, "dd/MM/yyyy", CultureInfo.InvariantCulture, DateTimeStyles.None, out dataRetirada))
                {
                    MessageBox.Show("Data de retirada inválida. Por favor, insira uma data válida no formato dd/MM/yyyy.");
                    mtbRetirada.Focus();
                    return;
                }

                DateTime dataDevolucao;
                if (!DateTime.TryParseExact(mtbDevolução.Text, "dd/MM/yyyy", CultureInfo.InvariantCulture, DateTimeStyles.None, out dataDevolucao))
                {
                    MessageBox.Show("Data de devolução inválida. Por favor, insira uma data válida no formato dd/MM/yyyy.");
                    mtbDevolução.Focus();
                    return;
                }





                    ModeloLocações modelo = new ModeloLocações();
                    modelo.CodigoCliente = Convert.ToInt32(cbCodigoDoCliente.Text);
                    modelo.DataCriacao = Convert.ToDateTime(mtbCriação.Text);
                    modelo.DataDevolucao = Convert.ToDateTime(mtbDevolução.Text);
                    modelo.DataRetirada = Convert.ToDateTime(mtbRetirada.Text);
                    modelo.ValorTotal = Convert.ToDecimal(txtValorTotal.Text);
                    modelo.StatusLocacao = Convert.ToBoolean(cbLocação.Text);

                    DALConexao cx = new DALConexao(DadosDaConexao.StringDeConexao);
                    BLLLocaçoes bll = new BLLLocaçoes(cx);

                    if (this.operacao == "inserir")
                    {
                        bll.Incluir(modelo);
                        MessageBox.Show("Cadastro efetuado: Código " + modelo.Codigo.ToString());
                    var frmCadastroLocações2 = new frmCadastroLocações2();

                    var resultado = frmCadastroLocações2.ShowDialog();
                }
                    else
                    {
                        
                        modelo.Codigo = Convert.ToInt32(txtCodigo.Text);
                    bll.Alterar(modelo);

                    MessageBox.Show("Cadastro Alterado");
                    }

                    this.LimpaTela();
                    this.alteraBotoes(1);
            
                 

            }
            catch (Exception erro)
            {
                MessageBox.Show(erro.Message);
            }
        }

        private void btLocalizar_Click(object sender, EventArgs e)
        {
            frmConsultaLocações f = new frmConsultaLocações();
            f.ShowDialog();
            if (f.codigo != 0)
            {
                DALConexao cx = new DALConexao(DadosDaConexao.StringDeConexao);
                BLLLocaçoes bll = new BLLLocaçoes(cx);
                ModeloLocações modelo = bll.CarregaModeloLocações(f.codigo);
                BLLClientes bll2 = new BLLClientes(cx);
                ModeloCliente modelo2 = bll2.CarregaModeloCliente(f.codigo);
                cbNomeCliente.Text = modelo2.Nome.ToString();
                txtCodigo.Text = modelo.Codigo.ToString();
                cbCodigoDoCliente.Text = modelo.CodigoCliente.ToString();
                mtbCriação.Text = modelo.DataCriacao.ToString();
                mtbDevolução.Text = modelo.DataDevolucao.ToString();
                mtbRetirada.Text = modelo.DataRetirada.ToString();
                txtValorTotal.Text = modelo.ValorTotal.ToString();
                cbLocação.Text = modelo.StatusLocacao.ToString();
                alteraBotoes(3);
            }
            else
            {
                this.LimpaTela();
                this.alteraBotoes(1);
            }
            f.Dispose();
        }

        private void btExcluir_Click(object sender, EventArgs e)
        {
            try
            {
                DialogResult d = MessageBox.Show("Deseja excluir o registro?", "Aviso", MessageBoxButtons.YesNo);
                if (d.ToString() == "Yes")
                {
                    DALConexao cx = new DALConexao(DadosDaConexao.StringDeConexao);
                    BLLLocaçoes bll = new BLLLocaçoes(cx);
                    bll.Excluir(Convert.ToInt32(txtCodigo.Text));
                    this.LimpaTela();
                    this.alteraBotoes(1);
                }
            }
            catch
            {
                MessageBox.Show("Impossível excluir o registro. \n O registro esta sendo utilizado em outro local.");
                this.alteraBotoes(3);
            }
        }

        private void pnDados_Paint(object sender, PaintEventArgs e)
        {

        }

        private void btAlterar_Click(object sender, EventArgs e)
        {
            this.operacao = "alterar";
            this.alteraBotoes(2);
        }

        private void cbCodigoDoCliente_SelectedIndexChanged(object sender, EventArgs e)
        {
            int selectedCodeIndex = cbCodigoDoCliente.SelectedIndex;
            if (selectedCodeIndex >= 0 && selectedCodeIndex < cbNomeCliente.Items.Count)
            {
                cbNomeCliente.SelectedIndex = selectedCodeIndex;
            }
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            int selectedIndex = cbNomeCliente.SelectedIndex;
            if (selectedIndex >= 0 && selectedIndex < cbCodigoDoCliente.Items.Count)
            {
                cbCodigoDoCliente.SelectedIndex = selectedIndex;
            }
        }
    }
}
