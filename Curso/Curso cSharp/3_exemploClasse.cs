using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Curso_cSharp
{
    public class FamiliaPrincipal
    {        
        public int Codigo { get; set; }
        public string NomeFamilia { get; set; }

        /*
        public FamiliaPrincipal(int codigo, string nomeFamilia)
        {
            Codigo = codigo;
            NomeFamilia = nomeFamilia;
        }
        */

        public string MostraNomeFamilia()
        {            
            return $"O Nome da sua familia e {NomeFamilia}";
        }
    }

    public class Familia : FamiliaPrincipal
    {
        //public Familia(int codigo, string nomeFamilia) : base(codigo, nomeFamilia){}

        public string LocalizacaoFamilia { get; set; }
        
        public string MudaLocalizacaoFamilia(string cidade)
        {
            LocalizacaoFamilia = cidade;
            return $"A familia se mudou para a cidade {cidade}";
        }
    }

    public class Pessoa : Familia
    {
        //public Pessoa(int codigo, string nomeFamilia) : base(codigo, nomeFamilia){}

        public string NomePessoa { get; set; }
        public int Idade { get; set; }
        public string LocalizacaoPessoa { get; set; }

        public string VerificaMaioridade(int idade)
        {
            if (idade > 18) return $"O/A {NomePessoa} e MAIOR de idade";
            else return $"O/A {NomePessoa} e MENOR de idade";
        }
        public string MudaLocalizacaoPessoa(string cidade)
        {
            LocalizacaoPessoa = cidade;
            return $"O/A {NomePessoa} se mudou para a cidade {cidade}";
        }
    }

    public class execucao3
    {
        /*
        static void Main(string[] args)
        {
            Pessoa c1 = new Pessoa();
            c1.Codigo = 1;
            c1.NomeFamilia = "IKEHARA";
            c1.LocalizacaoFamilia = "MAUA";
            c1.LocalizacaoPessoa = "MAUA";
            c1.NomePessoa = "THIAGO";
            c1.Idade = 26;

            c1.MudaLocalizacaoPessoa("SANTO ANDRE");
            c1.MudaLocalizacaoFamilia("SANTO ANDRE");
        }
        */
    }
}
