using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.Remoting.Contexts;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace Достижения_студентов
{
    public partial class achievForm : Form
    {

        public achievForm()
        {
            InitializeComponent();
        }

        private void back_Click(object sender, EventArgs e)
        {
            this.Hide();
            AdminForm form = new AdminForm();
            form.Show();
        }


        private void newcolum_Click(object sender, EventArgs e)
        {
            MainDB.ConnectionDB();

            string achievementsName = NameAchiv.Text; // Замените на фактические значения
            int idStudent = Convert.ToInt32(student.Text); // Замените на фактический ID студента
            int idPlace = Convert.ToInt32(place.Text); // Замените на фактический ID места
            int idStage = Convert.ToInt32(stage.Text); // Замените на фактический ID стадии

            string insertQuery = "INSERT INTO achievements (idStudent, achievementsName, idPlace, idStage) VALUES (@idStudent, @achievementsName, @idPlace, @idStage)";
            MainDB.MySqlCommand.Parameters.AddWithValue("@idStudent", idStudent);
            MainDB.MySqlCommand.Parameters.AddWithValue("@achievementsName", achievementsName);
            MainDB.MySqlCommand.Parameters.AddWithValue("@idPlace", idPlace);
            MainDB.MySqlCommand.Parameters.AddWithValue("@idStage", idStage);

            MainDB.MySqlCommand.CommandText = insertQuery;
            MainDB.MySqlCommand.ExecuteNonQuery();

            MainDB.closeDB();

            // После добавления обновите DataGridView, чтобы отразить новую запись
            achievForm_Load(this, null);
        }

        private void achievForm_Load(object sender, EventArgs e)
        { 
            MainDB.ConnectionDB();

            MainDB.MySqlCommand.CommandText = "SELECT * FROM achievements";
            DataTable dataTable = new DataTable();

            MainDB.MySqlDataAdapter.Fill(dataTable);

            MainDB.closeDB();

            dataGridView1.DataSource = dataTable;
            dataGridView1.Update();
        }

        private void edit_Click(object sender, EventArgs e)
        {
            MainDB.ConnectionDB();

            if (dataGridView1.SelectedRows.Count > 0)
            {
                int rowIndex = dataGridView1.SelectedRows[0].Index;
                int idAchievements = Convert.ToInt32(dataGridView1.Rows[rowIndex].Cells["idAchievements"].Value);

                string achievementsName = NameAchiv.Text;
                int idStudent = Convert.ToInt32(student.Text);
                int idPlace = Convert.ToInt32(place.Text);
                int idStage = Convert.ToInt32(stage.Text);

                string updateQuery = "UPDATE achievements SET idStudent = @idStudent, achievementsName = @achievementsName, idPlace = @idPlace, idStage = @idStage WHERE idAchievements = @idAchievements";
                MainDB.MySqlCommand.Parameters.AddWithValue("@idStudent", idStudent);
                MainDB.MySqlCommand.Parameters.AddWithValue("@achievementsName", achievementsName);
                MainDB.MySqlCommand.Parameters.AddWithValue("@idPlace", idPlace);
                MainDB.MySqlCommand.Parameters.AddWithValue("@idStage", idStage);
                MainDB.MySqlCommand.Parameters.AddWithValue("@idAchievements", idAchievements);

                MainDB.MySqlCommand.CommandText = updateQuery;
                MainDB.MySqlCommand.ExecuteNonQuery();

                MainDB.closeDB();

                achievForm_Load(this, null);
            }
        }

        private void delete_Click(object sender, EventArgs e)
        {
            MainDB.ConnectionDB();

            if (dataGridView1.SelectedRows.Count > 0)
            {
                int rowIndex = dataGridView1.SelectedRows[0].Index;
                int idAchievements = Convert.ToInt32(dataGridView1.Rows[rowIndex].Cells["idAchievements"].Value);

                string deleteQuery = "DELETE FROM achievements WHERE idAchievements = @idAchievements";
                MainDB.MySqlCommand.Parameters.AddWithValue("@idAchievements", idAchievements);

                MainDB.MySqlCommand.CommandText = deleteQuery;
                MainDB.MySqlCommand.ExecuteNonQuery();

                MainDB.closeDB();

                achievForm_Load(this, null);
            }
        }
    }
}
