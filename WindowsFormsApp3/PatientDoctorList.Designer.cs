namespace WindowsFormsApp3
{
    partial class PatientDoctorList
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(PatientDoctorList));
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.doctorId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.doctorName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.doctorSpecialization = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.doctorExperience = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridView2 = new System.Windows.Forms.DataGridView();
            this.patientId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.patientName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.patientComplaints = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.patientDiagnosis = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.selectedDoctorId = new System.Windows.Forms.ComboBox();
            this.selectedPatientId = new System.Windows.Forms.ComboBox();
            this.doctorBox1 = new System.Windows.Forms.TextBox();
            this.patientBox2 = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.removeButton = new System.Windows.Forms.Button();
            this.doctorButton = new System.Windows.Forms.RadioButton();
            this.patientButton = new System.Windows.Forms.RadioButton();
            this.doctorParamether = new System.Windows.Forms.ComboBox();
            this.newDoctorParamether = new System.Windows.Forms.ComboBox();
            this.doctorBox2 = new System.Windows.Forms.TextBox();
            this.doctorBox3 = new System.Windows.Forms.TextBox();
            this.patientParamether = new System.Windows.Forms.ComboBox();
            this.newPatientParamether = new System.Windows.Forms.ComboBox();
            this.patientBox1 = new System.Windows.Forms.TextBox();
            this.patientBox3 = new System.Windows.Forms.TextBox();
            this.editButton = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.doctorId,
            this.doctorName,
            this.doctorSpecialization,
            this.doctorExperience});
            this.dataGridView1.Location = new System.Drawing.Point(25, 84);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(443, 150);
            this.dataGridView1.TabIndex = 0;
            // 
            // doctorId
            // 
            this.doctorId.HeaderText = "id";
            this.doctorId.MinimumWidth = 2;
            this.doctorId.Name = "doctorId";
            this.doctorId.ReadOnly = true;
            // 
            // doctorName
            // 
            this.doctorName.HeaderText = "Врач";
            this.doctorName.Name = "doctorName";
            this.doctorName.ReadOnly = true;
            // 
            // doctorSpecialization
            // 
            this.doctorSpecialization.HeaderText = "Специализация";
            this.doctorSpecialization.Name = "doctorSpecialization";
            this.doctorSpecialization.ReadOnly = true;
            // 
            // doctorExperience
            // 
            this.doctorExperience.HeaderText = "Опыт врача";
            this.doctorExperience.Name = "doctorExperience";
            this.doctorExperience.ReadOnly = true;
            // 
            // dataGridView2
            // 
            this.dataGridView2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView2.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.patientId,
            this.patientName,
            this.patientComplaints,
            this.patientDiagnosis});
            this.dataGridView2.Location = new System.Drawing.Point(557, 84);
            this.dataGridView2.Name = "dataGridView2";
            this.dataGridView2.Size = new System.Drawing.Size(442, 150);
            this.dataGridView2.TabIndex = 1;
            this.dataGridView2.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView2_CellContentClick);
            // 
            // patientId
            // 
            this.patientId.HeaderText = "id";
            this.patientId.Name = "patientId";
            this.patientId.ReadOnly = true;
            // 
            // patientName
            // 
            this.patientName.HeaderText = "Пациент";
            this.patientName.Name = "patientName";
            this.patientName.ReadOnly = true;
            // 
            // patientComplaints
            // 
            this.patientComplaints.HeaderText = "Жалобы";
            this.patientComplaints.Name = "patientComplaints";
            this.patientComplaints.ReadOnly = true;
            // 
            // patientDiagnosis
            // 
            this.patientDiagnosis.HeaderText = "Диагноз (Врача)";
            this.patientDiagnosis.Name = "patientDiagnosis";
            this.patientDiagnosis.ReadOnly = true;
            // 
            // selectedDoctorId
            // 
            this.selectedDoctorId.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.selectedDoctorId.FormattingEnabled = true;
            this.selectedDoctorId.Location = new System.Drawing.Point(349, 318);
            this.selectedDoctorId.Name = "selectedDoctorId";
            this.selectedDoctorId.Size = new System.Drawing.Size(121, 21);
            this.selectedDoctorId.TabIndex = 2;
            this.selectedDoctorId.Visible = false;
            // 
            // selectedPatientId
            // 
            this.selectedPatientId.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.selectedPatientId.FormattingEnabled = true;
            this.selectedPatientId.Location = new System.Drawing.Point(557, 318);
            this.selectedPatientId.Name = "selectedPatientId";
            this.selectedPatientId.Size = new System.Drawing.Size(121, 21);
            this.selectedPatientId.TabIndex = 2;
            this.selectedPatientId.Visible = false;
            // 
            // doctorBox1
            // 
            this.doctorBox1.Location = new System.Drawing.Point(370, 280);
            this.doctorBox1.Name = "doctorBox1";
            this.doctorBox1.Size = new System.Drawing.Size(100, 20);
            this.doctorBox1.TabIndex = 3;
            this.doctorBox1.Text = "Id врача";
            this.doctorBox1.Visible = false;
            this.doctorBox1.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // patientBox2
            // 
            this.patientBox2.Location = new System.Drawing.Point(557, 280);
            this.patientBox2.Name = "patientBox2";
            this.patientBox2.Size = new System.Drawing.Size(100, 20);
            this.patientBox2.TabIndex = 3;
            this.patientBox2.Text = "Id пациента";
            this.patientBox2.Visible = false;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(447, 383);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(123, 36);
            this.button1.TabIndex = 4;
            this.button1.Text = "Заставить врача поставить дигноз";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Visible = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // removeButton
            // 
            this.removeButton.Location = new System.Drawing.Point(416, 377);
            this.removeButton.Name = "removeButton";
            this.removeButton.Size = new System.Drawing.Size(189, 48);
            this.removeButton.TabIndex = 5;
            this.removeButton.Text = "Уничтожить выбранного человека";
            this.removeButton.UseVisualStyleBackColor = true;
            this.removeButton.Visible = false;
            this.removeButton.Click += new System.EventHandler(this.button2_Click);
            // 
            // doctorButton
            // 
            this.doctorButton.AutoSize = true;
            this.doctorButton.Checked = true;
            this.doctorButton.Location = new System.Drawing.Point(25, 510);
            this.doctorButton.Name = "doctorButton";
            this.doctorButton.Size = new System.Drawing.Size(63, 17);
            this.doctorButton.TabIndex = 6;
            this.doctorButton.TabStop = true;
            this.doctorButton.Text = "Доктор";
            this.doctorButton.UseVisualStyleBackColor = true;
            this.doctorButton.Visible = false;
            this.doctorButton.CheckedChanged += new System.EventHandler(this.radioButton1_CheckedChanged);
            // 
            // patientButton
            // 
            this.patientButton.AutoSize = true;
            this.patientButton.Location = new System.Drawing.Point(25, 536);
            this.patientButton.Name = "patientButton";
            this.patientButton.Size = new System.Drawing.Size(68, 17);
            this.patientButton.TabIndex = 6;
            this.patientButton.Text = "Пациент";
            this.patientButton.UseVisualStyleBackColor = true;
            this.patientButton.Visible = false;
            this.patientButton.CheckedChanged += new System.EventHandler(this.radioButton2_CheckedChanged);
            // 
            // doctorParamether
            // 
            this.doctorParamether.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.doctorParamether.FormattingEnabled = true;
            this.doctorParamether.Items.AddRange(new object[] {
            "Имя доктора",
            "Специализация",
            "Опыт доктора"});
            this.doctorParamether.Location = new System.Drawing.Point(176, 318);
            this.doctorParamether.Name = "doctorParamether";
            this.doctorParamether.Size = new System.Drawing.Size(121, 21);
            this.doctorParamether.TabIndex = 7;
            this.doctorParamether.Visible = false;
            this.doctorParamether.SelectedIndexChanged += new System.EventHandler(this.doctorParamether_SelectedIndexChanged);
            // 
            // newDoctorParamether
            // 
            this.newDoctorParamether.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.newDoctorParamether.FormattingEnabled = true;
            this.newDoctorParamether.Location = new System.Drawing.Point(8, 318);
            this.newDoctorParamether.Name = "newDoctorParamether";
            this.newDoctorParamether.Size = new System.Drawing.Size(121, 21);
            this.newDoctorParamether.TabIndex = 7;
            this.newDoctorParamether.Visible = false;
            // 
            // doctorBox2
            // 
            this.doctorBox2.Location = new System.Drawing.Point(176, 280);
            this.doctorBox2.Name = "doctorBox2";
            this.doctorBox2.Size = new System.Drawing.Size(135, 20);
            this.doctorBox2.TabIndex = 8;
            this.doctorBox2.Text = "Изменяемый параметр";
            this.doctorBox2.Visible = false;
            // 
            // doctorBox3
            // 
            this.doctorBox3.Location = new System.Drawing.Point(8, 280);
            this.doctorBox3.Name = "doctorBox3";
            this.doctorBox3.Size = new System.Drawing.Size(162, 20);
            this.doctorBox3.TabIndex = 8;
            this.doctorBox3.Text = "Новое значение параметра";
            this.doctorBox3.Visible = false;
            // 
            // patientParamether
            // 
            this.patientParamether.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.patientParamether.FormattingEnabled = true;
            this.patientParamether.Items.AddRange(new object[] {
            "Имя доктора",
            "Специализация",
            "Опыт доктора"});
            this.patientParamether.Location = new System.Drawing.Point(692, 318);
            this.patientParamether.Name = "patientParamether";
            this.patientParamether.Size = new System.Drawing.Size(121, 21);
            this.patientParamether.TabIndex = 7;
            this.patientParamether.Visible = false;
            this.patientParamether.SelectedIndexChanged += new System.EventHandler(this.patientParamether_SelectedIndexChanged);
            // 
            // newPatientParamether
            // 
            this.newPatientParamether.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.newPatientParamether.FormattingEnabled = true;
            this.newPatientParamether.Location = new System.Drawing.Point(846, 318);
            this.newPatientParamether.Name = "newPatientParamether";
            this.newPatientParamether.Size = new System.Drawing.Size(121, 21);
            this.newPatientParamether.TabIndex = 7;
            this.newPatientParamether.Visible = false;
            // 
            // patientBox1
            // 
            this.patientBox1.Location = new System.Drawing.Point(692, 280);
            this.patientBox1.Name = "patientBox1";
            this.patientBox1.Size = new System.Drawing.Size(135, 20);
            this.patientBox1.TabIndex = 8;
            this.patientBox1.Text = "Изменяемый параметр";
            this.patientBox1.Visible = false;
            // 
            // patientBox3
            // 
            this.patientBox3.Location = new System.Drawing.Point(846, 280);
            this.patientBox3.Name = "patientBox3";
            this.patientBox3.Size = new System.Drawing.Size(162, 20);
            this.patientBox3.TabIndex = 8;
            this.patientBox3.Text = "Новое значение параметра";
            this.patientBox3.Visible = false;
            // 
            // editButton
            // 
            this.editButton.Location = new System.Drawing.Point(462, 383);
            this.editButton.Name = "editButton";
            this.editButton.Size = new System.Drawing.Size(108, 35);
            this.editButton.TabIndex = 9;
            this.editButton.Text = "Отредактировать";
            this.editButton.UseVisualStyleBackColor = true;
            this.editButton.Visible = false;
            this.editButton.Click += new System.EventHandler(this.editButton_Click);
            // 
            // PatientDoctorList
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(1020, 583);
            this.Controls.Add(this.editButton);
            this.Controls.Add(this.patientBox3);
            this.Controls.Add(this.doctorBox3);
            this.Controls.Add(this.patientBox1);
            this.Controls.Add(this.doctorBox2);
            this.Controls.Add(this.newPatientParamether);
            this.Controls.Add(this.newDoctorParamether);
            this.Controls.Add(this.patientParamether);
            this.Controls.Add(this.doctorParamether);
            this.Controls.Add(this.patientButton);
            this.Controls.Add(this.doctorButton);
            this.Controls.Add(this.removeButton);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.patientBox2);
            this.Controls.Add(this.doctorBox1);
            this.Controls.Add(this.selectedPatientId);
            this.Controls.Add(this.selectedDoctorId);
            this.Controls.Add(this.dataGridView2);
            this.Controls.Add(this.dataGridView1);
            this.Name = "PatientDoctorList";
            this.Text = "PatientDoctorList";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridView dataGridView2;
        private System.Windows.Forms.DataGridViewTextBoxColumn doctorId;
        private System.Windows.Forms.DataGridViewTextBoxColumn doctorName;
        private System.Windows.Forms.DataGridViewTextBoxColumn doctorSpecialization;
        private System.Windows.Forms.DataGridViewTextBoxColumn doctorExperience;
        private System.Windows.Forms.DataGridViewTextBoxColumn patientId;
        private System.Windows.Forms.DataGridViewTextBoxColumn patientName;
        private System.Windows.Forms.DataGridViewTextBoxColumn patientComplaints;
        private System.Windows.Forms.DataGridViewTextBoxColumn patientDiagnosis;
        private System.Windows.Forms.ComboBox selectedDoctorId;
        private System.Windows.Forms.ComboBox selectedPatientId;
        private System.Windows.Forms.TextBox doctorBox1;
        private System.Windows.Forms.TextBox patientBox2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button removeButton;
        private System.Windows.Forms.RadioButton doctorButton;
        private System.Windows.Forms.RadioButton patientButton;
        private System.Windows.Forms.ComboBox doctorParamether;
        private System.Windows.Forms.ComboBox newDoctorParamether;
        private System.Windows.Forms.TextBox doctorBox2;
        private System.Windows.Forms.TextBox doctorBox3;
        private System.Windows.Forms.ComboBox patientParamether;
        private System.Windows.Forms.ComboBox newPatientParamether;
        private System.Windows.Forms.TextBox patientBox1;
        private System.Windows.Forms.TextBox patientBox3;
        private System.Windows.Forms.Button editButton;
    }
}