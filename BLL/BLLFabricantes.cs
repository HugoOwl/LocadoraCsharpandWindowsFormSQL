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
    public class BLLFabricantes
    {
        private DALConexao conexao;
        public BLLFabricantes(DALConexao cx)
        {
            this.conexao = cx;
        }
        public void Alterar(ModeloFabricante modelo)
        {
            if (modelo.Codigo <= 0)
            {
                throw new Exception("O código do Fabricante é obrigatório");
            }
            if (modelo.Nome.Trim().Length == 0)
            {
                throw new Exception("O nome do Fabricante é obrigatório");
            }
            //modelo.CatNome = modelo.CatNome.ToUpper();

            DALFabricante DALobj = new DALFabricante(conexao);
            DALobj.Alterar(modelo);
        }
            public void Incluir(ModeloFabricante modelo)
        {
            if (modelo.Nome.Trim().Length == 0)
            {
                throw new Exception("O nome do Fabricante é obrigatório");
            }
            //modelo.CatNome = modelo.CatNome.ToUpper();

            DALFabricante DALobj = new DALFabricante(conexao);
            DALobj.Incluir(modelo);
        }
        public DataTable Localizar(String valor)
        {
            DALFabricante DALobj = new DALFabricante(conexao);
            return DALobj.Localizar(valor);
        }
        public ModeloFabricante CarregaModeloFabricante(int codigo)
        {
            DALFabricante DALobj = new DALFabricante(conexao);
            return DALobj.CarregaModeloFabricante(codigo);
        }
    }
}
