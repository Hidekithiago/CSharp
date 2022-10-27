using System;

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

        public static void Metodo1() { Console.WriteLine("Hello World"); }
        public static string Metodo2() { return "Hello World"; }
    }
}
