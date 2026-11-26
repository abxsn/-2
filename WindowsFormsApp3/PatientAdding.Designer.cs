namespace WindowsFormsApp3
{
    partial class PatientAdding
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
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.patientName = new System.Windows.Forms.TextBox();
            this.patientComplaints = new System.Windows.Forms.ComboBox();
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
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(369, 130);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(50, 13);
            this.label5.TabIndex = 15;
            this.label5.Text = "Жалобы";
            this.label5.Visible = false;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(226, 130);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(29, 13);
            this.label4.TabIndex = 16;
            this.label4.Text = "Имя";
            this.label4.Visible = false;
            // 
            // patientName
            // 
            this.patientName.Location = new System.Drawing.Point(229, 146);
            this.patientName.Name = "patientName";
            this.patientName.Size = new System.Drawing.Size(137, 20);
            this.patientName.TabIndex = 13;
            this.patientName.Visible = false;
            // 
            // patientComplaints
            // 
            this.patientComplaints.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.patientComplaints.FormattingEnabled = true;
            this.patientComplaints.Location = new System.Drawing.Point(372, 145);
            this.patientComplaints.Name = "patientComplaints";
            this.patientComplaints.Size = new System.Drawing.Size(201, 21);
            this.patientComplaints.TabIndex = 10;
            this.patientComplaints.Visible = false;
            // 
            // PatientAdding
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.AddingButton);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.patientName);
            this.Controls.Add(this.patientComplaints);
            this.Name = "PatientAdding";
            this.Text = "PatientAdding";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button AddingButton;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox patientName;
        private System.Windows.Forms.ComboBox patientComplaints;
    }
}