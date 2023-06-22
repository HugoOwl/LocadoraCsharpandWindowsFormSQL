using BLL;
using DAL;
using Modelo;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.IO;
using System.Text;
using System.Windows.Forms;

namespace GUI
{
    public partial class frmCadastroVeiculos : GUI.frmModelo
    {
        public frmCadastroVeiculos()
        {
            InitializeComponent();

            AddTiposVeiculosToComboBox();
            AddCoresCarrosToComboBox();
            AddTiposTransmissaoToComboBox();
            AddCodFabricanteToComboBox();

        }
        private void AddCodFabricanteToComboBox()
        {
            string connectionString = "Data Source=VMOKSTS32;initial catalog=Locadora;User ID=sa;Password=B1Admin@;";

            try
            {
                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    string query = "SELECT Codigo, Nome FROM Fabricantes";

                    SqlCommand command = new SqlCommand(query, connection);
                    connection.Open();

                    SqlDataReader reader = command.ExecuteReader();

                    while (reader.Read())
                    {
                        string codigoFabricante = reader["Codigo"].ToString();
                        string nomeFabricante = reader["Nome"].ToString();
                        cbFabricante.Items.Add(nomeFabricante);
                        cbCodigoDeFab.Items.Add(codigoFabricante);
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro ao conectar ao banco de dados: " + ex.Message);
            }
        }
        private void AddTiposTransmissaoToComboBox()
        {
            string[] tiposTransmissao = { "Manual", "Automático" };

            // Adicionar os tipos de transmissão ao ComboBox
            cbTipoDeTransmissão.Items.AddRange(tiposTransmissao);
        }
        private void AddCoresCarrosToComboBox()
        {
            Dictionary<string, string> coresCarros = new Dictionary<string, string>()
        {
            { "Preto", "Black" },
            { "Branco", "White" },
            { "Prata", "Silver" },
            { "Cinza", "Gray" },
            { "Azul", "Blue" },
            { "Vermelho", "Red" },
            { "Verde", "Green" },
            { "Amarelo", "Yellow" },
            { "Laranja", "Orange" },
            { "Roxo", "Purple" },
            { "Rosa", "Pink" },
            { "Marrom", "Brown" }
        };

            // Adicionar as cores de carros ao ComboBox
            foreach (var cor in coresCarros)
            {
                cbCor.Items.Add(cor.Key);
            }
        }
        private void AddTiposVeiculosToComboBox()
        {
            string[] tiposVeiculos = {
            "Carros de passeio",
            "SUVs",
            "Caminhões",
            "Ônibus",
            "Motocicletas",
            "Bicicletas",
            "Vans",
            "Veículos elétricos"
        };

            // Adicionar os tipos de veículos ao ComboBox
            cbTipoDeVeiculo.Items.AddRange(tiposVeiculos);
        }
        private void btInserir_Click(object sender, EventArgs e)
        {
            txtCodigo.Enabled = false;
            cbCodigoDeFab.Enabled = false;

            this.operacao = "inserir";
            this.alteraBotoes(2);
        }

        private void frmCadastroVeiculos_Load(object sender, EventArgs e)
        {
            this.alteraBotoes(1);

        }
        private void LimpaTela()
        {
            this.foto = "";

            txtAno.Clear();
            txtChassi.Clear();
            txtCodigo.Clear();
            txtModelo.Clear();
            txtRenavan.Clear();
            txtValorDiário.Clear();
            pbImagem.Image = null;
            cbCodigoDeFab.Text = null;
            cbCor.Text = null;
            cbTipoDeVeiculo.Text = null;
            cbTipoDeTransmissão.Text = null;
            txtPlaca.Clear();
            cbFabricante.Text = null;

        }
        public string foto = "";

        private void btSalvar_Click(object sender, EventArgs e)
        {
            try
            {
                ModeloVeiculos modelo = new ModeloVeiculos();
                modelo.Modelo = txtModelo.Text;

                modelo.Chassi = txtChassi.Text;
                modelo.Ano = Convert.ToInt32(txtAno.Text);
                modelo.Renavan = txtRenavan.Text;
                modelo.ValorDiaria = Convert.ToDecimal(txtValorDiário.Text);
                modelo.CodFabricante = Convert.ToInt32(cbCodigoDeFab.Text);
                modelo.Cor = cbCor.Text;

                modelo.TipoVeiculo = cbTipoDeVeiculo.Text;
                modelo.TipoTransmissao = cbTipoDeTransmissão.Text;
                modelo.Placa = txtPlaca.Text;
                DALConexao cx = new DALConexao(DadosDaConexao.StringDeConexao);
                BLLVeiculos bll = new BLLVeiculos(cx);
                if (this.operacao == "inserir")
                {
                    modelo.CarregaImagem(this.foto);

                    bll.Incluir(modelo);
                    MessageBox.Show("Cadastro efetuado: Código " + modelo.Codigo.ToString());

                }
                else
                {
                    modelo.Codigo = Convert.ToInt32(txtCodigo.Text);


                    if (this.foto == "Foto Original")
                    {
                        ModeloVeiculos mt = bll.CarregaModeloVeiculos(modelo.Codigo);
                        modelo.CaminhoImagem = mt.CaminhoImagem;
                    }
                    else
                    {
                        modelo.CarregaImagem(this.foto);
                    }
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
    
        private void button1_Click(object sender, EventArgs e)
        {
            OpenFileDialog od = new OpenFileDialog();
            od.ShowDialog();
            if (!string.IsNullOrEmpty(od.FileName))
            {
                this.foto = od.FileName;
                pbImagem.Load(this.foto);
            }
        }
        

        private void button2_Click(object sender, EventArgs e)
        {
            this.foto = "";
            pbImagem.Image = null;
        }

        private void txtCodigo_TextChanged(object sender, EventArgs e)
        {

        }

        private void btCancelar_Click(object sender, EventArgs e)
        {
            this.alteraBotoes(1);
            this.LimpaTela();
        }

        private void pnDados_Paint(object sender, PaintEventArgs e)
        {

        }

        private void btLocalizar_Click(object sender, EventArgs e)
        {
            frmConsultaVeiculos f = new frmConsultaVeiculos();
            f.ShowDialog();
            if (f.codigo != 0)
            {
                DALConexao cx = new DALConexao(DadosDaConexao.StringDeConexao);
                BLLVeiculos bll = new BLLVeiculos(cx);
                ModeloVeiculos modelo = bll.CarregaModeloVeiculos(f.codigo);
                txtCodigo.Text = modelo.Codigo.ToString();
                txtModelo.Text = modelo.Modelo.ToString();

                txtChassi.Text = modelo.Chassi.ToString();
                txtAno.Text = modelo.Ano.ToString();
                txtRenavan.Text = modelo.Renavan.ToString();
                txtValorDiário.Text = modelo.ValorDiaria.ToString();
                cbCodigoDeFab.Text = modelo.CodFabricante.ToString();
                cbCor.Text = modelo.Cor.ToString();
                cbTipoDeVeiculo.Text = modelo.TipoVeiculo.ToString();
                cbTipoDeTransmissão.Text = modelo.TipoTransmissao.ToString();
                txtPlaca.Text = modelo.Placa.ToString();
                try
                {
                    MemoryStream ms = new MemoryStream(modelo.Imagem);
                    pbImagem.Image = Image.FromStream(ms);
                    this.foto = "Foto Original";
                }
                catch { }

                alteraBotoes(3);
            }
            else
            {
                this.LimpaTela();
                this.alteraBotoes(1);
            }
            f.Dispose();
        }

        private void btAlterar_Click(object sender, EventArgs e)
        {
            this.operacao = "alterar";
            this.alteraBotoes(2);
        }

        private void cbFabricante_SelectedIndexChanged(object sender, EventArgs e)
        {
            int selectedIndex = cbFabricante.SelectedIndex;
            if (selectedIndex >= 0 && selectedIndex < cbCodigoDeFab.Items.Count)
            {
                cbCodigoDeFab.SelectedIndex = selectedIndex;
            }

        }

        private void cbCodigoDeFab_SelectedIndexChanged(object sender, EventArgs e)
        {
            int selectedIndex = cbCodigoDeFab.SelectedIndex;
            if (selectedIndex >= 0 && selectedIndex < cbFabricante.Items.Count)
            {
                cbFabricante.SelectedIndex = selectedIndex;
            }
        }

        private void pbImagem_Click(object sender, EventArgs e)
        {

        }
    }
}
