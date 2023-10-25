using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Runtime.Remoting.Contexts;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Достижения_студентов
{
    internal class MainDB
    {
        static string dbconnect = "server = localhost; user = root; password = 89244690760Andrey; database = достижения_студентов";
        static public MySqlDataAdapter MySqlDataAdapter;
        static MySqlConnection MySqlConnection;
        static public MySqlCommand MySqlCommand;


        public static bool ConnectionDB()
        {
            try
            {
                MySqlConnection = new MySqlConnection(dbconnect);
                MySqlConnection.Open();
                MySqlCommand = new MySqlCommand();
                MySqlCommand.Connection = MySqlConnection;
                MySqlDataAdapter = new MySqlDataAdapter(MySqlCommand);
                return true;
            }

            catch
            {
                MessageBox.Show("Ошибка соединения с базой данных!", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
        }

        public static void closeDB()
        {
            MySqlConnection.Close();
        }

        public MySqlConnection GetConnection()
        {
            return MySqlConnection;
        }
    }
}
