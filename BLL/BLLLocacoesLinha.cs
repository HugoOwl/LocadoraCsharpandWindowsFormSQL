using DAL;
using Modelo;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL
{
    public class BLLLocacoesLinha
    {
        private DALConexao conexao;
        public BLLLocacoesLinha(DALConexao cx)
        {
            this.conexao = cx;
        }
        public void Alterar(ModeloLocaçõesLinhas modelo)
        {
            if (modelo.Codigo <= 0)
            {
                throw new Exception("O Código é obrigatório");
            }
            if (modelo.CodigoLocacao == 0)
            {
                throw new Exception("O Código de Fabricante é obrigatório");
            }
            if (modelo.CodigoVeiculo == 0)
            {
                throw new Exception("O código do Veículo é obrigatório");
            }
            //modelo.CatNome = modelo.CatNome.ToUpper();

            DALLocacoesLinha DALobj = new DALLocacoesLinha(conexao);
            DALobj.Alterar(modelo);
        }
        public void Incluir(ModeloLocaçõesLinhas modelo)
        {
       
            if (modelo.CodigoLocacao == 0)
            {
                throw new Exception("O Código de Fabricante é obrigatório");
            }
            if (modelo.CodigoVeiculo == 0)
            {
                throw new Exception("O código do Veículo é obrigatório");
            }
            //modelo.CatNome = modelo.CatNome.ToUpper();

            DALLocacoesLinha DALobj = new DALLocacoesLinha(conexao);
            DALobj.Incluir(modelo);
        }
        public ModeloLocaçõesLinhas CarregaModeloLocaçõesLinhas(int codigo)
        {
            DALLocacoesLinha DALobj = new DALLocacoesLinha(conexao);
            return DALobj.CarregaModeloLocaçõesLinhas(codigo);
        }
    }
}
