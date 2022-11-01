using static _5_api;

namespace CursoCSharp_Exercicio
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //EXERCICIO API
            //https://deckofcardsapi.com/
            Deck d1 = new Deck();
            Deck.CreateDeck(d1);
            Deck.DrawCard(d1);
            Deck.ValidaVencedor(d1);
        //createSheet(@"C:\Users\hidek\OneDrive\Área de Trabalho\GitHub\CSharp\Curso\Cursoexample_workbook.xlsx");
        }
    }
}
