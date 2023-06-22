using Modelo;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    public class DALClientes
    {
        private DALConexao conexao;
        public DALClientes(DALConexao cx)
        {
            this.conexao = cx;
        }
        public void Incluir(ModeloCliente obj)
        {
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = conexao.ObjetoConexao;
            cmd.CommandText = "insert into Clientes (Nome, CPF, CNH, DataNascimento, CEP, Logradouro, Complemento, Numero, Bairro, Cidade, UF, Foto, CaminhoFoto, RG) " +
            "values (@Nome,@CPF,@CNH,@DataNascimento,@CEP,@Logradouro,@Complemento,@Numero,@Bairro,@Cidade,@UF,@Foto,@CaminhoFoto,@RG); select @@IDENTITY;";
            // int pro_cod, String pro_nome, int pro_cpf,
            //  Byte[] pro_caminhofoto, int pro_cnh, int pro_datanascimento, int pro_cep,
            //   String pro_logradouro, String pro_complemento, int pro_numero, String pro_bairro, String pro_cidade, String pro_uf, String pro_foto)
            cmd.Parameters.AddWithValue("@Nome", obj.Nome);
            cmd.Parameters.AddWithValue("@CPF", obj.CPF);
            cmd.Parameters.AddWithValue("@CNH", obj.CNH);
            cmd.Parameters.AddWithValue("@DataNascimento", obj.DataNascimento);
            cmd.Parameters.AddWithValue("@CEP", obj.CEP);
            cmd.Parameters.AddWithValue("@Logradouro", obj.Logradouro);
            cmd.Parameters.AddWithValue("@Complemento", obj.Complemento);
            cmd.Parameters.AddWithValue("@Numero", obj.Numero);
            cmd.Parameters.AddWithValue("@Bairro", obj.Bairro);
            cmd.Parameters.AddWithValue("@Cidade", obj.Cidade);
            cmd.Parameters.AddWithValue("@UF", obj.UF);
            cmd.Parameters.AddWithValue("@Foto", obj.Foto);
            cmd.Parameters.AddWithValue("@CaminhoFoto", obj.CaminhoFoto);

            cmd.Parameters.AddWithValue("@RG", obj.RG);
            cmd.Parameters["@Nome"].SqlDbType = SqlDbType.VarChar;
            cmd.Parameters["@Nome"].Size = 500;
            cmd.Parameters["@CPF"].SqlDbType = SqlDbType.VarChar;
            cmd.Parameters["@CPF"].Size = 11;
            cmd.Parameters["@CNH"].SqlDbType = SqlDbType.VarChar;
            cmd.Parameters["@CNH"].Size = 50;
            cmd.Parameters["@DataNascimento"].SqlDbType = SqlDbType.Date;
            cmd.Parameters["@CEP"].SqlDbType = SqlDbType.VarChar;
            cmd.Parameters["@CEP"].Size = 8;
            cmd.Parameters["@Logradouro"].SqlDbType = SqlDbType.VarChar;
            cmd.Parameters["@Logradouro"].Size = 500;
            cmd.Parameters["@Complemento"].SqlDbType = SqlDbType.VarChar;
            cmd.Parameters["@Complemento"].Size = 250;
            cmd.Parameters["@Numero"].SqlDbType = SqlDbType.VarChar;
            cmd.Parameters["@Numero"].Size = 30;
            cmd.Parameters["@Bairro"].SqlDbType = SqlDbType.VarChar;
            cmd.Parameters["@Bairro"].Size = 150;
            cmd.Parameters["@Cidade"].SqlDbType = SqlDbType.VarChar;
            cmd.Parameters["@Cidade"].Size = 150;
            cmd.Parameters["@UF"].SqlDbType = SqlDbType.VarChar;
            cmd.Parameters["@UF"].Size = 2;
            cmd.Parameters["@Foto"].SqlDbType = SqlDbType.VarBinary;
            cmd.Parameters["@Foto"].Size = -1;
            cmd.Parameters["@CaminhoFoto"].SqlDbType = SqlDbType.VarChar;
            cmd.Parameters["@CaminhoFoto"].Size = 1000;
            cmd.Parameters["@RG"].SqlDbType = SqlDbType.NVarChar;
            cmd.Parameters["@RG"].Size = 12;
            
            conexao.Conectar();
            obj.Codigo = Convert.ToInt32(cmd.ExecuteScalar());
            conexao.Desconectar();
        }
        public void Excluir(int codigo)
        {
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = conexao.ObjetoConexao;
            cmd.CommandText = "delete from Clientes where (Codigo) = (@Codigo)";
            cmd.Parameters.AddWithValue("@Codigo", codigo);
            conexao.Conectar();
            cmd.ExecuteNonQuery();
            conexao.Desconectar();
        }
        
        public void Alterar(ModeloCliente obj)
        {
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = conexao.ObjetoConexao;
            cmd.CommandText = "UPDATE Clientes SET Nome = (@Nome), CPF = (@CPF), " +
                "CNH = (@CNH), DataNascimento = (@DataNascimento), CEP = (@CEP), " +
                "Logradouro = (@Logradouro), Complemento = (@Complemento), Numero = (@Numero), " +
                "Bairro = (@Bairro), UF = (@UF), Foto = (@Foto), CaminhoFoto = (@CaminhoFoto), RG = (@RG) WHERE Codigo = (@Codigo) ";
            cmd.Parameters.AddWithValue("@Nome", obj.Nome);
            cmd.Parameters.AddWithValue("@CPF", obj.CPF);
            cmd.Parameters.AddWithValue("@CNH", obj.CNH);
            cmd.Parameters.AddWithValue("@DataNascimento", obj.DataNascimento);
            cmd.Parameters.AddWithValue("@CEP", obj.CEP);
            cmd.Parameters.AddWithValue("@Logradouro", obj.Logradouro);
            cmd.Parameters.AddWithValue("@Complemento", obj.Complemento);
            cmd.Parameters.AddWithValue("@Numero", obj.Numero);
            cmd.Parameters.AddWithValue("@Bairro", obj.Bairro);
            cmd.Parameters.AddWithValue("@Cidade", obj.Cidade);
            cmd.Parameters.AddWithValue("@UF", obj.UF);
            cmd.Parameters.AddWithValue("@Foto", obj.Foto);
            cmd.Parameters.AddWithValue("@CaminhoFoto", obj.CaminhoFoto);

            cmd.Parameters.AddWithValue("@RG", obj.RG);
            cmd.Parameters["@Nome"].SqlDbType = SqlDbType.VarChar;
            cmd.Parameters["@Nome"].Size = 500;
            cmd.Parameters["@CPF"].SqlDbType = SqlDbType.VarChar;
            cmd.Parameters["@CPF"].Size = 11;
            cmd.Parameters["@CNH"].SqlDbType = SqlDbType.VarChar;
            cmd.Parameters["@CNH"].Size = 50;
            cmd.Parameters["@DataNascimento"].SqlDbType = SqlDbType.Date;
            cmd.Parameters["@CEP"].SqlDbType = SqlDbType.VarChar;
            cmd.Parameters["@CEP"].Size = 8;
            cmd.Parameters["@Logradouro"].SqlDbType = SqlDbType.VarChar;
            cmd.Parameters["@Logradouro"].Size = 500;
            cmd.Parameters["@Complemento"].SqlDbType = SqlDbType.VarChar;
            cmd.Parameters["@Complemento"].Size = 250;
            cmd.Parameters["@Numero"].SqlDbType = SqlDbType.VarChar;
            cmd.Parameters["@Numero"].Size = 30;
            cmd.Parameters["@Bairro"].SqlDbType = SqlDbType.VarChar;
            cmd.Parameters["@Bairro"].Size = 150;
            cmd.Parameters["@Cidade"].SqlDbType = SqlDbType.VarChar;
            cmd.Parameters["@Cidade"].Size = 150;
            cmd.Parameters["@UF"].SqlDbType = SqlDbType.VarChar;
            cmd.Parameters["@UF"].Size = 2;
            cmd.Parameters["@Foto"].SqlDbType = SqlDbType.VarBinary;
            cmd.Parameters["@Foto"].Size = -1;
            cmd.Parameters["@CaminhoFoto"].SqlDbType = SqlDbType.VarChar;
            cmd.Parameters["@CaminhoFoto"].Size = 1000;
            cmd.Parameters["@RG"].SqlDbType = SqlDbType.NVarChar;
            cmd.Parameters["@RG"].Size = 12;
            cmd.Parameters.AddWithValue("@codigo", obj.Codigo);

            conexao.Conectar();
            cmd.ExecuteNonQuery();
            conexao.Desconectar();
        }

     
        public DataTable Localizar(String valor)
        {
            SqlCommand cmd = new SqlCommand();

            SqlDataAdapter da = new SqlDataAdapter("SELECT Codigo, Nome, CPF, CNH, DataNascimento, CEP, Logradouro, Complemento, Numero, Bairro, Cidade, UF, Foto, CaminhoFoto, RG FROM Clientes where Nome like '%" + valor + "%'", conexao.StringConexao);

            DataTable tabela = new DataTable();
            da.Fill(tabela);
            return tabela;
        }
        
        public ModeloCliente CarregaModeloCliente(int codigo)
        {
            ModeloCliente modelo = new ModeloCliente();
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = conexao.ObjetoConexao;
            cmd.CommandText = "select * from Clientes where Codigo =" + codigo.ToString();
            conexao.Conectar();
            SqlDataReader registro = cmd.ExecuteReader();
            if (registro.HasRows)
            {
                registro.Read();
                modelo.Codigo = Convert.ToInt32(registro["Codigo"]);
                modelo.Nome = Convert.ToString(registro["Nome"]);
                modelo.CPF = Convert.ToString(registro["CPF"]);
                modelo.CNH = Convert.ToString(registro["CNH"]);
                modelo.DataNascimento = Convert.ToDateTime(registro["DataNascimento"]);

                modelo.CEP = Convert.ToString(registro["CEP"]);

                modelo.Logradouro = Convert.ToString(registro["Logradouro"]);

                modelo.Complemento = Convert.ToString(registro["Complemento"]);
                modelo.Numero = Convert.ToString(registro["Numero"]);

                modelo.Bairro = Convert.ToString(registro["Bairro"]);

                modelo.Cidade = Convert.ToString(registro["Cidade"]);

                modelo.UF = Convert.ToString(registro["UF"]);
                try
                {
                    modelo.Foto = (byte[])registro["Foto"];

                }
                catch { }
                modelo.CaminhoFoto = Convert.ToString(registro["CaminhoFoto"]);


             
                modelo.RG = Convert.ToString(registro["RG"]);


            }
            conexao.Desconectar();
            return modelo;
        }
        
      

    }
}