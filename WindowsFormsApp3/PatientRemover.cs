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
    public partial class PatientRemover : Form, IPatientViewRemove
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

        private void button2_Click(object sender, EventArgs e)
        {
            int.TryParse(selectedPatientId.Text, out int num4);
            RemoveDataEvent.Invoke(num4);
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
        public PatientRemover()
        {
            InitializeComponent();
        }

        public event Action<int> RemoveDataEvent;

        private void PatientRemover_Load(object sender, EventArgs e)
        {

        }
    }
}
