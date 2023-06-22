using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Modelo
{
    public class ModeloFabricante
    {
        public ModeloFabricante()
        { 
          this.Codigo = 0;
          this.Nome = "";
        }
        public ModeloFabricante(int codigo, string nome) 
        {
        this.Codigo = codigo;
        this.Nome = nome;
        }
        public int Codigo { get; set; }
        public string Nome { get; set; }
    }
}