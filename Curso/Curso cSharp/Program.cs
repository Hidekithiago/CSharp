using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using static Curso_cSharp.ClasseMamiferos;
using static Curso_cSharp.bancoDados;
namespace Curso_cSharp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*
            ClasseMamiferos gato = new ClasseMamiferos("ANIMAL", "GATO", "MIAU", 1);
            gato.Nome = "asd";
            gato.Descricao = "Cachorro";
            Console.WriteLine(gato.Nome);
            */

            string connectString = "Server = 162.241.60.117; Database = quaest71_treinamento; Uid = quaest71_treinamento; Pwd =treinamento123";
            string query = "Insert into presenca(nome, data) values ('Thiago Hideki', now())";
            executaQuery(connectString, query);
            query = "Select * from presenca";
            ConsultaBD(connectString, query);

        }
    }
}
