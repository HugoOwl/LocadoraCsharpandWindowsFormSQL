using Modelo;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    public class DALLocacoesLinha
    {
        private DALConexao conexao;
        public DALLocacoesLinha(DALConexao cx)
        {
            this.conexao = cx;
        }
        public void Incluir(ModeloLocaçõesLinhas obj)
        {
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = conexao.ObjetoConexao;
            cmd.CommandText = "insert into Locacoes_Linhas (CodigoLocacao, CodigoVeiculo) " +
            "values (@CodigoLocacao,@CodigoVeiculo); select @@IDENTITY;";
            // int pro_cod, String pro_nome, int pro_cpf,
            //  Byte[] pro_caminhofoto, int pro_cnh, int pro_datanascimento, int pro_cep,
            //   String pro_logradouro, String pro_complemento, int pro_numero, String pro_bairro, String pro_cidade, String pro_uf, String pro_foto)
            cmd.Parameters.AddWithValue("@CodigoLocacao", obj.CodigoLocacao);
            cmd.Parameters.AddWithValue("@CodigoVeiculo", obj.CodigoVeiculo);
           

            cmd.Parameters["@CodigoLocacao"].SqlDbType = SqlDbType.Int;
         
            cmd.Parameters["@CodigoVeiculo"].SqlDbType = SqlDbType.Int;

            conexao.Conectar();
            obj.Codigo = Convert.ToInt32(cmd.ExecuteScalar());
            conexao.Desconectar();
        }
        public void Excluir(int codigo)
        {
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = conexao.ObjetoConexao;
            cmd.CommandText = "delete from Locacoes_Linhas where (Codigo) = (@Codigo)";
            cmd.Parameters.AddWithValue("@Codigo", codigo);
            conexao.Conectar();
            cmd.ExecuteNonQuery();
            conexao.Desconectar();
        }
        public void Alterar(ModeloLocaçõesLinhas modelo)
        {
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = conexao.ObjetoConexao;
            cmd.CommandText = "update categoria set CodigoLocacao = @CodigoLocacao where Codigo = @Codigo;";
            cmd.Parameters.AddWithValue("@CodigoLocacao", modelo.CodigoLocacao);
            cmd.Parameters.AddWithValue("@Codigo", modelo.Codigo);
            conexao.Conectar();
            cmd.ExecuteNonQuery();
            conexao.Desconectar();
        }
        public ModeloLocaçõesLinhas CarregaModeloLocaçõesLinhas(int codigo)
        {
            ModeloLocaçõesLinhas modelo = new ModeloLocaçõesLinhas();
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = conexao.ObjetoConexao;
            cmd.CommandText = "select * from Locacoes_Linhas where Codigo = @Codigo";
            cmd.Parameters.AddWithValue("@Codigo", codigo);
            conexao.Conectar();
            SqlDataReader registro = cmd.ExecuteReader();
            if (registro.HasRows)
            {
                registro.Read();
                modelo.Codigo = Convert.ToInt32(registro["Codigo"]);
                modelo.CodigoLocacao = Convert.ToInt32(registro["CodigoLocacao"]);
            }
            registro.Close();
            conexao.Desconectar();
            return modelo;
        }
    }
}
