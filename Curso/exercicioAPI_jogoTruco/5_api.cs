using System;
using System.Collections;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net;
using System.Security.Policy;
using System.Text;
using System.Text.Json;
using System.Text.Json.Nodes;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

using MySql.Data.MySqlClient; //Instalar o MySQL.Data
using MySqlX.XDevAPI;
using Org.BouncyCastle.Asn1.Crmf;
class _5_api
{
    public class Deck
    {
        public string Id { get; set; }
        public int QuantidadeCartas { get; set; }

        public string Carta1Jogador1 { get; set; }
        public string Carta2Jogador1 { get; set; }
        public string Carta3Jogador1 { get; set; }

        public string Carta1Jogador2 { get; set; }
        public string Carta2Jogador2 { get; set; }
        public string Carta3Jogador2 { get; set; }

        public Deck() { }


        public static void CreateDeck(Deck d1)
        {
            string[] cartasArray = { "4", "5", "6", "7", "Q", "J", "K", "A", "2", "3" };
            string cartas = null;

            for (int i = 0; i < cartasArray.Count(); i++)
            {
                cartas += cartasArray[i] + "S,";
                cartas += cartasArray[i] + "D,";
                cartas += cartasArray[i] + "C,";
                if ((cartasArray.Count() - 1) == i) cartas += cartasArray[i] + "H";
                else cartas += cartasArray[i] + "H,";
            }
            HttpWebRequest request = (HttpWebRequest)WebRequest.Create($"https://deckofcardsapi.com/api/deck/new/shuffle/?cards={cartas}");
            using (StreamReader responseReader = new StreamReader(request.GetResponse().GetResponseStream()))
            {
                string response = responseReader.ReadToEnd();
                //response = response.Replace("\"", "");
                response = response.Replace("{", "[{");
                response = response.Replace("}", "}]");
                try
                {
                    JsonDocument doc = JsonDocument.Parse(response);
                    JsonElement u1 = doc.RootElement[0];
                    string deck_id = u1.GetProperty("deck_id").ToString();
                    int remaining = Int32.Parse(u1.GetProperty("remaining").ToString());
                    d1.QuantidadeCartas = remaining;
                    d1.Id = deck_id;
                }
                catch (Exception a)
                {
                    Console.WriteLine("Erro de leitura do JSON: {0:G}", a);

                }
            }
        }
        public static void DrawCard(Deck d1)
        {
            HttpWebRequest request = (HttpWebRequest)WebRequest.Create($"https://deckofcardsapi.com/api/deck/{d1.Id}/draw/?count=6");
            using (StreamReader responseReader = new StreamReader(request.GetResponse().GetResponseStream()))
            {
                string response = responseReader.ReadToEnd();
                //response = response.Replace("\"", "");
                response = response.Replace("{", "[{");
                response = response.Replace("}", "}]");
                try
                {
                    JsonDocument doc = JsonDocument.Parse(response);
                    JsonElement u1 = doc.RootElement[0];
                    var code = u1.GetProperty("cards");
                    d1.Carta1Jogador1 = code[0][0].GetProperty("value").ToString();
                    d1.Carta1Jogador2 = code[1][0].GetProperty("value").ToString();
                    d1.Carta2Jogador1 = code[2][0].GetProperty("value").ToString();
                    d1.Carta2Jogador2 = code[3][0].GetProperty("value").ToString();
                    d1.Carta3Jogador1 = code[4][0].GetProperty("value").ToString();
                    d1.Carta3Jogador2 = code[5][0].GetProperty("value").ToString();
                }
                catch (Exception a)
                {
                    Console.WriteLine("Erro de leitura do JSON: {0:G}", a);
                }
            }
        }

        public static void ValidaVencedor(Deck d1)
        {
            int resultado = 0;
            resultado = ValidaRodada(d1.Carta1Jogador1, d1.Carta1Jogador2);
            resultado = ValidaRodada(d1.Carta2Jogador1, d1.Carta2Jogador2);
            resultado = ValidaRodada(d1.Carta3Jogador1, d1.Carta3Jogador2);
            if (resultado > 0) Console.WriteLine("Vencedor Jogador 1");
            else if (resultado == 0) Console.WriteLine("Empate");
            else Console.WriteLine("Vencedor Jogador 2");
        }


        public static int ValidaRodada(string j1, string j2)
        {
            string[] cartasArray = { "4", "5", "6", "7", "QUEEN", "JACK", "KING", "A", "2", "3" };
            string objeto = "[";
            for (int i = 0; i < cartasArray.Count(); i++)
            {
                objeto += "{\"Carta\": \"" + cartasArray[i] + "\", \"Valor\": " + i + "},";
            }
            objeto = Regex.Replace(objeto, ",$", "");
            objeto += "]";
            JsonNode json = JsonValue.Parse(objeto);
            int valorCartaJ1 = 0, valorCartaJ2 = 0;
            for (int i = 0; i < cartasArray.Count(); i++)
            {
                if (json[i]["Carta"].ToString() == j1) valorCartaJ1 = Int32.Parse(json[i]["Valor"].ToString());
                if (json[i]["Carta"].ToString() == j2) valorCartaJ2 = Int32.Parse(json[i]["Valor"].ToString());
            }
            if (valorCartaJ1 > valorCartaJ2)
            {
                Console.WriteLine("Vencedor da Rodada: Jogador 1");
                return 1;
            }
            else if (valorCartaJ1 < valorCartaJ2)
            {
                Console.WriteLine("Vencedor da Rodada: Jogador 2");
                return -1;
            }
            else
            {
                Console.WriteLine("EMPATE NA RODADA");
                return 0;
            }
        }
    }
}
