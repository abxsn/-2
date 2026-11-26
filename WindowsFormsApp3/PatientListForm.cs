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
    public partial class PatientListForm : Form, IPatientsListView, IPatientViewRedraw
    {
        public PatientListForm()
        {
            InitializeComponent();
        }
        public void ShowDialogView()
        {
            ShowDialog();
        }
        public void RedrawForm(IEnumerable<PatientEventArgs> Patients)
        {
            dataGridView2.Rows.Clear();
            if (Patients == null) return;
            List<string[]> patientData = Program.PatientEventArgsStringData(Patients);
            for (int i = 0; i < Patients.Count(); i++)
            {
                dataGridView2.Rows.Add(new string[] { patientData[i][3], patientData[i][0], patientData[i][1], patientData[i][2] });
            }
        }
    }
}
