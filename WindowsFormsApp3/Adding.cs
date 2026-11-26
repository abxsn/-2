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
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
using Shared;

namespace WindowsFormsApp3
{
    public partial class Adding : Form
    {
        ILogic logic;
        public Adding(ILogic logic)
        {
            this.logic = logic;
            InitializeComponent();
            MessageBox.Show("Подсказка для врача:\nДоступные категории и болезни для диагностики:\n- Общие симптомы (Хроническая усталость, Авитаминоз, Переутомление)\n- Органы дыхания (ОРВИ, Острый бронхит, Пневмония, Ангина)\n- Нервная система (Мигрень, ВСД, Невралгия)\n- Сердечно-сосудистая система (Гипертония, Стенокардия, Аритмия)\n- ЖКТ (Острый гастрит, Язва желудка, Панкреатит, Пищевое отравление)");
        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButton1.Checked)
            {
                doctorName.Visible = true;
                label1.Visible = true;
                label2.Visible = true;
                label3.Visible = true;
                doctorSpecializations.Visible = true;
                doctorSpecializations.DataSource = Program.SpecializationsString();
                doctorExperience.Visible = true;
                doctorExperience.DataSource = new List<int> { 0, 1, 2, 3, 4, 5 };
            }
            else
            {
                label1.Visible = false;
                label2.Visible = false;
                label3.Visible = false;
                doctorName.Visible = false;
                doctorSpecializations.Visible = false;
                doctorSpecializations.DataSource = Program.SpecializationsString();
                doctorExperience.Visible = false;
                doctorExperience.DataSource = new List<int> { 0, 1, 2, 3, 4, 5 };
            }
        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButton2.Checked)
            {
                label4.Visible = true;
                label5.Visible = true;
                patientName.Visible = true;
                patientComplaints.Visible = true;
                patientComplaints.DataSource = Program.ComplaintsString();
            }
            else
            {
                label4.Visible = false;
                label5.Visible = false;
                patientName.Visible = false;
                patientComplaints.Visible = false;
                patientComplaints.DataSource = Program.ComplaintsString();
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            
                if (radioButton1.Checked)
                {
                    logic.DoctorService.AddDoctor(doctorName.Text, MedicalCatalog.GetSpecializationId(doctorSpecializations.Text), (int)doctorExperience.SelectedItem);
                    MessageBox.Show("Добавлен врач");
                }
                else
                {
                    logic.PatientService.AddPatient(patientName.Text, MedicalCatalog.GetComplaintId(patientComplaints.Text));
                    MessageBox.Show("Добавлен пациент");
                }
        }

        private void doctorName_TextChanged(object sender, EventArgs e)
        {
        }
    }
}
