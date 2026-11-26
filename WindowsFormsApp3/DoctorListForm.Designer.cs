namespace WindowsFormsApp3
{
    partial class DoctorListForm
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
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.doctorId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.doctorName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.doctorSpecialization = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.doctorExperience = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
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
            this.dataGridView1.Location = new System.Drawing.Point(179, 150);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(443, 150);
            this.dataGridView1.TabIndex = 11;
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
            // DoctorListForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.dataGridView1);
            this.Name = "DoctorListForm";
            this.Text = "DoctorListForm";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridViewTextBoxColumn doctorId;
        private System.Windows.Forms.DataGridViewTextBoxColumn doctorName;
        private System.Windows.Forms.DataGridViewTextBoxColumn doctorSpecialization;
        private System.Windows.Forms.DataGridViewTextBoxColumn doctorExperience;
    }
}