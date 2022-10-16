## <a href="https://github.com/Hidekithiago/CSharp/blob/master/README.md">Banco de Dados</a> <br>
<details>
<details><summary><b>SQL SERVER</b></summary>
  
####  NuGet
  >using System.Data.SqlClient
  
####  import
  >using System.Data.SqlClient; //Instalar o System.Data.SqlClient
     
####  Code
  > SqlConnection conexao = new SqlConnection(connString); <br>
            conexao.Open(); <br>
            SqlCommand cmd = new SqlCommand(query, conexao); <br>
            SqlDataReader reader = cmd.ExecuteReader(); <br>
            while (reader.Read()) <br>
            { <br>
                MessageBox.Show(String.Format("{0};{1};{2};{3}", reader[0], reader[1], reader[2], reader[3])); <br>
            } <br>
            conexao.Close(); <br>
  
</details>
<details><summary><b>MYSQL</b></summary>
  
####  NuGet
  >MySQL.Data
  
####  import
  >using MySql.Data.MySqlClient; //Instalar o MySQL.Data
  
####  Code
  >MySqlConnection conexao = new MySqlConnection(connString); //Cria conexão com o BD na variável conexao <br>
            conexao.Open(); //Libera a conexão <br>
            MySqlCommand cmd = new MySqlCommand(query, conexao); //Executa a query na conexão <br> 
            MySqlDataReader reader = cmd.ExecuteReader(); //Salva os dados em uma variável <br>
            while (reader.Read()) //Cria uma recorrencia para os dados encontrados(Semelhante ao "FOR EACH") <br>
            { <br>
                MessageBox.Show(String.Format("{0};{1};{2};{3}", reader[0], reader[1], reader[2], reader[3])); //Mostra o resultado <br>
            } <br>
            conexao.Close(); //Fecha conexão <br>
  
</details>
<details><summary><b>MYSQL</b></summary>
  
####  NuGet
  >MySQL.Data
  
####  import
  >using MySql.Data.MySqlClient; //Instalar o MySQL.Data
  
####  Code
  >using (var conexao = new MySqlConnection(mysqldb))
  ><br>          {
  ><br>                conexao.Open(); //Libera a conexão
  ><br>                string query = "SELECT * FROM retencao_ecac where cnpj_benef = '" + cnpjBeneficio + "' and cnpj_pagador = '" + cnpjPagador + "' and imposto = " + rendimento;
  ><br>                Console.WriteLine(query);
  ><br>                MySqlCommand cmd = new MySqlCommand(query, conexao); //Executa a query na conexão
  ><br>                MySqlDataReader reader = cmd.ExecuteReader();
  ><br>                if (reader.HasRows) return 1;
  ><br>                else return 0;              
  ><br>            }
  
</details>

<details><summary><b>ORACLE</b></summary>
  
####  NuGet
  >using Oracle.ManagedDataAccess
  
####  import
  >using Oracle.ManagedDataAccess.Client; //Instalar Oracle.ManagedDataAccess
  
####  Code
  >OracleConnection conexao = new OracleConnection(connString); <br>
            conexao.Open(); <br>
            OracleCommand cmd = new OracleCommand(query, conexao); <br>
            OracleDataReader reader = cmd.ExecuteReader(); <br>
            while (reader.Read()) <br>
            { <br>
                MessageBox.Show(String.Format("{0};{1};{2};{3}", reader[0], reader[1], reader[2], reader[3])); <br>
            } <br>
            conexao.Close(); <br>
  
</details>
</details>
