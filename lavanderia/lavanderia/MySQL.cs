using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lavanderia
{
    internal class MySQL
    {
        public MySqlConnection conexao;
        public bool conectar()
        {
            bool result;
            string server = "localhost";
            string port = "3306";
            string user = "lavanderia_user";
            string password = "123";
            string database = "LavanderiaDB";
            string connectionString =
           $"server={server};port={port};user={user};password={password};database={database}";
            conexao = new MySqlConnection(connectionString);
            try
            {
                conexao.Open();
                result = true;
            }
            catch (Exception ex)
            {
                result = false;
                MessageBox.Show("Erro ao conectar o banco: " + ex.Message);
            }
            return result;
        }
        public void desconectar()
        {
            try
            {
                conexao.Close();
            }
            catch (Exception ex)
            {
                Console.WriteLine("Erro ao desconectar o banco: " + ex.Message);
            }
        }
    }
}
