using DAL;
using Modelo;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL
{
    public class BLLLocaçoes
    {
        private DALConexao conexao;
        public BLLLocaçoes(DALConexao cx)
        {
            this.conexao = cx;
        }
        public void Incluir(ModeloLocações obj)
        {
            if (obj.CodigoCliente == 0)
            {
                throw new Exception("O Código do Cliente é obrigatório");
            }

            if (obj.DataCriacao == null)
            {
                throw new Exception("A Data de Criação é obrigatória");
            }

            if (obj.DataRetirada == null)
            {
                throw new Exception("A Data de Retirada é obrigatória");
            }


            if (obj.DataDevolucao == null)
            {
                throw new Exception("A Data de Devolução é obrigatória");
            }

            if (obj.ValorTotal == 0)
            {
                throw new Exception("O Valor Total é obrigatório");
            }

            DALLocações DalLocacoes = new DALLocações(conexao);
            DalLocacoes.Incluir(obj);
            }
        public void Alterar(ModeloLocações obj)
        {
            if (obj.CodigoCliente == 0)
            {
                throw new Exception("O Código do Cliente é obrigatório");
            }

            if (obj.DataCriacao == null)
            {
                throw new Exception("A Data de Criação é obrigatória");
            }

            if (obj.DataRetirada == null)
            {
                throw new Exception("A Data de Retirada é obrigatória");
            }


            if (obj.DataDevolucao == null)
            {
                throw new Exception("A Data de Devolução é obrigatória");
            }

            if (obj.ValorTotal == 0)
            {
                throw new Exception("O Valor Total é obrigatório");
            }

            DALLocações DALobj = new DALLocações(conexao);
            DALobj.Alterar(obj);
        }
        public DataTable Localizar(String valor)
        {
            DALLocações DALobj = new DALLocações(conexao);
            return DALobj.Localizar(valor);
        }
        public void Excluir(int codigo)
        {
            DALLocações DALobj = new DALLocações(conexao);
            DALobj.Excluir(codigo);
        }
        public ModeloLocações CarregaModeloLocações(int codigo)
        {
            DALLocações DALobj = new DALLocações(conexao);
            return DALobj.CarregaModeloLocações(codigo);
        }
    }
}
