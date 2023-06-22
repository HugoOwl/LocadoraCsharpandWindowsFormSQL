using BLL;
using DAL;
using Modelo;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace GUI
{
    public partial class CadastroLocaçãoLinha : GUI.frmModelo
    {
        public CadastroLocaçãoLinha()
        {
            InitializeComponent();
        }

        private void CadastroLocaçãoLinha_Load(object sender, EventArgs e)
        {
            PreencherComboBoxCodLocação();
            PreencherComboBoxCodVeiculos();
        }

        private void btInserir_Click(object sender, EventArgs e)
        {
            txtCodigo.Enabled = false;
            this.operacao = "inserir";
            this.alteraBotoes(2);
        }
        private void LimpaTela()
        {
            txtCodigo.Clear();
            cbVeiculo = null;
            cbLocação = null;

        }
        private void PreencherComboBoxCodLocação()
        {
            try
            {
                // Conexão com o banco de dados
                string connectionString = "Data Source=VMOKSTS32;initial catalog=Locadora;User ID=sa;Password=B1Admin@;"; // Substitua pela sua string de conexão do SQL Server
                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    connection.Open();

                    // Consulta SQL para obter os códigos de cliente da tabela
                    string query = "SELECT Codigo FROM Locacoes";
                    SqlCommand command = new SqlCommand(query, connection);
                    SqlDataReader reader = command.ExecuteReader();

                    // Adicionar os códigos de cliente ao ComboBox
                    while (reader.Read())
                    {
                        int CodigoLocadora = reader.GetInt32(0);
                        cbLocação.Items.Add(CodigoLocadora.ToString());
                    }

                    // Fechar o DataReader e a conexão
                    reader.Close();
                    connection.Close();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro ao carregar os códigos de cliente: " + ex.Message);
            }
        }
        private void PreencherComboBoxCodVeiculos()
        {
            try
            {
                // Conexão com o banco de dados
                string connectionString = "Data Source=VMOKSTS32;initial catalog=Locadora;User ID=sa;Password=B1Admin@;"; // Substitua pela sua string de conexão do SQL Server
                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    connection.Open();

                    // Consulta SQL para obter os códigos de cliente da tabela
                    string query = "SELECT Codigo FROM Veiculos";
                    SqlCommand command = new SqlCommand(query, connection);
                    SqlDataReader reader = command.ExecuteReader();

                    // Adicionar os códigos de cliente ao ComboBox
                    while (reader.Read())
                    {
                        int CodigoVeiculos = reader.GetInt32(0);
                        cbVeiculo.Items.Add(CodigoVeiculos.ToString());
                    }

                    // Fechar o DataReader e a conexão
                    reader.Close();
                    connection.Close();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro ao carregar os códigos de cliente: " + ex.Message);
            }
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
                ModeloLocaçõesLinhas modelo = new ModeloLocaçõesLinhas();
                modelo.CodigoLocacao = Convert.ToInt32(cbLocação.Text);

                modelo.CodigoVeiculo = Convert.ToInt32(cbVeiculo.Text);

                DALConexao cx = new DALConexao(DadosDaConexao.StringDeConexao);
                BLLLocacoesLinha bll = new BLLLocacoesLinha(cx);
                if (this.operacao == "inserir")
                {

                    bll.Incluir(modelo);
                    MessageBox.Show("Cadastro efetuado: Código " + modelo.Codigo.ToString());

                }
                else
                {
                    modelo.Codigo = Convert.ToInt32(txtCodigo.Text);



                    MessageBox.Show("Cadastro Alterado");
                }
                this.LimpaTela();
                this.alteraBotoes(1);
                this.Close();

            }
            catch (Exception erro)
            {
                MessageBox.Show(erro.Message);
            }
        }
    }
}
