namespace WindowsFormsApp3
{
    partial class DoctorAdding
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
            this.AddingButton = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.doctorName = new System.Windows.Forms.TextBox();
            this.doctorSpecializations = new System.Windows.Forms.ComboBox();
            this.doctorExperience = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // AddingButton
            // 
            this.AddingButton.Location = new System.Drawing.Point(409, 322);
            this.AddingButton.Name = "AddingButton";
            this.AddingButton.Size = new System.Drawing.Size(133, 49);
            this.AddingButton.TabIndex = 20;
            this.AddingButton.Text = "Добавить в базу";
            this.AddingButton.UseVisualStyleBackColor = true;
            this.AddingButton.Click += new System.EventHandler(this.button1_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(226, 80);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(29, 13);
            this.label3.TabIndex = 17;
            this.label3.Text = "Имя";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(369, 80);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(86, 13);
            this.label2.TabIndex = 18;
            this.label2.Text = "Специализация";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(527, 80);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(74, 13);
            this.label1.TabIndex = 19;
            this.label1.Text = "Опыт работы";
            // 
            // doctorName
            // 
            this.doctorName.Location = new System.Drawing.Point(229, 99);
            this.doctorName.Name = "doctorName";
            this.doctorName.Size = new System.Drawing.Size(137, 20);
            this.doctorName.TabIndex = 14;
            // 
            // doctorSpecializations
            // 
            this.doctorSpecializations.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.doctorSpecializations.FormattingEnabled = true;
            this.doctorSpecializations.Location = new System.Drawing.Point(372, 99);
            this.doctorSpecializations.Name = "doctorSpecializations";
            this.doctorSpecializations.Size = new System.Drawing.Size(149, 21);
            this.doctorSpecializations.TabIndex = 12;
            this.doctorSpecializations.Visible = false;
            // 
            // doctorExperience
            // 
            this.doctorExperience.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.doctorExperience.FormattingEnabled = true;
            this.doctorExperience.Location = new System.Drawing.Point(527, 99);
            this.doctorExperience.Name = "doctorExperience";
            this.doctorExperience.Size = new System.Drawing.Size(139, 21);
            this.doctorExperience.TabIndex = 11;
            this.doctorExperience.Visible = false;
            // 
            // DoctorAdding
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.AddingButton);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.doctorName);
            this.Controls.Add(this.doctorSpecializations);
            this.Controls.Add(this.doctorExperience);
            this.Name = "DoctorAdding";
            this.Text = "DoctorAdding";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button AddingButton;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox doctorName;
        private System.Windows.Forms.ComboBox doctorSpecializations;
        private System.Windows.Forms.ComboBox doctorExperience;
    }
}