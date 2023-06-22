using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Modelo
{
    public class ModeloLocaçõesLinhas
    {
        public ModeloLocaçõesLinhas()
        {
            this.Codigo = 0;
        }
        public ModeloLocaçõesLinhas(int codigo, int codigoLocacao, int codigoVeiculo)
        {
            Codigo = codigo;
            CodigoLocacao = codigoLocacao;
            CodigoVeiculo = codigoVeiculo;
        }
        public int Codigo { get; set; }
        public int CodigoLocacao { get; set; }
        public int CodigoVeiculo { get; set; }

    }
}
