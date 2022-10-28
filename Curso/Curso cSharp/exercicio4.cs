using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Curso_cSharp
{
    internal class Class1
    {
        private static string connectionString = "Server = 162.241.60.117; Uid = quaest71_treinamento; Pwd =treinamento123; database=quaest71_treinamento";
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

        public static void MostraLinhas(DataSet dtable)
        {
            foreach (DataTable tabela in dtable.Tables)
            {
                foreach (DataRow row in tabela.Rows)
                {
                    string linha = null;
                    for (int i = 0; i < tabela.Columns.Count; i++) linha += row[i].ToString() + " ";
                    Console.WriteLine(linha);
                }
            }
        }
        /*
        static void Main(string[] args)
        {
            string query = "SELECT * FROM `medicoCRM` where uf = 'SP' and crm like '1%'";
            var b = ConsultaQueryArmazena(query);
        }
        */
    }
}
