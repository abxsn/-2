namespace WindowsFormsApp3
{
    partial class PatientRemover
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
            this.removeButton = new System.Windows.Forms.Button();
            this.patientBox2 = new System.Windows.Forms.TextBox();
            this.selectedPatientId = new System.Windows.Forms.ComboBox();
            this.patientDiagnosis = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.patientComplaints = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.patientName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.patientId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridView2 = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).BeginInit();
            this.SuspendLayout();
            // 
            // removeButton
            // 
            this.removeButton.Location = new System.Drawing.Point(428, 341);
            this.removeButton.Name = "removeButton";
            this.removeButton.Size = new System.Drawing.Size(189, 48);
            this.removeButton.TabIndex = 17;
            this.removeButton.Text = "Уничтожить выбранного человека";
            this.removeButton.UseVisualStyleBackColor = true;
            this.removeButton.Click += new System.EventHandler(this.button2_Click);
            // 
            // patientBox2
            // 
            this.patientBox2.Location = new System.Drawing.Point(465, 245);
            this.patientBox2.Name = "patientBox2";
            this.patientBox2.Size = new System.Drawing.Size(100, 20);
            this.patientBox2.TabIndex = 14;
            this.patientBox2.Text = "Id пациента";
            // 
            // selectedPatientId
            // 
            this.selectedPatientId.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.selectedPatientId.FormattingEnabled = true;
            this.selectedPatientId.Location = new System.Drawing.Point(453, 282);
            this.selectedPatientId.Name = "selectedPatientId";
            this.selectedPatientId.Size = new System.Drawing.Size(121, 21);
            this.selectedPatientId.TabIndex = 13;
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
            this.dataGridView2.Location = new System.Drawing.Point(307, 47);
            this.dataGridView2.Name = "dataGridView2";
            this.dataGridView2.Size = new System.Drawing.Size(442, 150);
            this.dataGridView2.TabIndex = 11;
            // 
            // PatientRemover
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1028, 519);
            this.Controls.Add(this.removeButton);
            this.Controls.Add(this.patientBox2);
            this.Controls.Add(this.selectedPatientId);
            this.Controls.Add(this.dataGridView2);
            this.Name = "PatientRemover";
            this.Text = "PatientRemover";
            this.Load += new System.EventHandler(this.PatientRemover_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button removeButton;
        private System.Windows.Forms.TextBox patientBox2;
        private System.Windows.Forms.ComboBox selectedPatientId;
        private System.Windows.Forms.DataGridViewTextBoxColumn patientDiagnosis;
        private System.Windows.Forms.DataGridViewTextBoxColumn patientComplaints;
        private System.Windows.Forms.DataGridViewTextBoxColumn patientName;
        private System.Windows.Forms.DataGridViewTextBoxColumn patientId;
        private System.Windows.Forms.DataGridView dataGridView2;
    }
}