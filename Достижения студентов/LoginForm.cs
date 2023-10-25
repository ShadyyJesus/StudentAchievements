using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Common;
using System.Drawing;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Достижения_студентов
{
    public partial class LoginForm : Form
    {
        static public string loginActive;
        static public string whois;
        public LoginForm()
        {
            InitializeComponent();

            this.passField.AutoSize = false;
            this.passField.Size = new Size(this.passField.Size.Width, 36);
        }

        private void LoginForm_Load(object sender, EventArgs e)
        {
            db.ConnectionDB();
        }

        private void SignUp_Click(object sender, EventArgs e)
        {
            if(loginField.Text != "" && passField.Text != "")
            {
                authorization.Authorization(loginField.Text, passField.Text);
                switch(authorization.Role)
                {
                    case null:
                        {
                            MessageBox.Show("Такого аккаунта не существует!", "Проверьте данные и попробуйте снова", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                            break;
                        }
                    case "Администратор":
                        {
                            loginActive = loginField.Text;
                            whois = "Администратор";
                            authorization.User = loginField.Text;

                            string Name = authorization.AuthorizationName(loginField.Text);
                            authorization.Name = Name;
                            MessageBox.Show(Name + ", добро пожаловать в меню администратора!", "Успешно", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            this.Hide();
                            AdminForm admin = new AdminForm();
                            admin.Show();
                            break;
                        }
                    case "Студент":
                        {
                            loginActive = loginField.Text;
                            whois = "Студент";
                            authorization.User = loginField.Text;

                            string Name = authorization.AuthorizationName(loginField.Text);
                            authorization.Name = Name;
                            MessageBox.Show(Name + ", добро пожаловать!", "Успешно", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            this.Hide();
                            studentform admin = new studentform();
                            admin.Show();
                            break;
                        }
                }
            }
            else
            {
                MessageBox.Show("Заполните все обязательные поля!", "Заполнение полей", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }
    }
}
