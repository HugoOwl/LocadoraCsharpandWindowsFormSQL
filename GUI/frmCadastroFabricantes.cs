using DAL;
using Modelo;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using BLL;
namespace GUI
{
    public partial class frmCadastroFabricantes : GUI.frmModelo
    {
        public frmCadastroFabricantes()
        {
            InitializeComponent();
        }

        private void btInserir_Click(object sender, EventArgs e)
        {
            txtCodigo.Enabled = false;
            this.operacao = "inserir";
            this.alteraBotoes(2);

        }
        public void LimpaTela()
        {
            txtCodigo.Clear();
            txtNome.Clear();
        }

        private void frmCadastroFabricantes_Load(object sender, EventArgs e)
        {
            this.alteraBotoes(1);

        }

        private void btCancelar_Click(object sender, EventArgs e)
        {
            this.LimpaTela();
            this.alteraBotoes(1);
        }

        private void btSalvar_Click(object sender, EventArgs e)
        {
            try
            {
                //leitura dos dados
                ModeloFabricante modelo = new ModeloFabricante();
                modelo.Nome = txtNome.Text;
                //obj para gravar os dados no banco
                DALConexao cx = new DALConexao(DadosDaConexao.StringDeConexao);
                BLLFabricantes bll = new BLLFabricantes(cx);
                if (this.operacao == "inserir")
                {
                    //cadastrar uma categoria
                    bll.Incluir(modelo);
                    MessageBox.Show("Cadastro efetuado: Código " + modelo.Codigo.ToString());

                }
                else
                {
                    //alterar uma categoria
                    modelo.Codigo = Convert.ToInt32(txtCodigo.Text);
                    bll.Alterar(modelo);
                    MessageBox.Show("Cadastro alterado");
                }
                this.LimpaTela();
                this.alteraBotoes(1);
            }
            catch (Exception erro)
            {
                MessageBox.Show(erro.Message);
            }
        }

        private void btAlterar_Click(object sender, EventArgs e)
        {
            this.operacao = "alterar";
            this.alteraBotoes(2);
        }

        private void btLocalizar_Click(object sender, EventArgs e)
        {
            frmConsultaFabricantes f = new frmConsultaFabricantes();
            f.ShowDialog();
            if (f.codigo != 0)
            {
                DALConexao cx = new DALConexao(DadosDaConexao.StringDeConexao);
                BLLFabricantes bll = new BLLFabricantes(cx);
                ModeloFabricante modelo = bll.CarregaModeloFabricante(f.codigo);
                txtCodigo.Text = modelo.Codigo.ToString();
                txtNome.Text = modelo.Nome.ToString();
                alteraBotoes(3);
            }
            else
            {
                this.LimpaTela();
                this.alteraBotoes(1);
            }
            f.Dispose();
        }
    }
}
