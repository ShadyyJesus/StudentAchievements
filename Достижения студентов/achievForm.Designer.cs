namespace Достижения_студентов
{
    partial class achievForm
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
            this.back = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.idAchievements = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.idStudent = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.achievementsName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.idPlace = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.idStage = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.panel2 = new System.Windows.Forms.Panel();
            this.newcolum = new System.Windows.Forms.Button();
            this.delete = new System.Windows.Forms.Button();
            this.edit = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.panel3 = new System.Windows.Forms.Panel();
            this.stage = new System.Windows.Forms.TextBox();
            this.place = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.NameAchiv = new System.Windows.Forms.TextBox();
            this.student = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.panel2.SuspendLayout();
            this.panel3.SuspendLayout();
            this.SuspendLayout();
            // 
            // back
            // 
            this.back.Location = new System.Drawing.Point(3, 160);
            this.back.Name = "back";
            this.back.Size = new System.Drawing.Size(182, 28);
            this.back.TabIndex = 0;
            this.back.Text = "Назад";
            this.back.UseVisualStyleBackColor = true;
            this.back.Click += new System.EventHandler(this.back_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Silver;
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.label1);
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(824, 94);
            this.panel1.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Montserrat ExtraBold", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(6, 29);
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
            this.dataGridView1.Location = new System.Drawing.Point(12, 100);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.Size = new System.Drawing.Size(801, 356);
            this.dataGridView1.TabIndex = 3;
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
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.panel2.Controls.Add(this.newcolum);
            this.panel2.Controls.Add(this.delete);
            this.panel2.Controls.Add(this.edit);
            this.panel2.Controls.Add(this.back);
            this.panel2.Location = new System.Drawing.Point(618, 478);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(188, 196);
            this.panel2.TabIndex = 4;
            // 
            // newcolum
            // 
            this.newcolum.Location = new System.Drawing.Point(3, 3);
            this.newcolum.Name = "newcolum";
            this.newcolum.Size = new System.Drawing.Size(182, 46);
            this.newcolum.TabIndex = 4;
            this.newcolum.Text = "Новая запись";
            this.newcolum.UseVisualStyleBackColor = true;
            this.newcolum.Click += new System.EventHandler(this.newcolum_Click);
            // 
            // delete
            // 
            this.delete.Location = new System.Drawing.Point(3, 90);
            this.delete.Name = "delete";
            this.delete.Size = new System.Drawing.Size(182, 29);
            this.delete.TabIndex = 2;
            this.delete.Text = "Удалить";
            this.delete.UseVisualStyleBackColor = true;
            this.delete.Click += new System.EventHandler(this.delete_Click);
            // 
            // edit
            // 
            this.edit.Location = new System.Drawing.Point(3, 55);
            this.edit.Name = "edit";
            this.edit.Size = new System.Drawing.Size(182, 29);
            this.edit.TabIndex = 1;
            this.edit.Text = "Изменить";
            this.edit.UseVisualStyleBackColor = true;
            this.edit.Click += new System.EventHandler(this.edit_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Inter", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.Location = new System.Drawing.Point(611, 457);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(202, 19);
            this.label2.TabIndex = 5;
            this.label2.Text = "Управление записями";
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.panel3.Controls.Add(this.stage);
            this.panel3.Controls.Add(this.place);
            this.panel3.Controls.Add(this.label9);
            this.panel3.Controls.Add(this.label8);
            this.panel3.Controls.Add(this.NameAchiv);
            this.panel3.Controls.Add(this.student);
            this.panel3.Controls.Add(this.label6);
            this.panel3.Controls.Add(this.label4);
            this.panel3.Location = new System.Drawing.Point(12, 478);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(600, 196);
            this.panel3.TabIndex = 6;
            // 
            // stage
            // 
            this.stage.Location = new System.Drawing.Point(208, 121);
            this.stage.Name = "stage";
            this.stage.Size = new System.Drawing.Size(377, 20);
            this.stage.TabIndex = 22;
            // 
            // place
            // 
            this.place.Location = new System.Drawing.Point(208, 98);
            this.place.Name = "place";
            this.place.Size = new System.Drawing.Size(377, 20);
            this.place.TabIndex = 21;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Inter", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label9.Location = new System.Drawing.Point(151, 121);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(51, 19);
            this.label9.TabIndex = 20;
            this.label9.Text = "Этап:";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Inter", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label8.Location = new System.Drawing.Point(70, 98);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(132, 19);
            this.label8.TabIndex = 19;
            this.label8.Text = "Занятое место:";
            // 
            // NameAchiv
            // 
            this.NameAchiv.Location = new System.Drawing.Point(208, 72);
            this.NameAchiv.Name = "NameAchiv";
            this.NameAchiv.Size = new System.Drawing.Size(377, 20);
            this.NameAchiv.TabIndex = 18;
            // 
            // student
            // 
            this.student.Location = new System.Drawing.Point(208, 48);
            this.student.Name = "student";
            this.student.Size = new System.Drawing.Size(377, 20);
            this.student.TabIndex = 16;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Inter", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label6.Location = new System.Drawing.Point(11, 73);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(191, 19);
            this.label6.TabIndex = 3;
            this.label6.Text = "Название достижения:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Inter", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label4.Location = new System.Drawing.Point(95, 48);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(107, 19);
            this.label4.TabIndex = 1;
            this.label4.Text = "ID студента:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Inter", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label7.Location = new System.Drawing.Point(12, 459);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(76, 19);
            this.label7.TabIndex = 7;
            this.label7.Text = "Запись:";
            // 
            // achievForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(824, 679);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.panel2);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "achievForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Достижения студентов";
            this.Load += new System.EventHandler(this.achievForm_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button back;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button delete;
        private System.Windows.Forms.Button edit;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button newcolum;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox NameAchiv;
        private System.Windows.Forms.TextBox student;
        private System.Windows.Forms.TextBox stage;
        private System.Windows.Forms.TextBox place;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.DataGridViewTextBoxColumn idAchievements;
        private System.Windows.Forms.DataGridViewTextBoxColumn idStudent;
        private System.Windows.Forms.DataGridViewTextBoxColumn achievementsName;
        private System.Windows.Forms.DataGridViewTextBoxColumn idPlace;
        private System.Windows.Forms.DataGridViewTextBoxColumn idStage;
    }
}