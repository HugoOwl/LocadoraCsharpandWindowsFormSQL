using BLL;
using DAL;
using Modelo;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Text.RegularExpressions;
using System.Windows.Forms;
using System.Net.Http;
using System.Net;
using System.Threading.Tasks;
using System.IO;
using Newtonsoft.Json;

namespace GUI
{
    public partial class frmCadastroCliente : GUI.frmModelo
    {
        public string foto = "";

        public frmCadastroCliente()
        {
            InitializeComponent();
            PreencherComboBoxEstados();
        }
        private async Task PrencherCampoBoxCidadeAsync(string UF)
        {
            using (HttpClient client = new HttpClient())
            {
                string url = "https://servicodados.ibge.gov.br/api/v1/localidades/estados/"+UF+"/distritos";

                try
                {
                    string json = await client.GetStringAsync(url);
                    List<dynamic> municipios = JsonConvert.DeserializeObject<List<dynamic>>(json);

                    foreach (var municipio in municipios)
                    {
                        string nomeMunicipio = municipio.nome;
                        comboBox1.Items.Add(nomeMunicipio);
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Erro ao obter a lista de cidades: " + ex.Message);
                }

            }
        }
        private void PreencherComboBoxEstados()
        {

            cbUF.Items.Add("AC");
            cbUF.Items.Add("AL");
            cbUF.Items.Add("AP");
            cbUF.Items.Add("AM");
            cbUF.Items.Add("BA");
            cbUF.Items.Add("CE");
            cbUF.Items.Add("DF");
            cbUF.Items.Add("ES");
            cbUF.Items.Add("GO");
            cbUF.Items.Add("MA");
            cbUF.Items.Add("MT");
            cbUF.Items.Add("MS");
            cbUF.Items.Add("MG");
            cbUF.Items.Add("PA");
            cbUF.Items.Add("PB");
            cbUF.Items.Add("PR");
            cbUF.Items.Add("PE");
            cbUF.Items.Add("PI");
            cbUF.Items.Add("RJ");
            cbUF.Items.Add("RN");
            cbUF.Items.Add("RS");
            cbUF.Items.Add("RO");
            cbUF.Items.Add("RR");
            cbUF.Items.Add("SC");
            cbUF.Items.Add("SP");
            cbUF.Items.Add("SE");
            cbUF.Items.Add("TO");
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label8_Click(object sender, EventArgs e)
        {

        }

        private void frmCadastroCliente_Load(object sender, EventArgs e)
        {
            this.alteraBotoes(1);
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
            txtNome.Clear();
            txtCEP.Clear();
            txtNumero.Clear();
            maskedTextBox1.Clear();
            txtLogradouro.Clear();
            txtComplemento.Clear();
            this.foto = "";
            pbDados.Image = null;
            txtCNH.Clear();
            comboBox1.Text = null;
            txtBairro.Clear();

            mtbData.Clear();
            cbUF.Text = null;
            txtRG.Clear();
        }



        private void btSalvar_Click_1(object sender, EventArgs e)
        {
            try
            {
                ModeloCliente modelo = new ModeloCliente();
                modelo.Nome = txtNome.Text;

                modelo.CPF = maskedTextBox1.Text;
                modelo.CNH = txtCNH.Text;
                modelo.DataNascimento = Convert.ToDateTime(mtbData.Text);
                modelo.CEP = txtCEP.Text;
                modelo.Cidade = comboBox1.Text;
                modelo.UF = cbUF.Text;
                modelo.Bairro = txtBairro.Text;

                modelo.Logradouro = txtLogradouro.Text;
                modelo.Numero = txtNumero.Text;
                modelo.Complemento = txtComplemento.Text;
                modelo.RG = txtRG.Text;

                DALConexao cx = new DALConexao(DadosDaConexao.StringDeConexao);
                BLLClientes bll = new BLLClientes(cx);
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
                        ModeloCliente mt = bll.CarregaModeloCliente(modelo.Codigo);
                        modelo.Foto = mt.Foto;
                    }
                    else
                    {
                        modelo.CarregaImagem(this.foto);
                    }
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

        private void btInserirFoto_Click(object sender, EventArgs e)
        {
            OpenFileDialog od = new OpenFileDialog();
            od.ShowDialog();
            if (!string.IsNullOrEmpty(od.FileName))
            {
                this.foto = od.FileName;
                pbDados.Load(this.foto);
            }

        }


        private void cbUF_SelectedIndexChanged(object sender, EventArgs e)
        {




        }

        private void cbUF_Validating(object sender, CancelEventArgs e)
        {

        }

        private void maskedTextBox1_MaskInputRejected(object sender, MaskInputRejectedEventArgs e)
        {

        }

        private void maskedTextBox1_Validating(object sender, CancelEventArgs e)
        {

        }



        private void maskedTextBox1_TextChanged(object sender, EventArgs e)
        {


        }

        private void txtCNH_TextChanged(object sender, EventArgs e)
        {
            string cnh = txtCNH.Text.Replace(".", "").Replace("-", "");

            if (cnh.Length > 0)
            {
                cnh = Regex.Replace(cnh, "[^0-9]", ""); // Remove caracteres não numéricos

                if (cnh.Length > 3)
                    cnh = cnh.Insert(3, ".");

                if (cnh.Length > 7)
                    cnh = cnh.Insert(7, ".");

                if (cnh.Length > 11)
                    cnh = cnh.Insert(11, "-");
            }

            txtCNH.Text = cnh;
            txtCNH.SelectionStart = cnh.Length;
        }

        private void txtCNH_Validating(object sender, CancelEventArgs e)
        {
            string cnh = txtCNH.Text.Replace(".", "").Replace("-", "");

            if (string.IsNullOrEmpty(cnh) || !ValidarCNH(cnh))
            {
                e.Cancel = true;
                txtCNH.SelectAll();
                MessageBox.Show("CNH inválida!", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private bool ValidarCNH(string cnh)
        {
            // Verifica se a CNH possui 11 dígitos
            if (cnh.Length != 11)
                return false;

            // Verifica se todos os dígitos são iguais
            bool todosDigitosIguais = new Regex(@"^(\d)\1*$").IsMatch(cnh);
            if (todosDigitosIguais)
                return false;

            // Validação específica da CNH (pode variar de acordo com a legislação de cada país ou estado)
            // Implemente aqui a lógica de validação da CNH de acordo com as regras aplicáveis na sua região

            return true; // CNH v
        }
        private bool cepBeingFormatted = false;

        private void txtCEP_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtCEP_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && e.KeyChar != '\b')
            {
                e.Handled = true;
            }
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
        
        }


        public class Endereco
        {
            public string Uf { get; set; }
            public string Localidade { get; set; }
        }

        private void txtNome_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                e.SuppressKeyPress = true; // Evita o som de "beep" ao pressionar Enter
                maskedTextBox1.Focus(); // Define o foco para o campo do CPF
            }
        }

        private void maskedTextBox1_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                e.SuppressKeyPress = true;
                txtRG.Focus();
            }
        }

        private void txtCNH_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                e.SuppressKeyPress = true;
                txtCEP.Focus();
            }
        }

        private void mtbData_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                e.SuppressKeyPress = true;
                txtNumero.Focus();
            }
        }

        private void txtLogradouro_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtLogradouro_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                e.SuppressKeyPress = true;
                txtBairro.Focus();
            }
        }

        private void txtNumero_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                e.SuppressKeyPress = true;
                txtLogradouro.Focus();
            }
        }

        private void txtComplemento_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                e.SuppressKeyPress = true;
            }
        }

        private void btRemoverFoto_Click(object sender, EventArgs e)
        {
            this.foto = "";
            pbDados.Image = null;
        }

        private async void txtCEP_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                string cep = txtCEP.Text.Trim().Replace("-", "");

                if (cep.Length == 8)
                {
                    try
                    {
                        cep = $"{cep.Substring(0, 5)}-{cep.Substring(5)}"; 

                        string url = $"https://viacep.com.br/ws/{cep}/json/";

                        using (HttpClient client = new HttpClient())
                        {
                            HttpResponseMessage response = await client.GetAsync(url);
                            response.EnsureSuccessStatusCode();

                            string jsonResponse = await response.Content.ReadAsStringAsync();

                            dynamic data = JsonConvert.DeserializeObject(jsonResponse);

                            string estado = data.uf;
                            string cidade = data.localidade;

                            // Atualiza os campos de estado e cidade
                            cbUF.SelectedItem = estado;
                            comboBox1.SelectedItem = cidade;
                        }
                    }
                    catch (HttpRequestException ex)
                    {
                        MessageBox.Show($"Erro ao consultar o endereço: {ex.Message}");
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show($"Ocorreu um erro: {ex.Message}");
                    }
                }
                else
                {
                    MessageBox.Show("CEP inválido.");
                }
                if (e.KeyCode == Keys.Enter)
                {
                    e.SuppressKeyPress = true;
                    mtbData.Focus();
                }
            }
        }

        private void txtRG_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                e.SuppressKeyPress = true;
                txtCNH.Focus();
            }
        }

        private void pnDados_Paint(object sender, PaintEventArgs e)
        {

        }

        private void btCancelar_Click(object sender, EventArgs e)
        {
            this.alteraBotoes(1);
            this.LimpaTela();
        }

        private void btExcluir_Click(object sender, EventArgs e)
        {
            try
            {
                DialogResult d = MessageBox.Show("Deseja excluir o registro?", "Aviso", MessageBoxButtons.YesNo);
                if (d.ToString() == "Yes")
                {
                    DALConexao cx = new DALConexao(DadosDaConexao.StringDeConexao);
                    BLLClientes bll = new BLLClientes(cx);
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

        private void txtBairro_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                e.SuppressKeyPress = true;
                txtComplemento.Focus();
            }
        }

        private void txtRG_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtRG_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (Char.IsDigit(e.KeyChar))
            {
                // Adiciona o separador na posição correta
                if (txtRG.TextLength == 2 || txtRG.TextLength == 6)
                    txtRG.Text += ".";
                else if (txtRG.TextLength == 10)
                    txtRG.Text += "-";

                // Adiciona o caracter digitado
                txtRG.AppendText(e.KeyChar.ToString());

                // Impede que o caracter digitado seja inserido novamente
                e.Handled = true;
            }
        }

        private void btLocalizar_Click(object sender, EventArgs e)
        {
            frmConsultaCliente f = new frmConsultaCliente();
            f.ShowDialog();
            if (f.codigo != 0)
            {
                DALConexao cx = new DALConexao(DadosDaConexao.StringDeConexao);
                BLLClientes bll = new BLLClientes(cx);
                ModeloCliente modelo = bll.CarregaModeloCliente(f.codigo);
                txtCodigo.Text = modelo.Codigo.ToString();               
                txtNome.Text = modelo.Nome.ToString();
                maskedTextBox1.Text = modelo.CPF.ToString();
                cbUF.Text = modelo.UF.ToString();
                txtCNH.Text = modelo.CNH.ToString();
                mtbData.Text = modelo.DataNascimento.ToString();
                txtCEP.Text = modelo.CEP.ToString();
                txtLogradouro.Text = modelo.Logradouro.ToString();
                txtComplemento.Text = modelo.Complemento.ToString();
                txtNumero.Text = modelo.Numero.ToString();
                txtBairro.Text = modelo.Bairro.ToString();
                comboBox1.Text = modelo.Cidade.ToString();
                try
                {
                    MemoryStream ms = new MemoryStream(modelo.Foto);
                    pbDados.Image = Image.FromStream(ms);
                    this.foto = "Foto Original";
                }
                catch { }
                txtRG.Text = modelo.RG.ToString();


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

        private void pbDados_Click(object sender, EventArgs e)
        {

        }

        private void cbUF_TextChanged(object sender, EventArgs e)
        {
            var UF = cbUF.Text;
            comboBox1.Items.Clear();

            PrencherCampoBoxCidadeAsync(UF);

        }
    }
}

