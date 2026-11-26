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
    public partial class DoctorListForm : Form, IDoctorsListView
    {
        public DoctorListForm()
        {
            InitializeComponent();
        }
        public void RedrawForm(IEnumerable<DoctorEventArgs> e)
        {
            dataGridView1.Rows.Clear();
            List<string[]> doctorData = Program.DoctorEventArgsStringData(e);
            for (int i = 0; i < e.Count(); i++)
            {
                dataGridView1.Rows.Add(new string[] { doctorData[i][3], doctorData[i][0], doctorData[i][1], doctorData[i][2] });
            }
        }

        public void ShowDialogView()
        {
            ShowDialog();
        }
    }
}
