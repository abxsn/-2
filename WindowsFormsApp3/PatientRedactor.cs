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
    public partial class PatientRedactor : Form, IPatientViewRedactor
    {

        public void RedrawForm(IEnumerable<PatientEventArgs> e)
        {
            dataGridView2.Rows.Clear();
            List<string[]> patientData = Program.PatientEventArgsStringData(e);
            for (int i = 0; i < e.Count(); i++)
            {
                dataGridView2.Rows.Add(new string[] { patientData[i][3], patientData[i][0], patientData[i][1], patientData[i][2] });
            }
            selectedPatientId.DataSource = Program.PatientIdsEventArgs(e);
        }
        /// <summary>
        /// 
        /// </summary>
        /// <param name="logic">Бизнес логика</param>
        /// <param name="num">1 - Запись к врачу, 2 - Удаление, 3 - Редактирование</param>
        public PatientRedactor()
        {
            InitializeComponent();
            patientParamether.DataSource = patientParams;
        }
        private void editButton_Click(object sender, EventArgs e)
        {
            if (selectedPatientId.Items.Count > 0)
            {
                int.TryParse(selectedPatientId.Text, out int a);
                EditDataEvent.Invoke(a, patientParams.IndexOf(patientParamether.Text), newPatientParamether.Text);
            }
            else
            {
                MessageBox.Show("Недостаточное количество сущностей");
            }
        }
        List<string> patientParams = new List<string> { "Имя пациента", "Жалобы" };
        public event Action<int, int, string> EditDataEvent;

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

        public void ShowDialogView()
        {
            ShowDialog();
        }
    }
}
