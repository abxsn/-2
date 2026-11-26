namespace WindowsFormsApp3
{
    partial class Adding
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Adding));
            this.radioButton1 = new System.Windows.Forms.RadioButton();
            this.radioButton2 = new System.Windows.Forms.RadioButton();
            this.doctorSpecializations = new System.Windows.Forms.ComboBox();
            this.doctorExperience = new System.Windows.Forms.ComboBox();
            this.doctorName = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.patientComplaints = new System.Windows.Forms.ComboBox();
            this.patientName = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.AddingButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // radioButton1
            // 
            this.radioButton1.AutoSize = true;
            this.radioButton1.Location = new System.Drawing.Point(151, 118);
            this.radioButton1.Name = "radioButton1";
            this.radioButton1.Size = new System.Drawing.Size(63, 17);
            this.radioButton1.TabIndex = 1;
            this.radioButton1.TabStop = true;
            this.radioButton1.Text = "Доктор";
            this.radioButton1.UseVisualStyleBackColor = true;
            this.radioButton1.CheckedChanged += new System.EventHandler(this.radioButton1_CheckedChanged);
            // 
            // radioButton2
            // 
            this.radioButton2.AutoSize = true;
            this.radioButton2.Location = new System.Drawing.Point(149, 164);
            this.radioButton2.Name = "radioButton2";
            this.radioButton2.Size = new System.Drawing.Size(68, 17);
            this.radioButton2.TabIndex = 2;
            this.radioButton2.TabStop = true;
            this.radioButton2.Text = "Пациент";
            this.radioButton2.UseVisualStyleBackColor = true;
            this.radioButton2.CheckedChanged += new System.EventHandler(this.radioButton2_CheckedChanged);
            // 
            // doctorSpecializations
            // 
            this.doctorSpecializations.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.doctorSpecializations.FormattingEnabled = true;
            this.doctorSpecializations.Location = new System.Drawing.Point(387, 118);
            this.doctorSpecializations.Name = "doctorSpecializations";
            this.doctorSpecializations.Size = new System.Drawing.Size(149, 21);
            this.doctorSpecializations.TabIndex = 4;
            this.doctorSpecializations.Visible = false;
            // 
            // doctorExperience
            // 
            this.doctorExperience.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.doctorExperience.FormattingEnabled = true;
            this.doctorExperience.Location = new System.Drawing.Point(542, 118);
            this.doctorExperience.Name = "doctorExperience";
            this.doctorExperience.Size = new System.Drawing.Size(139, 21);
            this.doctorExperience.TabIndex = 3;
            this.doctorExperience.Visible = false;
            // 
            // doctorName
            // 
            this.doctorName.Location = new System.Drawing.Point(244, 118);
            this.doctorName.Name = "doctorName";
            this.doctorName.Size = new System.Drawing.Size(137, 20);
            this.doctorName.TabIndex = 5;
            this.doctorName.TextChanged += new System.EventHandler(this.doctorName_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(542, 99);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(74, 13);
            this.label1.TabIndex = 6;
            this.label1.Text = "Опыт работы";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(384, 99);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(86, 13);
            this.label2.TabIndex = 6;
            this.label2.Text = "Специализация";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(241, 99);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(29, 13);
            this.label3.TabIndex = 6;
            this.label3.Text = "Имя";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(241, 149);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(29, 13);
            this.label4.TabIndex = 6;
            this.label4.Text = "Имя";
            this.label4.Visible = false;
            // 
            // patientComplaints
            // 
            this.patientComplaints.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.patientComplaints.FormattingEnabled = true;
            this.patientComplaints.Location = new System.Drawing.Point(387, 164);
            this.patientComplaints.Name = "patientComplaints";
            this.patientComplaints.Size = new System.Drawing.Size(201, 21);
            this.patientComplaints.TabIndex = 3;
            this.patientComplaints.Visible = false;
            // 
            // patientName
            // 
            this.patientName.Location = new System.Drawing.Point(244, 165);
            this.patientName.Name = "patientName";
            this.patientName.Size = new System.Drawing.Size(137, 20);
            this.patientName.TabIndex = 5;
            this.patientName.Visible = false;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(384, 149);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(50, 13);
            this.label5.TabIndex = 6;
            this.label5.Text = "Жалобы";
            this.label5.Visible = false;
            // 
            // AddingButton
            // 
            this.AddingButton.Location = new System.Drawing.Point(424, 341);
            this.AddingButton.Name = "AddingButton";
            this.AddingButton.Size = new System.Drawing.Size(133, 49);
            this.AddingButton.TabIndex = 7;
            this.AddingButton.Text = "Добавить в базу";
            this.AddingButton.UseVisualStyleBackColor = true;
            this.AddingButton.Click += new System.EventHandler(this.button1_Click);
            // 
            // Adding
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.AddingButton);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.patientName);
            this.Controls.Add(this.doctorName);
            this.Controls.Add(this.doctorSpecializations);
            this.Controls.Add(this.patientComplaints);
            this.Controls.Add(this.doctorExperience);
            this.Controls.Add(this.radioButton2);
            this.Controls.Add(this.radioButton1);
            this.Name = "Adding";
            this.Text = "Adding";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.RadioButton radioButton1;
        private System.Windows.Forms.RadioButton radioButton2;
        private System.Windows.Forms.ComboBox doctorSpecializations;
        private System.Windows.Forms.ComboBox doctorExperience;
        private System.Windows.Forms.TextBox doctorName;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox patientComplaints;
        private System.Windows.Forms.TextBox patientName;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button AddingButton;
    }
}