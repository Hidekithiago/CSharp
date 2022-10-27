
using MySql.Data.MySqlClient;
using System;
using System.Data;
using System.Data.SqlClient;
using System.Runtime.Remoting.Messaging;

public class _4_bancoDados{
    
    public class FormasPagamento
    {
        private static string connectionString = "Server = 162.241.60.117; Uid = quaest71_treinamento; Pwd =treinamento123; database=quaest71_treinamento";
        public int Id { get; set; }
        public string Nome { get; set; }
        public int Desconto { get; set; }
        public string UserName { get; } //Exercicio 4

        public FormasPagamento(int id, string nome, int desconto, string userName)
        {
            Id = id;
            Nome = nome;
            Desconto = desconto;
            UserName = userName;
        }


        public static void ExecutaQuery(string query)
        {
            using (var conexao = new MySqlConnection(connectionString))
            {
                conexao.Open(); //Libera a conexão
                MySqlCommand cmd = new MySqlCommand(query, conexao); //Executa a query na conexão
                cmd.ExecuteNonQuery();
                conexao.Close(); //Fecha conexão
            }
        }

        public static void ConsultaQuery(string query)
        {
            string test = null;
            using (var conexao = new MySqlConnection(connectionString))
            {
                conexao.Open(); //Libera a conexão
                MySqlCommand cmd = new MySqlCommand(query, conexao); //Executa a query na conexão
                MySqlDataReader reader = cmd.ExecuteReader();
                while (reader.Read()) test = reader.GetString(1);
            }
            Console.WriteLine(test);
        }

        public static DataSet ConsultaQueryArmazena(string query)
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
}

