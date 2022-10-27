using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using MySql.Data.MySqlClient; //Instalar o MySQL.Data
using MySqlX.XDevAPI;

namespace Curso_cSharp
{    
    internal class bancoDadosModelo
    {
        public static void executaQuery(string connectionString, string query)
        {
            using (var conexao = new MySqlConnection(connectionString))
            {
                conexao.Open(); //Libera a conexão
                MySqlCommand cmd = new MySqlCommand(query, conexao); //Executa a query na conexão
                cmd.ExecuteNonQuery();
                conexao.Close(); //Fecha conexão
            }

        }

        public static void consultaQuery(string connectionString, string query)
        {
            using (var conexao = new MySqlConnection(connectionString))
            {
                conexao.Open(); //Libera a conexão
                MySqlCommand cmd = new MySqlCommand(query, conexao); //Executa a query na conexão
                MySqlDataReader reader = cmd.ExecuteReader();
                while (reader.Read()) //Cria uma recorrencia para os dados encontrados(Semelhante ao "FOR EACH")
                {
                    Console.WriteLine($"{reader[0]};{reader[1]};{reader[2]}"); //Mostra o resultado
                }
                conexao.Close(); //Fecha conexão
            }
        }
        public static DataSet consultaQueryArmazena(string connectionString, string query)
        {
            using (var conexao = new MySqlConnection(connectionString))
            {
                DataSet ds = new DataSet();
                MySqlCommand mycommand = new MySqlCommand(query, conexao);
                using (MySqlDataAdapter adapter = new MySqlDataAdapter(mycommand))
                {
                    adapter.Fill(ds);
                }
                return ds;
            }
        }
    }
    public class execucao4
    {
        /*  
         *  https://www.connectionstrings.com/mysql/
         *  IP: 162.241.60.117
         *  login: quaest71_treinamento
         *  senha: treinamento123
         *  Banco de Dados: quaest71_treinamento
         */

        /*
         *  Toda vez que finaliza uma conexao o reader e zerado
         */


        /*
        static void Main(string[] args)
        {            
            Aprivate static string connectionString = "Server = 162.241.60.117; Uid = quaest71_treinamento; Pwd =treinamento123; database=quaest71_treinamento";
        }
        */
    }
}
