using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;

namespace TechFusion_Vendas
{       
    internal class ClConnection
    {

        public static String DB = "DataBase_TechFusion";
        public static String server = "127.0.0.1";
        public static String user = "root";
        public static String senha = "";
        public MySqlConnection connection = null;
        static private String STRConect = $"server={server};database={DB};user id={user};senha={senha};";


        public MySqlConnection GetConnection()
        {
            connection = new MySqlConnection(STRConect);
            return connection;
        }

        public DataTable LogIn(TextBox user, TextBox senha)
        {
            DataTable reg = new DataTable();


            try
            {
                String Password = senha.Text;
                String UserName = user.Text;

                String sql = "select * usuario where UserName=@nameuser and senha=@password";

                MySqlConnection conn = GetConnection();
                conn.Open();

                MySqlCommand cmd = new MySqlCommand(sql, connection);

                cmd.Parameters.AddWithValue("@nameuser", UserName);
                cmd.Parameters.AddWithValue("@password", Password);

                MySqlDataAdapter adapter = new MySqlDataAdapter(cmd);
                adapter.Fill(reg);

                conn.Close();
            }
            catch(Exception ex)
            {
                MessageBox.Show("Erro de catch Clconnection: " + ex.Message);
            }


            return reg;
        }


        public DataTable Obter_dados(string sql)
        {
            DataTable dt = new DataTable();

            connection = GetConnection();
            connection.Open();

            MySqlCommand cmd = new MySqlCommand(sql, connection);
            MySqlDataAdapter adapter = new MySqlDataAdapter(cmd);
            adapter.Fill(dt);

            connection.Close();

            return dt;
        }

    }
}
