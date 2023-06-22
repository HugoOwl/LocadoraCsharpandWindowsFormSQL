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
    public class BLLClientes
    {
        private DALConexao conexao;
        public BLLClientes(DALConexao cx)
        {
            this.conexao = cx;
        }
        public void Incluir(ModeloCliente obj)
        {
            if (obj.Nome.Trim().Length == 0)
            {
                throw new Exception("O nome do produto é obrigatório");
            }

            if (obj.CPF.Trim().Length == 0)
            {
                throw new Exception("O CPF é obrigatória");
            }

            if (obj.CNH.Trim().Length == 0)
            {
                throw new Exception("O CNH é obrigatório");
            }

      
            if (obj.CEP.Trim().Length == 0)
            {
                throw new Exception("O CEP é obrigatório");
            }

            if (obj.Logradouro.Trim().Length == 0)
            {
                throw new Exception("O Logadouro é obrigatório");
            }

            if (obj.Complemento.Trim().Length == 0)
            {
                throw new Exception("O Complemento é obrigatório");
            }
            if (obj.Numero.Trim().Length == 0)
            {
                throw new Exception("O Número é obrigatório");
            }
            if (obj.Bairro.Trim().Length == 0)
            {
                throw new Exception("O Bairro é obrigatório");
            }
            if (obj.Cidade.Trim().Length == 0)
            {
                throw new Exception("A Cidade é obrigatória");
            }
            if (obj.UF.Trim().Length == 0)
            {
                throw new Exception("O UF é obrigatório");
            }

            DALClientes DALobj = new DALClientes(conexao);
            DALobj.Incluir(obj);
        }
        public void Excluir(int codigo)
        {
            DALClientes DALobj = new DALClientes(conexao);
            DALobj.Excluir(codigo);
        }
        
        public void Alterar(ModeloCliente obj)
        {
            if (obj.Codigo <= 0)
            {
                throw new Exception("O código do cliente é obrigatório");
            }
            if (obj.Nome.Trim().Length == 0)
            {
                throw new Exception("O nome do produto é obrigatório");
            }

            if (obj.CPF.Trim().Length == 0)
            {
                throw new Exception("O CPF é obrigatória");
            }

            if (obj.CNH.Trim().Length == 0)
            {
                throw new Exception("O CNH é obrigatório");
            }


            if (obj.CEP.Trim().Length == 0)
            {
                throw new Exception("O CEP é obrigatório");
            }

            if (obj.Logradouro.Trim().Length == 0)
            {
                throw new Exception("O Logadouro é obrigatório");
            }

            if (obj.Complemento.Trim().Length == 0)
            {
                throw new Exception("O Complemento é obrigatório");
            }
            if (obj.Numero.Trim().Length == 0)
            {
                throw new Exception("O Número é obrigatório");
            }
            if (obj.Bairro.Trim().Length == 0)
            {
                throw new Exception("O Bairro é obrigatório");
            }
            if (obj.Cidade.Trim().Length == 0)
            {
                throw new Exception("A Cidade é obrigatória");
            }
            if (obj.UF.Trim().Length == 0)
            {
                throw new Exception("O UF é obrigatório");
            }
            DALClientes DALobj = new DALClientes(conexao);
            DALobj.Alterar(obj);
        }
        public DataTable Localizar(String valor)
        {
            DALClientes DALobj = new DALClientes(conexao);
            return DALobj.Localizar(valor);
        }
        public ModeloCliente CarregaModeloCliente(int codigo)
        {
            DALClientes DALobj = new DALClientes(conexao);
            return DALobj.CarregaModeloCliente(codigo);
        }
    
        
    }
}
