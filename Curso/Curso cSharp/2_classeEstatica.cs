using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

class NaoEstatica
{
    public int sum(int a, int b)
    {
        return a + b;
    }
}

class Estatica
{   
    public static int sum(int a, int b)
    {
        return a + b;
    }
}

namespace Curso_cSharp
{
    internal class classeEstatica
    {
        /*
        static void Main(string[] args)
        {
            int n = 3, m = 6;
            NaoEstatica g = new NaoEstatica();
            int s = g.sum(n, m);

            var a = Estatica.sum(n, m);
        }
        */
    }
}
