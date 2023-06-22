using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Modelo
{
    public class ModeloVeiculos
    {
        public ModeloVeiculos()
        {
            Codigo = 0;
            Modelo = "";
            Ano = 0;
            CodFabricante = 0;
            Chassi = "";
            Cor = "";
            TipoTransmissao = "";
            Renavan = "";
            ValorDiaria = 0;
            TipoVeiculo = "";
            Placa = "";
            Imagem = null;
            CaminhoImagem = "";
        }
        public ModeloVeiculos(int codigo, string modelo, int ano, int codFabricante, string chassi, string cor, string tipoTransmissao, string renavan, byte[] imagem, string caminhoImagem, decimal valorDiaria, string tipoVeiculo, string placa)
        {
            Codigo = codigo;
            Modelo = modelo;
            Ano = ano;
            CodFabricante = codFabricante;
            Chassi = chassi;
            Cor = cor;
            TipoTransmissao = tipoTransmissao;
            Renavan = renavan;
            ValorDiaria = valorDiaria;
            TipoVeiculo = tipoVeiculo;
            Placa = placa;
            Imagem = imagem;
            CaminhoImagem = caminhoImagem;
        }

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
                    this.Imagem = new byte[Convert.ToInt32(arqImagem.Length)];

                    // Lê um bloco de bytes do fluxo e grava os dados em um buffer fornecido
                    int iBytesRead = fs.Read(this.Imagem, 0, Convert.ToInt32(arqImagem.Length));
                    fs.Close();

                    // Atualizar a variável de string "Foto" com o caminho completo
                    this.CaminhoImagem = caminhoCompleto;
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message.ToString());
            }
        }
            
        public int Codigo { get; set; }
        public string Modelo { get; set; }
        public int Ano { get; set; }
        public int CodFabricante { get; set; }
        public string Chassi { get; set; }
        public string Cor { get; set; }
        public string TipoTransmissao { get; set; }
        public string Renavan { get; set; }
        public byte[] Imagem { get; set; }
        public string CaminhoImagem { get; set; }
        public decimal ValorDiaria { get; set; }
        public string TipoVeiculo { get; set; }
        public string Placa { get; set; }
    }
}
