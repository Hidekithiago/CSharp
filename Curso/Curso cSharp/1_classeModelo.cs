using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace Curso_cSharp
{
    internal class ClasseExemplo
    {
        private String Atributo1;
        private String Atributo2;

        public ClasseExemplo(string atributo1, string atributo2)
        {
            Atributo1 = atributo1;
            Atributo1 = atributo2;
        }

        public static void metodo1() { Console.WriteLine("Hello World"); }
        public static string metodo2() { return "Hello World"; }
    }
}
