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
    public class DALVeiculos
    {
        private DALConexao conexao;
        public DALVeiculos(DALConexao cx)
        {
            this.conexao = cx;
        }
        public void Incluir(ModeloVeiculos obj)
        {
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = conexao.ObjetoConexao;
            cmd.CommandText = "insert into Veiculos (Modelo, Ano, CodFabricante, Chassi, Cor, TipoTransmissao, Renavan, Imagem, CaminhoImagem, ValorDiaria, TipoVeiculo, Placa) " +
            "values (@Modelo,@Ano,@CodFabricante,@Chassi,@Cor,@TipoTransmissao,@Renavan,@Imagem,@CaminhoImagem,@ValorDiaria,@TipoVeiculo,@Placa); select @@IDENTITY;";
            // int pro_cod, String pro_nome, int pro_cpf,
            //  Byte[] pro_caminhofoto, int pro_cnh, int pro_datanascimento, int pro_cep,
            //   String pro_logradouro, String pro_complemento, int pro_numero, String pro_bairro, String pro_cidade, String pro_uf, String pro_foto)
            cmd.Parameters.AddWithValue("@Modelo", obj.Modelo);
            cmd.Parameters.AddWithValue("@Ano", obj.Ano);
            cmd.Parameters.AddWithValue("@CodFabricante", obj.CodFabricante);
            cmd.Parameters.AddWithValue("@Chassi", obj.Chassi);
            cmd.Parameters.AddWithValue("@Cor", obj.Cor);
            cmd.Parameters.AddWithValue("@TipoTransmissao", obj.TipoTransmissao);
            cmd.Parameters.AddWithValue("@Renavan", obj.Renavan);
            cmd.Parameters.AddWithValue("@Imagem", obj.Imagem);
            cmd.Parameters.AddWithValue("@CaminhoImagem", obj.CaminhoImagem);
            cmd.Parameters.Add("@ValorDiaria", SqlDbType.Decimal).Value = obj.ValorDiaria;

            cmd.Parameters.AddWithValue("@TipoVeiculo", obj.TipoVeiculo);
            cmd.Parameters.AddWithValue("@Placa", obj.Placa);

            cmd.Parameters["@Modelo"].SqlDbType = SqlDbType.VarChar;
            cmd.Parameters["@Modelo"].Size = 250;
            cmd.Parameters["@Ano"].SqlDbType = SqlDbType.Int;
            cmd.Parameters["@CodFabricante"].SqlDbType = SqlDbType.Int;
            cmd.Parameters["@Chassi"].SqlDbType = SqlDbType.VarChar;
            cmd.Parameters["@Chassi"].Size = 150;

            cmd.Parameters["@Cor"].SqlDbType = SqlDbType.VarChar;
            cmd.Parameters["@Cor"].Size = 100;
            cmd.Parameters["@TipoTransmissao"].SqlDbType = SqlDbType.VarChar;
            cmd.Parameters["@TipoTransmissao"].Size = 50;
            cmd.Parameters["@Renavan"].SqlDbType = SqlDbType.VarChar;
            cmd.Parameters["@Renavan"].Size = 100;
            cmd.Parameters["@Imagem"].SqlDbType = SqlDbType.VarBinary;
            cmd.Parameters["@Imagem"].Size = -1;
            cmd.Parameters["@CaminhoImagem"].SqlDbType = SqlDbType.VarChar;
            cmd.Parameters["@CaminhoImagem"].Size = 500;
            cmd.Parameters["@ValorDiaria"].Scale = 2;
            cmd.Parameters["@TipoVeiculo"].SqlDbType = SqlDbType.VarChar;
            cmd.Parameters["@TipoVeiculo"].Size = 30;
            cmd.Parameters["@Placa"].SqlDbType = SqlDbType.VarChar;
            cmd.Parameters["@Placa"].Size = 15;

            conexao.Conectar();
            obj.Codigo = Convert.ToInt32(cmd.ExecuteScalar());
            conexao.Desconectar();
        }
        public void Alterar(ModeloVeiculos obj)
        {
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = conexao.ObjetoConexao;
            cmd.CommandText = "UPDATE Locacoes SET Modelo = (@Modelo), Ano = (@Ano), " +
                "CodFabricante = (@CodFabricante), Chassi = (@Chassi), Cor = (@Cor), " +
                "TipoTransmissao = (@TipoTransmissao), Renavan = (@Renavan), Imagem = (@Imagem), CaminhoImagem = (@CaminhoImagem), ValorDiaria = (@ValorDiaria), TipoVeiculo = (@TipoVeiculo), Placa = (@Placa) WHERE Codigo = (@Codigo) ";
            cmd.Parameters.AddWithValue("@Modelo", obj.Modelo);
            cmd.Parameters.AddWithValue("@Ano", obj.Ano);
            cmd.Parameters.AddWithValue("@CodFabricante", obj.CodFabricante);
            cmd.Parameters.AddWithValue("@Chassi", obj.Chassi);
            cmd.Parameters.AddWithValue("@Cor", obj.Cor);
            cmd.Parameters.AddWithValue("@TipoTransmissao", obj.TipoTransmissao);
            cmd.Parameters.AddWithValue("@Renavan", obj.Renavan);
            cmd.Parameters.AddWithValue("@Imagem", obj.Imagem);
            cmd.Parameters.AddWithValue("@CaminhoImagem", obj.CaminhoImagem);
            cmd.Parameters.Add("@ValorDiaria", SqlDbType.Decimal).Value = obj.ValorDiaria;

            cmd.Parameters.AddWithValue("@TipoVeiculo", obj.TipoVeiculo);
            cmd.Parameters.AddWithValue("@Placa", obj.Placa);

            cmd.Parameters["@Modelo"].SqlDbType = SqlDbType.VarChar;
            cmd.Parameters["@Modelo"].Size = 250;
            cmd.Parameters["@Ano"].SqlDbType = SqlDbType.Int;
            cmd.Parameters["@CodFabricante"].SqlDbType = SqlDbType.Int;
            cmd.Parameters["@Chassi"].SqlDbType = SqlDbType.VarChar;
            cmd.Parameters["@Chassi"].Size = 150;

            cmd.Parameters["@Cor"].SqlDbType = SqlDbType.VarChar;
            cmd.Parameters["@Cor"].Size = 100;
            cmd.Parameters["@TipoTransmissao"].SqlDbType = SqlDbType.VarChar;
            cmd.Parameters["@TipoTransmissao"].Size = 50;
            cmd.Parameters["@Renavan"].SqlDbType = SqlDbType.VarChar;
            cmd.Parameters["@Renavan"].Size = 100;
            cmd.Parameters["@Imagem"].SqlDbType = SqlDbType.VarBinary;
            cmd.Parameters["@Imagem"].Size = -1;
            cmd.Parameters["@CaminhoImagem"].SqlDbType = SqlDbType.VarChar;
            cmd.Parameters["@CaminhoImagem"].Size = 500;
            cmd.Parameters["@ValorDiaria"].Scale = 2;
            cmd.Parameters["@TipoVeiculo"].SqlDbType = SqlDbType.VarChar;
            cmd.Parameters["@TipoVeiculo"].Size = 30;
            cmd.Parameters["@Placa"].SqlDbType = SqlDbType.VarChar;
            cmd.Parameters["@Placa"].Size = 15;
            cmd.Parameters.AddWithValue("@codigo", obj.Codigo);

            conexao.Conectar();
            cmd.ExecuteNonQuery();
            conexao.Desconectar();
        }
        public void Excluir(int codigo)
        {
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = conexao.ObjetoConexao;
            cmd.CommandText = "delete from Veiculos where (Codigo) = (@Codigo)";
            cmd.Parameters.AddWithValue("@Codigo", codigo);
            conexao.Conectar();
            cmd.ExecuteNonQuery();
            conexao.Desconectar();
        }
        public DataTable Localizar(String valor)
        {

            SqlDataAdapter da = new SqlDataAdapter("SELECT Codigo, Modelo, Ano, CodFabricante, Chassi, Cor, TipoTransmissao, Renavan, Imagem, CaminhoImagem, ValorDiaria, TipoVeiculo, Placa FROM Veiculos where Modelo like '%" + valor + "%'", conexao.StringConexao);

            DataTable tabela = new DataTable();
            da.Fill(tabela);
            return tabela;
        }

        public ModeloVeiculos CarregaModeloVeiculos(int codigo)
        {
            ModeloVeiculos modelo = new ModeloVeiculos();
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = conexao.ObjetoConexao;
            cmd.CommandText = "select * from Veiculos where Codigo = @Codigo";
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
                    modelo.Modelo = Convert.ToString(registro["Modelo"]);
                }
                catch { }

                try
                {
                    modelo.Ano = Convert.ToInt32(registro["Ano"]);
                }
                catch { }

                try
                {
                    modelo.CodFabricante = Convert.ToInt32(registro["CodFabricante"]);
                }
                catch { }

                try
                {
                    modelo.Chassi = Convert.ToString(registro["Chassi"]);
                }
                catch { }

                try
                {
                    modelo.Cor = Convert.ToString(registro["Cor"]);
                }
                catch { }

                try
                {
                    modelo.TipoTransmissao = Convert.ToString(registro["TipoTransmissao"]);
                }
                catch { }

                try
                {
                    modelo.Renavan = Convert.ToString(registro["Renavan"]);
                }
                catch { }

                try
                {
                    modelo.ValorDiaria = Convert.ToDecimal(registro["ValorDiaria"]);
                }
                catch { }

                try
                {
                    modelo.TipoVeiculo = Convert.ToString(registro["TipoVeiculo"]);
                }
                catch { }

                try
                {
                    modelo.Placa = Convert.ToString(registro["Placa"]);
                }
                catch { }

                try
                {
                    modelo.Imagem = registro["Imagem"] as byte[];
                }
                catch { }

                try
                {
                    modelo.CaminhoImagem = Convert.ToString(registro["CaminhoImagem"]);
                }
                catch { }
            }




        
            registro.Close();
            conexao.Desconectar();
            return modelo;
        }
    }
}
