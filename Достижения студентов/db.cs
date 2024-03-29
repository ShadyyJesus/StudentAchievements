﻿using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Достижения_студентов
{
    internal class db
    {
        static string dbconnect = "server = localhost; user = root; password = root; database = authorization";
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
