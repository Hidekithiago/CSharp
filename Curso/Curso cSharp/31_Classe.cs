using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Curso_cSharp
{
    public class Produto4
    {        
        public int Codigo { get; set; }
        public string Nome { get; set; }
        public double Preco { get; set; }
        private double Desconto { get;}

        public Produto4(int codigo, string nome, double preco)
        {
            Codigo = codigo;
            Nome = nome;
            Preco = preco;
            Desconto = 0.75;
        }

        public void AplicaDesconto()
        {
            Preco = Preco * Desconto;
        }
    }

    public class Assinatura4
    {
        public DateTime DataExpiracao { get; set; }
         Produto4 P1 { get; set; }        

        public Assinatura4(Produto4 p1, DateTime dataExpiracao)
        {
            P1 = p1;
            DataExpiracao = dataExpiracao;
        }

        public TimeSpan GetTempoRestante()
        {
            return DataExpiracao - DateTime.Today;
        }

        public TimeSpan AdicionandoBonus()
        {
            return DataExpiracao.AddDays(3) - DateTime.Today;
        }
    }

    public class execucao4
    {        
        /*
        static void Main(string[] args)
        {
            Produto4 p1 = new Produto4(1, "GAMEPASS", 2.90);
            Assinatura4 a1 = new Assinatura4(p1, DateTime.Parse("2022-10-23 00:00:00"));
            var a = a1;
        }
        */
    }
}
