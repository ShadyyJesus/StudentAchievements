using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Достижения_студентов
{
    internal class authorization
    {
        static public string Role, Name, User;

        static public void Authorization(string login, string password)
        {
            try
            {
                db.MySqlCommand.CommandText = @"SELECT nameRole from role, account WHERE Login = '" + login + "' and Password = '" + password + "' and account.idRole = role.idRole";
                Object result = db.MySqlCommand.ExecuteScalar();
                if (result != null)
                {
                    Role = result.ToString();
                    User = login;
                }
                else
                {
                    Role = null;
                }
            }
            catch
            {
                Role = User = null;
                MessageBox.Show("Ошибка при авторизации!", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        static public string AuthorizationName(string login)
        {
            try
            {
                db.MySqlCommand.CommandText = @"SELECT Name FROM account WHERE Login = '" + login + "' ";
                Object result = db.MySqlCommand.ExecuteScalar();
                Name = result.ToString();
                return Name;
            }

            catch
            {
                return null;
            }
        }
    }
}
