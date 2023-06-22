using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Modelo;
namespace DAL
{
    public class DALFabricante
    {
        private DALConexao conexao;
        public DALFabricante(DALConexao cx)
        {
            this.conexao = cx;
        }
        public void Incluir(ModeloFabricante modelo)
        {
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = conexao.ObjetoConexao;
            cmd.CommandText = "insert into Fabricantes(Nome) values (@Nome); select @@IDENTITY;";
            cmd.Parameters.AddWithValue("@Nome", modelo.Nome);
            conexao.Conectar();
            modelo.Codigo = Convert.ToInt32(cmd.ExecuteScalar());
            conexao.Desconectar();
        }
        public void Alterar(ModeloFabricante modelo)
        {
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = conexao.ObjetoConexao;
            cmd.CommandText = "update Fabricantes set Nome = @Nome where Codigo = @Codigo;";
            cmd.Parameters.AddWithValue("@Nome", modelo.Nome);
            cmd.Parameters.AddWithValue("@Codigo", modelo.Codigo);
            conexao.Conectar();
            cmd.ExecuteNonQuery();
            conexao.Desconectar();
        }
        public DataTable Localizar(String valor)
        {

            SqlDataAdapter da = new SqlDataAdapter("SELECT Codigo, Nome FROM Fabricantes where Nome like '%" + valor + "%'", conexao.StringConexao);

            DataTable tabela = new DataTable();
            da.Fill(tabela);
            return tabela;
        }
        public ModeloFabricante CarregaModeloFabricante(int codigo)
        {
            ModeloFabricante modelo = new ModeloFabricante();
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = conexao.ObjetoConexao;
            cmd.CommandText = "select * from Fabricantes where Codigo = @Codigo";
            cmd.Parameters.AddWithValue("@Codigo", codigo);
            conexao.Conectar();
            SqlDataReader registro = cmd.ExecuteReader();
            if (registro.HasRows)
            {
                registro.Read();
                try
                {
                    modelo.Codigo = Convert.ToInt32(registro["Codigo"]);

                }
                catch { }
                try
                {
                    modelo.Nome = Convert.ToString(registro["Nome"]);

                }
                catch { }
            }
            registro.Close();
            conexao.Desconectar();
            return modelo;
        }
    }
}
