using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Curso_cSharp
{
    public class Produto3
    {        
        public int Codigo { get; set; }
        public string Nome { get; set; }
        public double Preco { get; set; }
        private double Desconto { get;}

        public Produto3(int codigo, string nome, double preco)
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

    public class Assinatura3 : Produto3
    {
        public DateTime DataExpiracao { get; set; }
        Produto3 P1 { get; set; }

        public Assinatura3(int codigo, string nome, double preco, DateTime dataExpiracao) : base(codigo, nome, preco){
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

    public class execucao3
    {
        /*
        static void Main(string[] args)
        {            
            Assinatura3 a1 = new Assinatura3(1, "GAMEPASS", 2.90, DateTime.Parse("2022-11-23 00:00:00"));
            Console.WriteLine($"Codigo {a1.Codigo}\nNome {a1.Nome}\nPreco {a1.Preco}\nDia Expiracao {a1.DataExpiracao}");
            a1.Nome = "PASSEGAME";
            Console.WriteLine($"\n\nCodigo {a1.Codigo}\nNome {a1.Nome}\nPreco {a1.Preco}\nDia Expiracao {a1.DataExpiracao}");
            a1.AplicaDesconto();
            Console.WriteLine($"\n\nCodigo {a1.Codigo}\nNome {a1.Nome}\nPreco {a1.Preco}\nDia Expiracao {a1.DataExpiracao}");
        }
        */
    }
}
