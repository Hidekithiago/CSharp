using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Curso_cSharp
{
    internal class ClasseMamiferos
    {
        public String Tipo { get; }
        public String Descricao { get; }
        public String Nome; 
        private int Idade;

        public ClasseMamiferos(string tipo, string descricao, string nome, int idade)
        {
            Tipo = tipo;
            Descricao = descricao;
            Nome = nome;
            Idade = idade;
        }
        
    }
}
