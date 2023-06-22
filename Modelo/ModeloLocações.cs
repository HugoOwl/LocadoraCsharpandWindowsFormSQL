using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Modelo
{
    public class ModeloLocações
    {
        public ModeloLocações()
        {
            this.Codigo = 0;
        }
        public ModeloLocações(int codigo, int codigoCliente, DateTime dataCriacao, DateTime dataRetirada, DateTime dataDevolucao,
      decimal valorTotal, bool statusLocacao)
        {
            Codigo = codigo;
            CodigoCliente = codigoCliente;
            DataCriacao = dataCriacao;
            DataRetirada = dataRetirada;
            DataDevolucao = dataDevolucao;
            ValorTotal = valorTotal;
            StatusLocacao = statusLocacao;
        }


        public int Codigo { get; set; }
        public int CodigoCliente { get; set; }
        public DateTime DataCriacao { get; set; }
        public DateTime DataRetirada { get; set; }
        public DateTime DataDevolucao { get; set; }
        public decimal ValorTotal { get; set; }
        public bool StatusLocacao { get; set; }
    }
}
