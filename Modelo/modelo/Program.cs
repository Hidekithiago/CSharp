using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace modelo
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string[] email = {"a@hotmail.com", "b@hotmail.com"}; //Array
            pessoa p1 = new pessoa(1, "HIDEKI", "26", email, 0);
            Console.WriteLine(p1.Email[1]);
            pessoa.addSaldo(p1, 25);
            pessoa.addSaldo(p1, 50);
            Thread.Sleep(10000);
        }
    }
}
