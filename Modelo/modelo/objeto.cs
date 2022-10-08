using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace modelo
{
    internal class pessoa
    {
        public int Id { get; set; }
        public string Nome { get; set; } = string.Empty;
        public string Idade { get; set; } = string.Empty;
        public string[] Email { get; set; }
        private float Saldo { get; set; } = 0;

        public pessoa(int id, string nome, string idade, string[] email, float saldo)
        {
            Id = id;
            Nome = nome;
            Idade = idade;
            Email = email;
            Saldo = saldo;
        }

        public static float addSaldo(pessoa pessoa, float valor)
        {
            pessoa.Saldo = pessoa.Saldo + valor;
            Console.WriteLine(pessoa.Saldo);
            return pessoa.Saldo;
        }
    
    }
}
