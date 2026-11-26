namespace WindowsFormsApp3
{
    partial class Appointment
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
            this.button1 = new System.Windows.Forms.Button();
            this.patientBox2 = new System.Windows.Forms.TextBox();
            this.selectedPatientId = new System.Windows.Forms.ComboBox();
            this.selectedDoctorId = new System.Windows.Forms.ComboBox();
            this.patientDiagnosis = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.patientComplaints = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.patientName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.patientId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridView2 = new System.Windows.Forms.DataGridView();
            this.doctorExperience = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.doctorSpecialization = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.doctorName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.doctorId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.doctorBox1 = new System.Windows.Forms.TextBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(479, 322);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(123, 36);
            this.button1.TabIndex = 16;
            this.button1.Text = "Заставить врача поставить дигноз";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // patientBox2
            // 
            this.patientBox2.Location = new System.Drawing.Point(589, 219);
            this.patientBox2.Name = "patientBox2";
            this.patientBox2.Size = new System.Drawing.Size(100, 20);
            this.patientBox2.TabIndex = 14;
            this.patientBox2.Text = "Id пациента";
            // 
            // selectedPatientId
            // 
            this.selectedPatientId.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.selectedPatientId.FormattingEnabled = true;
            this.selectedPatientId.Location = new System.Drawing.Point(589, 257);
            this.selectedPatientId.Name = "selectedPatientId";
            this.selectedPatientId.Size = new System.Drawing.Size(121, 21);
            this.selectedPatientId.TabIndex = 13;
            // 
            // selectedDoctorId
            // 
            this.selectedDoctorId.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.selectedDoctorId.FormattingEnabled = true;
            this.selectedDoctorId.Location = new System.Drawing.Point(381, 257);
            this.selectedDoctorId.Name = "selectedDoctorId";
            this.selectedDoctorId.Size = new System.Drawing.Size(121, 21);
            this.selectedDoctorId.TabIndex = 12;
            // 
            // patientDiagnosis
            // 
            this.patientDiagnosis.HeaderText = "Диагноз (Врача)";
            this.patientDiagnosis.Name = "patientDiagnosis";
            this.patientDiagnosis.ReadOnly = true;
            // 
            // patientComplaints
            // 
            this.patientComplaints.HeaderText = "Жалобы";
            this.patientComplaints.Name = "patientComplaints";
            this.patientComplaints.ReadOnly = true;
            // 
            // patientName
            // 
            this.patientName.HeaderText = "Пациент";
            this.patientName.Name = "patientName";
            this.patientName.ReadOnly = true;
            // 
            // patientId
            // 
            this.patientId.HeaderText = "id";
            this.patientId.Name = "patientId";
            this.patientId.ReadOnly = true;
            // 
            // dataGridView2
            // 
            this.dataGridView2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView2.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.patientId,
            this.patientName,
            this.patientComplaints,
            this.patientDiagnosis});
            this.dataGridView2.Location = new System.Drawing.Point(589, 23);
            this.dataGridView2.Name = "dataGridView2";
            this.dataGridView2.Size = new System.Drawing.Size(442, 150);
            this.dataGridView2.TabIndex = 11;
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
            this.doctorBox1.Location = new System.Drawing.Point(402, 219);
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
            this.dataGridView1.Location = new System.Drawing.Point(57, 23);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(443, 150);
            this.dataGridView1.TabIndex = 10;
            // 
            // Appointment
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1043, 483);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.patientBox2);
            this.Controls.Add(this.selectedPatientId);
            this.Controls.Add(this.selectedDoctorId);
            this.Controls.Add(this.dataGridView2);
            this.Controls.Add(this.doctorBox1);
            this.Controls.Add(this.dataGridView1);
            this.Name = "Appointment";
            this.Text = "Appointment";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox patientBox2;
        private System.Windows.Forms.ComboBox selectedPatientId;
        private System.Windows.Forms.ComboBox selectedDoctorId;
        private System.Windows.Forms.DataGridViewTextBoxColumn patientDiagnosis;
        private System.Windows.Forms.DataGridViewTextBoxColumn patientComplaints;
        private System.Windows.Forms.DataGridViewTextBoxColumn patientName;
        private System.Windows.Forms.DataGridViewTextBoxColumn patientId;
        private System.Windows.Forms.DataGridView dataGridView2;
        private System.Windows.Forms.DataGridViewTextBoxColumn doctorExperience;
        private System.Windows.Forms.DataGridViewTextBoxColumn doctorSpecialization;
        private System.Windows.Forms.DataGridViewTextBoxColumn doctorName;
        private System.Windows.Forms.DataGridViewTextBoxColumn doctorId;
        private System.Windows.Forms.TextBox doctorBox1;
        private System.Windows.Forms.DataGridView dataGridView1;
    }
}