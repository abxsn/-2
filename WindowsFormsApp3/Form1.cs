using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Shared;

namespace WindowsFormsApp3
{
    public partial class Form1 : Form, IMainForm
    {
        public List<int> DoctorIds { get; set; }

        public List<int> PatientIds { get; set; }

        public Form1()
        {
            MessageBox.Show("\"Если пациенту не поставить правильный диагноз, он будет страдать и в итоге умрет.\nЗа каждым пациентом закрепляется строго один врач (но один врач может вести много пациентов), а диагноз ставится правильно, если специализация врача подходит жалобам пациента и его опыта достаточно для определения болезни.\")");
            InitializeComponent();
        }

        public event Action ArrangeAnAppointment;

        public event Action StartTreatment;

        public event Action AddPatient;
        public event Action RemovePatient;
        public event Action RedactPatient;
        public event Action AddDoctor;
        public event Action RemoveDoctor;
        public event Action RedactDoctor;
        public event Action OpenPatientList;
        public event Action OpenDoctorList;

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void Form1_Load_1(object sender, EventArgs e)
        {
            
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            AddPatient.Invoke();
        }

        private void button7_Click(object sender, EventArgs e)
        {
            OpenPatientList.Invoke();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            if(DoctorIds.Count > 0 && PatientIds.Count > 0)
            {
                StartTreatment.Invoke();
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (DoctorIds.Count > 0 && PatientIds.Count > 0)
            {
                ArrangeAnAppointment.Invoke();
            }
            else
            {
                MessageBox.Show("Недостаточно врачей или пациентов");
            }
        }

        private void button5_Click(object sender, EventArgs e)
        {
            if (PatientIds.Count > 0)
            {
                RemovePatient.Invoke();
            }
            else
            {
                MessageBox.Show("Недостаточно пациентов");
            }
}

        private void button4_Click(object sender, EventArgs e)
        {
            if (PatientIds.Count > 0)
            {
                RedactPatient.Invoke();
            }
            else
            {
                MessageBox.Show("Недостаточно пациентов");
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            AddDoctor.Invoke();
        }

        private void button8_Click(object sender, EventArgs e)
        {
            if (DoctorIds.Count > 0)
            {
                RedactDoctor.Invoke();
            }
            else
            {
                MessageBox.Show("Недостаточно врачей");
            }
        }

        private void button10_Click(object sender, EventArgs e)
        {
            OpenDoctorList.Invoke();
        }

        private void button9_Click(object sender, EventArgs e)
        {
            if(DoctorIds.Count > 0)
            {
                RemoveDoctor.Invoke();
            }
            else
            {
                MessageBox.Show("Недостаточно врачей");
            }
        }
    }
}
