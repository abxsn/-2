using BusinessLogic2;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp3
{
    public partial class PatientDoctorList : Form
    {
        ILogic logic;
        int num = 0;
        private void UpdateList()
        {
            dataGridView1.Rows.Clear();
            dataGridView2.Rows.Clear();
            List<string[]> doctorData = Program.DoctorStringData(logic.DoctorService.GetAll());
            List<string[]> patientData = Program.PatientStringData(logic.PatientService.GetAll());
            for (int i = 0; i < logic.DoctorService.Count; i++)
            {
                dataGridView1.Rows.Add(new string[] { doctorData[i][3], doctorData[i][0], doctorData[i][1], doctorData[i][2] });
            }
            for (int i = 0; i < logic.PatientService.Count; i++)
            {
                dataGridView2.Rows.Add(new string[] { patientData[i][3], patientData[i][0], patientData[i][1], patientData[i][2] });
            }
            
        }
        /// <summary>
        /// 
        /// </summary>
        /// <param name="logic">Бизнес логика</param>
        /// <param name="num">1 - Запись к врачу, 2 - Удаление, 3 - Редактирование</param>
        public PatientDoctorList(ILogic logic, int num)
        {
            InitializeComponent();
            this.num = num;
            this.logic = logic;
            UpdateList();
            selectedPatientId.DataSource = logic.PatientService.GetExistingIds();
            selectedDoctorId.DataSource = logic.DoctorService.GetExistingIds();
            doctorParamether.DataSource = doctorParams;
            patientParamether.DataSource = patientParams;
            switch(num)
            {
                case 1:
                    {
                        selectedDoctorId.Visible = true;
                        selectedPatientId.Visible = true;
                        doctorBox1.Visible = true;
                        patientBox2.Visible = true;
                        button1.Visible = true;
                        break;
                    }
                case 2:
                    {
                        doctorButton.Visible = true;
                        patientButton.Visible = true;
                        selectedDoctorId.Visible = true;
                        doctorBox1.Visible = true;
                        removeButton.Visible = true;
                        break;
                    }
                case 3:
                    {
                        editButton.Visible = true;
                        doctorButton.Visible = true;
                        patientButton.Visible = true;
                        selectedDoctorId.Visible = true;
                        doctorBox1.Visible = true;
                        doctorBox2.Visible = true;
                        doctorBox3.Visible = true;
                        doctorParamether.Visible = true;
                        newDoctorParamether.Visible = true;
                        break;
                    }
            }
        }

        private void dataGridView2_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            int.TryParse(selectedPatientId.Text, out int num1);
            int.TryParse(selectedDoctorId.Text, out int num2);
            MessageBox.Show(logic.AppointmentService.ArrangeAnAppointment(num1, num2));
            UpdateList();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            
            int.TryParse(selectedDoctorId.Text, out int num3);
            int.TryParse(selectedPatientId.Text, out int num4);
            if(doctorButton.Checked)
            {
                logic.DoctorService.RemoveDoctor(num3);
            }
            if(patientButton.Checked)
            {
                logic.PatientService.RemovePatient(num4);
            }
            UpdateList();
            selectedPatientId.DataSource = logic.PatientService.GetExistingIds();
            selectedDoctorId.DataSource = logic.DoctorService.GetExistingIds();

        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
            if(doctorButton.Checked)
            {
                selectedDoctorId.Visible = true;
                doctorBox1.Visible = true;
                if(num == 3)
                {
                    selectedDoctorId.Visible = true;
                    doctorBox1.Visible = true;
                    doctorBox2.Visible = true;
                    doctorBox3.Visible = true;
                    doctorParamether.Visible = true;
                    newDoctorParamether.Visible = true;
                }
            }
            else
            {
                selectedDoctorId.Visible = false;
                doctorBox1.Visible = false;
                if(num == 3)
                {
                    selectedDoctorId.Visible = false;
                    doctorBox1.Visible = false;
                    doctorBox2.Visible = false;
                    doctorBox3.Visible = false;
                    doctorParamether.Visible = false;
                    newDoctorParamether.Visible = false;
                }
            }

        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {
            if (patientButton.Checked)
            {
                selectedPatientId.Visible = true;
                patientBox2.Visible = true;
                if (num == 3)
                {
                    selectedPatientId.Visible = true;
                    patientBox1.Visible = true;
                    patientBox2.Visible = true;
                    patientBox3.Visible = true;
                    patientParamether.Visible = true;
                    newPatientParamether.Visible = true;
                }
            }
            else
            {
                selectedPatientId.Visible = false;
                patientBox2.Visible = false;
                if (num == 3)
                {
                    selectedPatientId.Visible = false;
                    patientBox1.Visible = false;
                    patientBox2.Visible = false;
                    patientBox3.Visible = false;
                    patientParamether.Visible = false;
                    newPatientParamether.Visible = false;
                }
            }
        }
        private void editButton_Click(object sender, EventArgs e)
        {
            if(doctorButton.Checked && logic.DoctorService.Count > 0)
            {
                int.TryParse(selectedDoctorId.Text, out int a);
                logic.DoctorService.DoctorRedactor(a, doctorParams.IndexOf(doctorParamether.Text), newDoctorParamether.Text);
            }
            else if(doctorButton.Checked == false && logic.PatientService.Count > 0)
            {
                int.TryParse(selectedPatientId.Text, out int a);
                logic.PatientService.PatientRedactor(a, patientParams.IndexOf(patientParamether.Text), newPatientParamether.Text);
            }
            else
            {
                MessageBox.Show("Недостаточное количество сущностей");
            }
            UpdateList();
        }

        private void doctorParamether_SelectedIndexChanged(object sender, EventArgs e)
        {
            newDoctorParamether.DropDownStyle = ComboBoxStyle.DropDownList;
            switch ((string)doctorParamether.SelectedItem)
            {
                case "Имя доктора":
                    {
                        newDoctorParamether.DropDownStyle = ComboBoxStyle.Simple;
                        newDoctorParamether.DataSource = new List<string> {"" };
                        break;
                    }
                case "Специализация":
                    {
                        newDoctorParamether.DataSource = Program.SpecializationsString();
                        break;
                    }
                case "Опыт доктора":
                    {
                        newDoctorParamether.DataSource = new List<string> { "0", "1", "2",  "3" , "4", "5"};
                        break;
                    }
            }
        }
        List<string> doctorParams = new List<string> { "Имя доктора", "Специализация", "Опыт доктора" };
        List<string> patientParams = new List<string> { "Имя пациента", "Жалобы" };

        private void patientParamether_SelectedIndexChanged(object sender, EventArgs e)
        {
            newPatientParamether.DropDownStyle = ComboBoxStyle.DropDownList;
            if ((string)patientParamether.SelectedItem == patientParams[1])
            {
                newPatientParamether.DataSource = Program.ComplaintsString();
            }
            else
            {
                newPatientParamether.DropDownStyle = ComboBoxStyle.Simple;
                newPatientParamether.DataSource = new List<string> { "" };
            }
        }
    }
}
