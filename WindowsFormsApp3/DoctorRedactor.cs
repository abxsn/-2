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
    public partial class DoctorRedactor : Form, IDoctorViewRedactor
    {

        public DoctorRedactor()
        {
            InitializeComponent();
        }
        int num = 0;
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
        private void doctorParamether_SelectedIndexChanged(object sender, EventArgs e)
        {
            newDoctorParamether.DropDownStyle = ComboBoxStyle.DropDownList;
            switch ((string)doctorParamether.SelectedItem)
            {
                case "Имя доктора":
                    {
                        newDoctorParamether.DropDownStyle = ComboBoxStyle.Simple;
                        newDoctorParamether.DataSource = new List<string> { "" };
                        break;
                    }
                case "Специализация":
                    {
                        newDoctorParamether.DataSource = Program.SpecializationsString();
                        break;
                    }
                case "Опыт доктора":
                    {
                        newDoctorParamether.DataSource = new List<string> { "0", "1", "2", "3", "4", "5" };
                        break;
                    }
            }
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
        public DoctorRedactor(ILogic logic, int num)
        {
            InitializeComponent();
            doctorParamether.DataSource = doctorParams;
            this.num = num;
        }
        List<string> doctorParams = new List<string> { "Имя доктора", "Специализация", "Опыт доктора" };

        public event Action<int, int, string> EditDataEvent;

        private void editButton_Click(object sender, EventArgs e)
        {

            if (selectedDoctorId.Items.Count > 0)
            {
                int.TryParse(selectedDoctorId.Text, out int a);
                EditDataEvent.Invoke(a, doctorParams.IndexOf(doctorParamether.Text), newDoctorParamether.Text);
            }
            else
            {
                MessageBox.Show("Недостаточное количество сущностей");
            }
        }
    }
}
