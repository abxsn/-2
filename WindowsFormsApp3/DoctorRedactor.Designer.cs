namespace WindowsFormsApp3
{
    partial class DoctorRedactor
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
            this.editButton = new System.Windows.Forms.Button();
            this.doctorBox3 = new System.Windows.Forms.TextBox();
            this.doctorBox2 = new System.Windows.Forms.TextBox();
            this.newDoctorParamether = new System.Windows.Forms.ComboBox();
            this.doctorParamether = new System.Windows.Forms.ComboBox();
            this.selectedDoctorId = new System.Windows.Forms.ComboBox();
            this.doctorExperience = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.doctorSpecialization = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.doctorName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.doctorId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.doctorBox1 = new System.Windows.Forms.TextBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // editButton
            // 
            this.editButton.Location = new System.Drawing.Point(464, 330);
            this.editButton.Name = "editButton";
            this.editButton.Size = new System.Drawing.Size(108, 35);
            this.editButton.TabIndex = 28;
            this.editButton.Text = "Отредактировать";
            this.editButton.UseVisualStyleBackColor = true;
            this.editButton.Click += new System.EventHandler(this.editButton_Click);
            // 
            // doctorBox3
            // 
            this.doctorBox3.Location = new System.Drawing.Point(286, 222);
            this.doctorBox3.Name = "doctorBox3";
            this.doctorBox3.Size = new System.Drawing.Size(162, 20);
            this.doctorBox3.TabIndex = 26;
            this.doctorBox3.Text = "Новое значение параметра";
            // 
            // doctorBox2
            // 
            this.doctorBox2.Location = new System.Drawing.Point(454, 222);
            this.doctorBox2.Name = "doctorBox2";
            this.doctorBox2.Size = new System.Drawing.Size(135, 20);
            this.doctorBox2.TabIndex = 24;
            this.doctorBox2.Text = "Изменяемый параметр";
            // 
            // newDoctorParamether
            // 
            this.newDoctorParamether.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.newDoctorParamether.FormattingEnabled = true;
            this.newDoctorParamether.Location = new System.Drawing.Point(286, 260);
            this.newDoctorParamether.Name = "newDoctorParamether";
            this.newDoctorParamether.Size = new System.Drawing.Size(121, 21);
            this.newDoctorParamether.TabIndex = 21;
            // 
            // doctorParamether
            // 
            this.doctorParamether.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.doctorParamether.FormattingEnabled = true;
            this.doctorParamether.Items.AddRange(new object[] {
            "Имя доктора",
            "Специализация",
            "Опыт доктора"});
            this.doctorParamether.Location = new System.Drawing.Point(454, 260);
            this.doctorParamether.Name = "doctorParamether";
            this.doctorParamether.Size = new System.Drawing.Size(121, 21);
            this.doctorParamether.TabIndex = 23;
            this.doctorParamether.SelectedIndexChanged += new System.EventHandler(this.doctorParamether_SelectedIndexChanged);
            // 
            // selectedDoctorId
            // 
            this.selectedDoctorId.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.selectedDoctorId.FormattingEnabled = true;
            this.selectedDoctorId.Location = new System.Drawing.Point(627, 260);
            this.selectedDoctorId.Name = "selectedDoctorId";
            this.selectedDoctorId.Size = new System.Drawing.Size(121, 21);
            this.selectedDoctorId.TabIndex = 12;
            // 
            // doctorExperience
            // 
            this.doctorExperience.HeaderText = "Опыт врача";
            this.doctorExperience.Name = "doctorExperience";
            this.doctorExperience.ReadOnly = true;
            // 
            // doctorSpecialization
            // 
            this.doctorSpecialization.HeaderText = "Специализация";
            this.doctorSpecialization.Name = "doctorSpecialization";
            this.doctorSpecialization.ReadOnly = true;
            // 
            // doctorName
            // 
            this.doctorName.HeaderText = "Врач";
            this.doctorName.Name = "doctorName";
            this.doctorName.ReadOnly = true;
            // 
            // doctorId
            // 
            this.doctorId.HeaderText = "id";
            this.doctorId.MinimumWidth = 2;
            this.doctorId.Name = "doctorId";
            this.doctorId.ReadOnly = true;
            // 
            // doctorBox1
            // 
            this.doctorBox1.Location = new System.Drawing.Point(648, 222);
            this.doctorBox1.Name = "doctorBox1";
            this.doctorBox1.Size = new System.Drawing.Size(100, 20);
            this.doctorBox1.TabIndex = 15;
            this.doctorBox1.Text = "Id врача";
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.doctorId,
            this.doctorName,
            this.doctorSpecialization,
            this.doctorExperience});
            this.dataGridView1.Location = new System.Drawing.Point(295, 29);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(443, 150);
            this.dataGridView1.TabIndex = 10;
            // 
            // DoctorRedactor
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1017, 507);
            this.Controls.Add(this.editButton);
            this.Controls.Add(this.doctorBox3);
            this.Controls.Add(this.doctorBox2);
            this.Controls.Add(this.newDoctorParamether);
            this.Controls.Add(this.doctorParamether);
            this.Controls.Add(this.selectedDoctorId);
            this.Controls.Add(this.doctorBox1);
            this.Controls.Add(this.dataGridView1);
            this.Name = "DoctorRedactor";
            this.Text = "DoctorRedactor";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button editButton;
        private System.Windows.Forms.TextBox doctorBox3;
        private System.Windows.Forms.TextBox doctorBox2;
        private System.Windows.Forms.ComboBox newDoctorParamether;
        private System.Windows.Forms.ComboBox doctorParamether;
        private System.Windows.Forms.ComboBox selectedDoctorId;
        private System.Windows.Forms.DataGridViewTextBoxColumn doctorExperience;
        private System.Windows.Forms.DataGridViewTextBoxColumn doctorSpecialization;
        private System.Windows.Forms.DataGridViewTextBoxColumn doctorName;
        private System.Windows.Forms.DataGridViewTextBoxColumn doctorId;
        private System.Windows.Forms.TextBox doctorBox1;
        private System.Windows.Forms.DataGridView dataGridView1;
    }
}