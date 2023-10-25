using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Достижения_студентов
{
    public partial class AdminForm : Form
    {
        public AdminForm()
        {
            InitializeComponent();
        }

        private void backbtn_Click(object sender, EventArgs e)
        {
            this.Hide();
            LoginForm form = new LoginForm();
            form.Show();
        }

        private void quit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void achiev_Click(object sender, EventArgs e)
        {
            this.Hide();
            achievForm form = new achievForm();
            form.Show();
        }

    }
}
