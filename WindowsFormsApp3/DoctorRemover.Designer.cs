namespace WindowsFormsApp3
{
    partial class DoctorRemover
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
            this.selectedDoctorId = new System.Windows.Forms.ComboBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.doctorId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.doctorName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.doctorSpecialization = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.doctorExperience = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.doctorBox1 = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // editButton
            // 
            this.editButton.Location = new System.Drawing.Point(449, 360);
            this.editButton.Name = "editButton";
            this.editButton.Size = new System.Drawing.Size(131, 46);
            this.editButton.TabIndex = 36;
            this.editButton.Text = "Уничтожить выбранного человека";
            this.editButton.UseVisualStyleBackColor = true;
            this.editButton.Click += new System.EventHandler(this.button2_Click);
            // 
            // selectedDoctorId
            // 
            this.selectedDoctorId.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.selectedDoctorId.FormattingEnabled = true;
            this.selectedDoctorId.Location = new System.Drawing.Point(459, 290);
            this.selectedDoctorId.Name = "selectedDoctorId";
            this.selectedDoctorId.Size = new System.Drawing.Size(121, 21);
            this.selectedDoctorId.TabIndex = 30;
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.doctorId,
            this.doctorName,
            this.doctorSpecialization,
            this.doctorExperience});
            this.dataGridView1.Location = new System.Drawing.Point(310, 60);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(443, 150);
            this.dataGridView1.TabIndex = 29;
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
            // doctorBox1
            // 
            this.doctorBox1.Location = new System.Drawing.Point(480, 252);
            this.doctorBox1.Name = "doctorBox1";
            this.doctorBox1.Size = new System.Drawing.Size(100, 20);
            this.doctorBox1.TabIndex = 31;
            this.doctorBox1.Text = "Id врача";
            // 
            // DoctorRemover
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1023, 473);
            this.Controls.Add(this.editButton);
            this.Controls.Add(this.selectedDoctorId);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.doctorBox1);
            this.Name = "DoctorRemover";
            this.Text = "DoctorRemover";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button editButton;
        private System.Windows.Forms.ComboBox selectedDoctorId;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridViewTextBoxColumn doctorId;
        private System.Windows.Forms.DataGridViewTextBoxColumn doctorName;
        private System.Windows.Forms.DataGridViewTextBoxColumn doctorSpecialization;
        private System.Windows.Forms.DataGridViewTextBoxColumn doctorExperience;
        private System.Windows.Forms.TextBox doctorBox1;
    }
}