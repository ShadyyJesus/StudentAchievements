namespace Достижения_студентов
{
    partial class AchievStud
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.panel1 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.idAchievements = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.idStudent = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.achievementsName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.idPlace = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.idStage = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.back = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Silver;
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.label1);
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(824, 94);
            this.panel1.TabIndex = 3;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Montserrat ExtraBold", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(3, 30);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(262, 26);
            this.label1.TabIndex = 0;
            this.label1.Text = "Достижение студентов";
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.AllowUserToResizeColumns = false;
            this.dataGridView1.AllowUserToResizeRows = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idAchievements,
            this.idStudent,
            this.achievementsName,
            this.idPlace,
            this.idStage});
            this.dataGridView1.Location = new System.Drawing.Point(12, 99);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.Size = new System.Drawing.Size(801, 356);
            this.dataGridView1.TabIndex = 4;
            // 
            // idAchievements
            // 
            this.idAchievements.DataPropertyName = "idAchievements";
            this.idAchievements.HeaderText = "idAchievements";
            this.idAchievements.Name = "idAchievements";
            this.idAchievements.ReadOnly = true;
            // 
            // idStudent
            // 
            this.idStudent.DataPropertyName = "idStudent";
            this.idStudent.HeaderText = "idStudent";
            this.idStudent.Name = "idStudent";
            this.idStudent.ReadOnly = true;
            // 
            // achievementsName
            // 
            this.achievementsName.DataPropertyName = "achievementsName";
            this.achievementsName.HeaderText = "achievementsName";
            this.achievementsName.Name = "achievementsName";
            this.achievementsName.ReadOnly = true;
            // 
            // idPlace
            // 
            this.idPlace.DataPropertyName = "idPlace";
            this.idPlace.HeaderText = "idPlace";
            this.idPlace.Name = "idPlace";
            this.idPlace.ReadOnly = true;
            // 
            // idStage
            // 
            this.idStage.DataPropertyName = "idStage";
            this.idStage.HeaderText = "idStage";
            this.idStage.Name = "idStage";
            this.idStage.ReadOnly = true;
            // 
            // back
            // 
            this.back.Location = new System.Drawing.Point(12, 483);
            this.back.Name = "back";
            this.back.Size = new System.Drawing.Size(182, 28);
            this.back.TabIndex = 5;
            this.back.Text = "Назад";
            this.back.UseVisualStyleBackColor = true;
            this.back.Click += new System.EventHandler(this.back_Click);
            // 
            // AchievStud
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(824, 523);
            this.Controls.Add(this.back);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.panel1);
            this.Name = "AchievStud";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Достижения студентов";
            this.Load += new System.EventHandler(this.AchievStud_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridViewTextBoxColumn idAchievements;
        private System.Windows.Forms.DataGridViewTextBoxColumn idStudent;
        private System.Windows.Forms.DataGridViewTextBoxColumn achievementsName;
        private System.Windows.Forms.DataGridViewTextBoxColumn idPlace;
        private System.Windows.Forms.DataGridViewTextBoxColumn idStage;
        private System.Windows.Forms.Button back;
    }
}