using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net;
using System.Text;
using System.Text.Json;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

using MySql.Data.MySqlClient; //Instalar o MySQL.Data
using MySqlX.XDevAPI;
using Org.BouncyCastle.Asn1.Crmf;

namespace Curso_cSharp
{
    //  quaestumtreinamento@gmail.com
    //  treinamento@123
    internal class API
    {
        public static void ConsultaAPI(string txtCep){
            HttpWebRequest request = (HttpWebRequest)WebRequest.Create("https://viacep.com.br/ws/" + txtCep + "/json/");
            request.AllowAutoRedirect = true;

            HttpWebResponse ChecaServidor = (HttpWebResponse)request.GetResponse();

            using (Stream webStream = ChecaServidor.GetResponseStream())
            {
                if (webStream != null)
                {
                    using (StreamReader responseReader = new StreamReader(webStream))
                    {
                        string response = responseReader.ReadToEnd();                        
                        //response = response.Replace("\"", "");
                        response = response.Replace("{", "[{");
                        response = response.Replace("}", "}]");
                        String[] substrings = response.Split('\n');
                        try
                        {
                            JsonDocument doc = JsonDocument.Parse(response);
                            JsonElement u1 = doc.RootElement[0];
                            string cep = u1.GetProperty("cep").ToString();
                            string logradouro = u1.GetProperty("logradouro").ToString();
                            string complemento = u1.GetProperty("complemento").ToString();
                            string bairro = u1.GetProperty("bairro").ToString();
                            string localidade = u1.GetProperty("localidade").ToString();
                            string uf = u1.GetProperty("uf").ToString();
                            string ibge = u1.GetProperty("ibge").ToString();
                            string gia = u1.GetProperty("gia").ToString();
                            string ddd = u1.GetProperty("ddd").ToString();
                            string siafi = u1.GetProperty("siafi").ToString();
                        }
                        catch (Exception a)
                        {
                            Console.WriteLine("Erro de leitura do JSON: {0:G}", a);
                            List<string> listNull = null;
                        }
                    }
                }
                
            }
        }
        public static void a()
        {
            // Create a new HttpWebRequest Object to the mentioned URL.
            HttpWebRequest myHttpWebRequest = (HttpWebRequest)WebRequest.Create("https://httpstat.us/302");
            myHttpWebRequest.MaximumAutomaticRedirections = 1;
            myHttpWebRequest.AllowAutoRedirect = false;
            HttpWebResponse myHttpWebResponse = (HttpWebResponse)myHttpWebRequest.GetResponse();

        }
        /*
        //https://deckofcardsapi.com/
        static void Main(string[] args)
        {
            //a();
            ConsultaAPI("04533-085");
        }
        */
    }
}