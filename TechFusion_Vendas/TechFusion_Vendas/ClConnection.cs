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
        public static String server = "localhost";
        public static String user = "root";
        public static String senha = "";
        public MySqlConnection connection = null;
        static private String STRConect = $"server={server};database={DB};user id={user};senha={senha};";


        public MySqlConnection GetConnection()
        {
            connection = new MySqlConnection(STRConect);
            connection.Open();
            return connection;
        }

        public DataTable LogIn(TextBox user, TextBox senha)
        {
            DataTable reg = new DataTable();


            try
            {
                String Password = senha.Text;
                String UserName = user.Text;
                String sql = "select * from usuario where UserName=@user and senha=@password";


                MySqlConnection com = GetConnection();



                MySqlCommand cmd = new MySqlCommand(sql, com);
                cmd.Parameters.AddWithValue("@password", Password);
                cmd.Parameters.AddWithValue("@user", user);
                MySqlDataAdapter adapter = new MySqlDataAdapter(cmd);
                adapter.Fill(reg);
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
            

            MySqlCommand cmd = new MySqlCommand(sql, connection);
            MySqlDataAdapter adapter = new MySqlDataAdapter(cmd);
            adapter.Fill(dt);

            connection.Close();

            return dt;
        }

        public int SignUp(TextBox nome, TextBox username, TextBox password, int idade, int dexCBperfil, String cam_foto)
        {
            int reg = 0;

            try
            {
                connection = GetConnection();

                String name = nome.Text;
                String senha = password.Text;
                String user = username.Text;
                Int32 cargo = dexCBperfil;

                Int32 age = (idade - DateTime.Now.Year)*(-1);

                string dat_reg = $"{DateTime.Now.Year}-{DateTime.Now.Month}-{DateTime.Now.Day}"; // YYYY-MM-DD
                string tim_reg = Convert.ToString(DateTime.Now.Hour) + ":" + Convert.ToString(DateTime.Now.Minute) + ":" + Convert.ToString(DateTime.Now.Second);// HH:MM:SS

                String sql = $"insert into usuario (Nome_user, idade_user, foto_user, data_Registro, horario_Registro, UserName, senha, CFK_perfil) values ('{name}', {age}, '{cam_foto}','{dat_reg}', '{tim_reg}', '{user}', '{senha}', {cargo});";

                MySqlCommand cmd = new MySqlCommand (sql, connection);
                reg = Convert.ToInt32(cmd.ExecuteNonQuery());
                connection.Close();
            }catch(Exception ex)
            {
                MessageBox.Show("Erro na criação de Usuário: "+ ex.Message);
            }
            return reg;

        }

    }
}
