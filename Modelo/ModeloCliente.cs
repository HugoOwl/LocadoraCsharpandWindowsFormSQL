using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Modelo
{
    public class ModeloCliente
    {
        public ModeloCliente()
        {
            this.Codigo = 0;
            this.Nome = "";
            this.CPF = "";
            this.CNH = "";
            this.DataNascimento = DateTime.MinValue;
            this.CEP = "";
            this.Logradouro = "";
            this.Complemento = "";
            this.Numero = "";
            this.Bairro = "";
            this.Cidade = "";
            this.UF = "";
            this.Foto = null;
            this.RG = "";
            this.CaminhoFoto = "";
        }

        public ModeloCliente(int codigo, string nome, string cpf, string cnh, DateTime dataNascimento,
            string cep, string logradouro, string complemento, string numero, string bairro,
            string cidade, string uf, byte[] foto, string caminhoFoto, string rg)
        {
            this.Codigo = codigo;
            this.Nome = nome;
            this.CPF = cpf;
            this.CNH = cnh;
            this.DataNascimento = dataNascimento;
            this.CEP = cep;
            this.Logradouro = logradouro;
            this.Complemento = complemento;
            this.Numero = numero;
            this.Bairro = bairro;
            this.Cidade = cidade;
            this.UF = uf;
            this.Foto = foto;
            this.CaminhoFoto = caminhoFoto;
            this.RG = rg;
        }

        public int Codigo { get; set; }
        public string Nome { get; set; }
        public string CPF { get; set; }
        public string CNH { get; set; }
        public DateTime DataNascimento { get; set; }
        public string CEP { get; set; }
        public string Logradouro { get; set; }
        public string Complemento { get; set; }
        public string Numero { get; set; }
        public string Bairro { get; set; }
        public string Cidade { get; set; }
        public string UF { get; set; }
        public byte[] Foto { get; set; }
        public string CaminhoFoto { get; set; }
        public string RG { get; set; }
        public void CarregaImagem(string imgCaminho)
        {
            try
            {
                if (string.IsNullOrEmpty(imgCaminho))
                    return;

                // Obter o caminho completo
                string caminhoCompleto = Path.GetFullPath(imgCaminho);

                // Criar uma instância de FileInfo usando o caminho completo
                FileInfo arqImagem = new FileInfo(caminhoCompleto);

                // Abrir o arquivo usando o caminho completo
                FileStream fs = new FileStream(caminhoCompleto, FileMode.Open, FileAccess.Read, FileShare.Read);

                // Alocar memória para o vetor
                this.Foto = new byte[Convert.ToInt32(arqImagem.Length)];

                // Lê um bloco de bytes do fluxo e grava os dados em um buffer fornecido
                int iBytesRead = fs.Read(this.Foto, 0, Convert.ToInt32(arqImagem.Length));
                fs.Close();

                // Atualizar a variável de string "Foto" com o caminho completo
                this.CaminhoFoto = caminhoCompleto;
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message.ToString());
            }
        }
    }
}