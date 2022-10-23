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
    /*  
         *  IP: 162.241.60.117
         *  login: quaest71_treinamento
         *  senha: treinamento123
         *  Banco de Dados: quaest71_treinamento
         */
    internal class API
    {
        public static void ConsultaAPI(string txtCep){
            HttpWebRequest request = (HttpWebRequest)WebRequest.Create("https://viacep.com.br/ws/" + txtCep + "/json/");
            request.AllowAutoRedirect = false;
            HttpWebResponse ChecaServidor = (HttpWebResponse)request.GetResponse();

            if (ChecaServidor.StatusCode != HttpStatusCode.OK)
            {
                Console.WriteLine("Servidor indisponível");
                return; // Sai da rotina
            }

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

                        int cont = 0;

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

        
        static void Main(string[] args)
        {
            ConsultaAPI("09310260");
        }
        
    }
}