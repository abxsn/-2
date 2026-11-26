namespace WindowsFormsApp3
{
    partial class PatientListForm
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
            this.dataGridView2 = new System.Windows.Forms.DataGridView();
            this.patientId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.patientName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.patientComplaints = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.patientDiagnosis = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView2
            // 
            this.dataGridView2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView2.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.patientId,
            this.patientName,
            this.patientComplaints,
            this.patientDiagnosis});
            this.dataGridView2.Location = new System.Drawing.Point(179, 150);
            this.dataGridView2.Name = "dataGridView2";
            this.dataGridView2.Size = new System.Drawing.Size(442, 150);
            this.dataGridView2.TabIndex = 12;
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
            // PatientListForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.dataGridView2);
            this.Name = "PatientListForm";
            this.Text = "PatientListForm";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView2;
        private System.Windows.Forms.DataGridViewTextBoxColumn patientId;
        private System.Windows.Forms.DataGridViewTextBoxColumn patientName;
        private System.Windows.Forms.DataGridViewTextBoxColumn patientComplaints;
        private System.Windows.Forms.DataGridViewTextBoxColumn patientDiagnosis;
    }
}