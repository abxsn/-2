namespace WindowsFormsApp3
{
    partial class Form1
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.addPatient = new System.Windows.Forms.Button();
            this.ArrangeAnAppointment1 = new System.Windows.Forms.Button();
            this.PatientRedact = new System.Windows.Forms.Button();
            this.PatientRemove = new System.Windows.Forms.Button();
            this.StartTreatment1 = new System.Windows.Forms.Button();
            this.PatientList = new System.Windows.Forms.Button();
            this.doctorAdd = new System.Windows.Forms.Button();
            this.DoctorRedact = new System.Windows.Forms.Button();
            this.DoctorRemove = new System.Windows.Forms.Button();
            this.DoctorList = new System.Windows.Forms.Button();
            this.logicBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.logicBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.logicBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.logicBindingSource1)).BeginInit();
            this.SuspendLayout();
            // 
            // addPatient
            // 
            this.addPatient.Location = new System.Drawing.Point(113, 61);
            this.addPatient.Name = "addPatient";
            this.addPatient.Size = new System.Drawing.Size(214, 39);
            this.addPatient.TabIndex = 0;
            this.addPatient.Text = "Добавить пациента";
            this.addPatient.UseVisualStyleBackColor = true;
            this.addPatient.Click += new System.EventHandler(this.button1_Click_1);
            // 
            // ArrangeAnAppointment1
            // 
            this.ArrangeAnAppointment1.Location = new System.Drawing.Point(113, 117);
            this.ArrangeAnAppointment1.Name = "ArrangeAnAppointment1";
            this.ArrangeAnAppointment1.Size = new System.Drawing.Size(214, 38);
            this.ArrangeAnAppointment1.TabIndex = 2;
            this.ArrangeAnAppointment1.Text = "Записать пациента к врачу (будет поставлен диагноз)";
            this.ArrangeAnAppointment1.UseVisualStyleBackColor = true;
            this.ArrangeAnAppointment1.Click += new System.EventHandler(this.button3_Click);
            // 
            // PatientRedact
            // 
            this.PatientRedact.Location = new System.Drawing.Point(113, 173);
            this.PatientRedact.Name = "PatientRedact";
            this.PatientRedact.Size = new System.Drawing.Size(214, 45);
            this.PatientRedact.TabIndex = 3;
            this.PatientRedact.Text = "Изменить информацию о пациенте ";
            this.PatientRedact.UseVisualStyleBackColor = true;
            this.PatientRedact.Click += new System.EventHandler(this.button4_Click);
            // 
            // PatientRemove
            // 
            this.PatientRemove.Location = new System.Drawing.Point(113, 242);
            this.PatientRemove.Name = "PatientRemove";
            this.PatientRemove.Size = new System.Drawing.Size(214, 23);
            this.PatientRemove.TabIndex = 4;
            this.PatientRemove.Text = "Выписать пациента";
            this.PatientRemove.UseVisualStyleBackColor = true;
            this.PatientRemove.Click += new System.EventHandler(this.button5_Click);
            // 
            // StartTreatment1
            // 
            this.StartTreatment1.Location = new System.Drawing.Point(113, 288);
            this.StartTreatment1.Name = "StartTreatment1";
            this.StartTreatment1.Size = new System.Drawing.Size(214, 38);
            this.StartTreatment1.TabIndex = 5;
            this.StartTreatment1.Text = "Начать лечение в порядке очереди Id пациента";
            this.StartTreatment1.UseVisualStyleBackColor = true;
            this.StartTreatment1.Click += new System.EventHandler(this.button6_Click);
            // 
            // PatientList
            // 
            this.PatientList.Location = new System.Drawing.Point(113, 344);
            this.PatientList.Name = "PatientList";
            this.PatientList.Size = new System.Drawing.Size(214, 41);
            this.PatientList.TabIndex = 6;
            this.PatientList.Text = "Просмотреть список пациентов";
            this.PatientList.UseVisualStyleBackColor = true;
            this.PatientList.Click += new System.EventHandler(this.button7_Click);
            // 
            // doctorAdd
            // 
            this.doctorAdd.Location = new System.Drawing.Point(347, 61);
            this.doctorAdd.Name = "doctorAdd";
            this.doctorAdd.Size = new System.Drawing.Size(214, 39);
            this.doctorAdd.TabIndex = 0;
            this.doctorAdd.Text = "Добавить врача в базу данных";
            this.doctorAdd.UseVisualStyleBackColor = true;
            this.doctorAdd.Click += new System.EventHandler(this.button2_Click);
            // 
            // DoctorRedact
            // 
            this.DoctorRedact.Location = new System.Drawing.Point(347, 173);
            this.DoctorRedact.Name = "DoctorRedact";
            this.DoctorRedact.Size = new System.Drawing.Size(214, 45);
            this.DoctorRedact.TabIndex = 3;
            this.DoctorRedact.Text = "Изменить информацию о враче";
            this.DoctorRedact.UseVisualStyleBackColor = true;
            this.DoctorRedact.Click += new System.EventHandler(this.button8_Click);
            // 
            // DoctorRemove
            // 
            this.DoctorRemove.Location = new System.Drawing.Point(347, 242);
            this.DoctorRemove.Name = "DoctorRemove";
            this.DoctorRemove.Size = new System.Drawing.Size(214, 23);
            this.DoctorRemove.TabIndex = 4;
            this.DoctorRemove.Text = "Уволить врача";
            this.DoctorRemove.UseVisualStyleBackColor = true;
            this.DoctorRemove.Click += new System.EventHandler(this.button9_Click);
            // 
            // DoctorList
            // 
            this.DoctorList.Location = new System.Drawing.Point(347, 344);
            this.DoctorList.Name = "DoctorList";
            this.DoctorList.Size = new System.Drawing.Size(214, 41);
            this.DoctorList.TabIndex = 6;
            this.DoctorList.Text = "Просмотреть список врачей";
            this.DoctorList.UseVisualStyleBackColor = true;
            this.DoctorList.Click += new System.EventHandler(this.button10_Click);
            // 
            // logicBindingSource
            // 
            this.logicBindingSource.DataSource = typeof(BusinessLogic2.Logic);
            // 
            // logicBindingSource1
            // 
            this.logicBindingSource1.DataSource = typeof(BusinessLogic2.Logic);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(946, 450);
            this.Controls.Add(this.DoctorList);
            this.Controls.Add(this.PatientList);
            this.Controls.Add(this.StartTreatment1);
            this.Controls.Add(this.DoctorRemove);
            this.Controls.Add(this.PatientRemove);
            this.Controls.Add(this.DoctorRedact);
            this.Controls.Add(this.PatientRedact);
            this.Controls.Add(this.ArrangeAnAppointment1);
            this.Controls.Add(this.doctorAdd);
            this.Controls.Add(this.addPatient);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load_1);
            ((System.ComponentModel.ISupportInitialize)(this.logicBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.logicBindingSource1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.BindingSource logicBindingSource;
        private System.Windows.Forms.BindingSource logicBindingSource1;
        private System.Windows.Forms.Button addPatient;
        private System.Windows.Forms.Button ArrangeAnAppointment1;
        private System.Windows.Forms.Button PatientRedact;
        private System.Windows.Forms.Button PatientRemove;
        private System.Windows.Forms.Button StartTreatment1;
        private System.Windows.Forms.Button PatientList;
        private System.Windows.Forms.Button doctorAdd;
        private System.Windows.Forms.Button DoctorRedact;
        private System.Windows.Forms.Button DoctorRemove;
        private System.Windows.Forms.Button DoctorList;
    }
}

