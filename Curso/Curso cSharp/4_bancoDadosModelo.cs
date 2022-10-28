using System;
using System.Collections;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using MySql.Data.MySqlClient; //Instalar o MySQL.Data
using MySqlX.XDevAPI;
using MySqlX.XDevAPI.Relational;

public class bancoDadosModelo
{
    private static string connectionString = "Server = 162.241.60.117; Uid = quaest71_treinamento; Pwd =treinamento123; database=quaest71_treinamento; Convert Zero Datetime=True";

    public static void ExecutaQuery(string query)
    {
        using (var conexao = new MySqlConnection(connectionString))
        {
            conexao.Open();
            MySqlCommand cmd = new MySqlCommand(query, conexao);
            cmd.ExecuteNonQuery();
            conexao.Close();
        }
    }
    public static MySqlDataReader ConsultaQuery(string query)
    {
        using (var conexao = new MySqlConnection(connectionString))
        {
            conexao.Open();
            MySqlCommand cmd = new MySqlCommand(query, conexao);
            MySqlDataReader reader = cmd.ExecuteReader();
            while (reader.Read())
            {
                Console.WriteLine($"{reader[0]};{reader[1]};{reader[2]}");
            }
            return reader;
            conexao.Close();
        }
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
    public static void ConsultaCRM()
    {
        DataSet ds = new DataSet();
        string query = "SELECT * FROM medicoCRM";
        using (var conexao = new MySqlConnection(connectionString))
        {
            ds.Tables.Add("crmMedicos");
            MySqlCommand mycommand = new MySqlCommand(query, conexao);
            using (MySqlDataAdapter adapter = new MySqlDataAdapter(mycommand)) adapter.Fill(ds, ds.Tables[0].TableName);
        }
        query = "SELECT * FROM Alunos";
        using (var conexao = new MySqlConnection(connectionString))
        {
            ds.Tables.Add("Aluno");
            MySqlCommand mycommand = new MySqlCommand(query, conexao);
            using (MySqlDataAdapter adapter = new MySqlDataAdapter(mycommand)) adapter.Fill(ds, ds.Tables[1].TableName);
        }
                
        var a = ds.Tables["crmMedicos"];
        var v = ds.Tables["Aluno"];
    }

    public class execucao4
    {
        /*  
         *  https://www.connectionstrings.com/mysql/
         *  IP: 162.241.60.117
         *  login: quaest71_treinamento
         *  senha: treinamento123
         *  Banco de Dados: quaest71_treinamento
         *  
         *  Toda vez que finaliza uma conexao o reader e zerado
         */

        /*
        static void Main(string[] args)
        {
            //string query = "SELECT * FROM `Alunos` where MATRICULA BETWEEN \"2020-07-01\" and \"2020-08-31\"";
            //var a = ConsultaQuery(query);
            //var b = ConsultaQueryArmazena(query);

            //MostraLinhas(b);
            ConsultaCRM();
        }
        */


    }
}