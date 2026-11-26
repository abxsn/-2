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
    public partial class DoctorRemover : Form, IDoctorViewRemove
    {

        public void RedrawForm(IEnumerable<DoctorEventArgs> e)
        {
            dataGridView1.Rows.Clear();
            List<string[]> doctorData = Program.DoctorEventArgsStringData(e);
            for (int i = 0; i < e.Count(); i++)
            {
                dataGridView1.Rows.Add(new string[] { doctorData[i][3], doctorData[i][0], doctorData[i][1], doctorData[i][2] });
            }
            selectedDoctorId.DataSource = Program.DoctorIdsEventArgs(e);

        }
        public void ShowDialogView()
        {
            ShowDialog();
        }
        private void button2_Click(object sender, EventArgs e)
        {

            int.TryParse(selectedDoctorId.Text, out int num3);
            RemoveDataEvent?.Invoke(num3);

        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="logic">Бизнес логика</param>
        /// <param name="num">1 - Запись к врачу, 2 - Удаление, 3 - Редактирование</param>
        public DoctorRemover()
        {
            InitializeComponent();
        }
        public event Action<int> RemoveDataEvent;
    }
}
