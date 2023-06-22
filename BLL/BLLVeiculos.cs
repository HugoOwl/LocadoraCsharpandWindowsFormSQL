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
    public class BLLVeiculos
    {
        private DALConexao conexao;
        public BLLVeiculos(DALConexao cx)
        {
            this.conexao = cx;
        }
        public void Incluir(ModeloVeiculos obj)
        {
            if (obj.Modelo.Trim().Length == 0)
            {
                throw new Exception("O nome do Modelo é obrigatório");
            }

            if (obj.Ano == 0)
            {
                throw new Exception("O Ano é obrigatória");
            }

            if (obj.CodFabricante == 0)
            {
                throw new Exception("O Codigo de Fabricante é obrigatório");
            }


            if (obj.Chassi.Trim().Length == 0)
            {
                throw new Exception("O Chassi é obrigatório");
            }

            if (obj.Cor.Trim().Length == 0)
            {
                throw new Exception("A cor é obrigatória");
            }

            if (obj.TipoTransmissao.Trim().Length == 0)
            {
                throw new Exception("O Tipo de Transmissão é obrigatório");
            }
            if (obj.Renavan.Trim().Length == 0)
            {
                throw new Exception("O Renavan é obrigatório");
            }
            if (obj.ValorDiaria == 0)
            {
                throw new Exception("O Valor da Diária é obrigatório");
            }
            if (obj.TipoVeiculo.Trim().Length == 0)
            {
                throw new Exception("O Tipo de Veiculo é obrigatória");
            }
            if (obj.Placa.Trim().Length == 0)
            {
                throw new Exception("A placa é obrigatória");
            }

            DALVeiculos dALVeiculos = new DALVeiculos(conexao);
            dALVeiculos.Incluir(obj);
        }
        public void Alterar(ModeloVeiculos obj)
        {
            if (obj.Modelo.Trim().Length == 0)
            {
                throw new Exception("O nome do Modelo é obrigatório");
            }

            if (obj.Ano == 0)
            {
                throw new Exception("O Ano é obrigatória");
            }

            if (obj.CodFabricante == 0)
            {
                throw new Exception("O Codigo de Fabricante é obrigatório");
            }


            if (obj.Chassi.Trim().Length == 0)
            {
                throw new Exception("O Chassi é obrigatório");
            }

            if (obj.Cor.Trim().Length == 0)
            {
                throw new Exception("A cor é obrigatória");
            }

            if (obj.TipoTransmissao.Trim().Length == 0)
            {
                throw new Exception("O Tipo de Transmissão é obrigatório");
            }
            if (obj.Renavan.Trim().Length == 0)
            {
                throw new Exception("O Renavan é obrigatório");
            }
            if (obj.ValorDiaria == 0)
            {
                throw new Exception("O Valor da Diária é obrigatório");
            }
            if (obj.TipoVeiculo.Trim().Length == 0)
            {
                throw new Exception("O Tipo de Veiculo é obrigatória");
            }
            if (obj.Placa.Trim().Length == 0)
            {
                throw new Exception("A placa é obrigatória");
            }

            DALVeiculos dALVeiculos = new DALVeiculos(conexao);
            dALVeiculos.Alterar(obj);
        }
        public void Excluir(int codigo)
        {
            DALVeiculos DALobj = new DALVeiculos(conexao);
            DALobj.Excluir(codigo);
        }
        public DataTable Localizar(String valor)
        {
            DALVeiculos DALobj = new DALVeiculos(conexao);
            return DALobj.Localizar(valor);
        }
        public ModeloVeiculos CarregaModeloVeiculos(int codigo)
        {
            DALVeiculos DALobj = new DALVeiculos(conexao);
            return DALobj.CarregaModeloVeiculos(codigo);
        }
    }
}
