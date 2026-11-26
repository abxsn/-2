using BusinessLogic2;
using Shared;
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
    public partial class Appointment : Form, IAppointmentView
    {
        
        public Appointment()
        {
            InitializeComponent();
        }
        public void RedrawForm(IEnumerable<PatientEventArgs> e, IEnumerable<DoctorEventArgs> e1)
        {
            dataGridView2.Rows.Clear();
            List<string[]> patientData = Program.PatientEventArgsStringData(e);
            for (int i = 0; i < e.Count(); i++)
            {
                dataGridView2.Rows.Add(new string[] { patientData[i][3], patientData[i][0], patientData[i][1], patientData[i][2] });
            }
            dataGridView1.Rows.Clear();
            List<string[]> doctorData = Program.DoctorEventArgsStringData(e1);
            for (int i = 0; i < e1.Count(); i++)
            {
                dataGridView1.Rows.Add(new string[] { doctorData[i][3], doctorData[i][0], doctorData[i][1], doctorData[i][2] });
            }
            selectedDoctorId.DataSource = Program.DoctorIdsEventArgs(e1);
            selectedPatientId.DataSource = Program.PatientIdsEventArgs(e);

        }
        public void ShowDialogView()
        {
            ShowDialog();
        }
        /// <summary>
        /// 
        /// </summary>
        /// <param name="logic">Бизнес логика</param>
        /// <param name="num">1 - Запись к врачу, 2 - Удаление, 3 - Редактирование</param>
        private void button1_Click(object sender, EventArgs e)
        {
            int.TryParse(selectedPatientId.Text, out int num1);
            int.TryParse(selectedDoctorId.Text, out int num2);
            MessageBox.Show(ArrangeAnAppointmentEvent.Invoke(num1, num2));
        }
        public event Appoint ArrangeAnAppointmentEvent;
    }
}
