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
    public class DALLocações
    {
        private DALConexao conexao;
        public DALLocações(DALConexao cx)
        {
            this.conexao = cx;
        }
        public void Incluir(ModeloLocações obj)
        {
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = conexao.ObjetoConexao;
            cmd.CommandText = "insert into Locacoes (CodigoCliente, DataCriacao, DataRetirada, DataDevolucao, ValorTotal, StatusLocacao) " +
            "values (@CodigoCliente,@DataCriacao,@DataRetirada,@DataDevolucao,@ValorTotal,@StatusLocacao); select @@IDENTITY;";
            // int pro_cod, String pro_nome, int pro_cpf,
            //  Byte[] pro_caminhofoto, int pro_cnh, int pro_datanascimento, int pro_cep,
            //   String pro_logradouro, String pro_complemento, int pro_numero, String pro_bairro, String pro_cidade, String pro_uf, String pro_foto)
            cmd.Parameters.AddWithValue("@CodigoCliente", obj.CodigoCliente);
            cmd.Parameters.AddWithValue("@DataCriacao", obj.DataCriacao);
            cmd.Parameters.AddWithValue("@DataRetirada", obj.DataRetirada);
            cmd.Parameters.AddWithValue("@DataDevolucao", obj.DataDevolucao);
            cmd.Parameters.Add("@ValorTotal", SqlDbType.Decimal).Value = obj.ValorTotal;

            cmd.Parameters.AddWithValue("@StatusLocacao", obj.StatusLocacao);


            cmd.Parameters["@CodigoCliente"].SqlDbType = SqlDbType.Int;
            cmd.Parameters["@DataCriacao"].SqlDbType = SqlDbType.DateTime;
            cmd.Parameters["@DataRetirada"].SqlDbType = SqlDbType.DateTime;
            cmd.Parameters["@DataDevolucao"].SqlDbType = SqlDbType.DateTime;

            cmd.Parameters["@StatusLocacao"].SqlDbType = SqlDbType.Bit;
      

            conexao.Conectar();
            obj.Codigo = Convert.ToInt32(cmd.ExecuteScalar());
            conexao.Desconectar();
        }
        public DataTable Localizar(String valor)
        {

            SqlDataAdapter da = new SqlDataAdapter("SELECT L.Codigo, L.CodigoCliente, L.DataCriacao, L.DataRetirada, L.DataDevolucao, L.ValorTotal, L.StatusLocacao, LL.CodigoVeiculo FROM Locacoes AS L JOIN Locacoes_linhas AS LL ON L.Codigo = LL.CodigoLocacao WHERE L.Codigo LIKE '%" + valor + "%'", conexao.StringConexao);

            DataTable tabela = new DataTable();
            da.Fill(tabela);
            return tabela;
        }
        public void Excluir(int codigo)
        {
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = conexao.ObjetoConexao;
            cmd.CommandText = "delete from Locacoes where (Codigo) = (@Codigo)";
            cmd.Parameters.AddWithValue("@Codigo", codigo);
            conexao.Conectar();
            cmd.ExecuteNonQuery();
            conexao.Desconectar();
        }
        public void Alterar(ModeloLocações obj)
        {
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = conexao.ObjetoConexao;
            cmd.CommandText = "UPDATE Locacoes SET CodigoCliente = (@CodigoCliente), DataCriacao = (@DataCriacao), " +
                "DataRetirada = (@DataRetirada), DataDevolucao = (@DataDevolucao), ValorTotal = (@ValorTotal), " +
                "StatusLocacao = (@StatusLocacao) WHERE Codigo = (@Codigo) ";
            cmd.Parameters.AddWithValue("@CodigoCliente", obj.CodigoCliente);
            cmd.Parameters.AddWithValue("@DataCriacao", obj.DataCriacao);
            cmd.Parameters.AddWithValue("@DataRetirada", obj.DataRetirada);
            cmd.Parameters.AddWithValue("@DataDevolucao", obj.DataDevolucao);
            cmd.Parameters.Add("@ValorTotal", SqlDbType.Decimal).Value = obj.ValorTotal;

            cmd.Parameters.AddWithValue("@StatusLocacao", obj.StatusLocacao);


            cmd.Parameters["@CodigoCliente"].SqlDbType = SqlDbType.Int;
            cmd.Parameters["@DataCriacao"].SqlDbType = SqlDbType.DateTime;
            cmd.Parameters["@DataRetirada"].SqlDbType = SqlDbType.DateTime;
            cmd.Parameters["@DataDevolucao"].SqlDbType = SqlDbType.DateTime;

            cmd.Parameters["@StatusLocacao"].SqlDbType = SqlDbType.Bit;
            cmd.Parameters.AddWithValue("@codigo", obj.Codigo);

            conexao.Conectar();
            cmd.ExecuteNonQuery();
            conexao.Desconectar();
        }

        public ModeloLocações CarregaModeloLocações(int codigo)
        {
            ModeloLocações modelo = new ModeloLocações();
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = conexao.ObjetoConexao;
            cmd.CommandText = "select * from Locacoes where Codigo = @Codigo";
            cmd.Parameters.AddWithValue("@Codigo", codigo);
            conexao.Conectar();
            SqlDataReader registro = cmd.ExecuteReader();
            if (registro.HasRows)
            {
                registro.Read();
                try
                {
                    modelo.Codigo = Convert.ToInt32(registro["Codigo"]);
                    modelo.CodigoCliente = Convert.ToInt32(registro["CodigoCliente"]);
                    modelo.DataCriacao = Convert.ToDateTime(registro["DataCriacao"]);
                    modelo.DataRetirada = Convert.ToDateTime(registro["DataRetirada"]);
                    modelo.DataDevolucao = Convert.ToDateTime(registro["DataDevolucao"]);

                    modelo.ValorTotal = Convert.ToDecimal(registro["ValorTotal"]);

                    modelo.StatusLocacao = Convert.ToBoolean(registro["StatusLocacao"]);



                }
                catch { }

            }
            registro.Close();
            conexao.Desconectar();
            return modelo;
        }
    }
}
