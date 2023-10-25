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
    public partial class AchievStud : Form
    {
        public AchievStud()
        {
            InitializeComponent();
        }

        private void back_Click(object sender, EventArgs e)
        {
            this.Hide();
            AdminForm form = new AdminForm();
            form.Show();
        }

        private void AchievStud_Load(object sender, EventArgs e)
        {
            MainDB.ConnectionDB();

            MainDB.MySqlCommand.CommandText = "SELECT * FROM achievements";
            DataTable dataTable = new DataTable();

            MainDB.MySqlDataAdapter.Fill(dataTable);

            MainDB.closeDB();

            dataGridView1.DataSource = dataTable;
            dataGridView1.Update();
        }
    }
}
