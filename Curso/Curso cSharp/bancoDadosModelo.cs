using System;
using System.Collections.Generic;
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

        public static void ConsultaBD(string connectionString, string query)
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
    }
}
