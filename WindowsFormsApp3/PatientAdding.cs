using BusinessLogic2;
using Entities;
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
    public partial class PatientAdding : Form, IPatientViewAdd
    {
        public PatientAdding()
        {
            InitializeComponent();
            label4.Visible = true;
            label5.Visible = true;
            patientName.Visible = true;
            patientComplaints.Visible = true;
            patientComplaints.DataSource = Program.ComplaintsString();
            MessageBox.Show("Подсказка для врача:\nДоступные категории и болезни для диагностики:\n- Общие симптомы (Хроническая усталость, Авитаминоз, Переутомление)\n- Органы дыхания (ОРВИ, Острый бронхит, Пневмония, Ангина)\n- Нервная система (Мигрень, ВСД, Невралгия)\n- Сердечно-сосудистая система (Гипертония, Стенокардия, Аритмия)\n- ЖКТ (Острый гастрит, Язва желудка, Панкреатит, Пищевое отравление)");
        }
        public void ShowDialogView()
        {
            ShowDialog();
        }

        public event Action<PatientEventArgs> AddDataEvent;
        private void button1_Click(object sender, EventArgs e)
        {
            AddDataEvent.Invoke(new PatientEventArgs { Name = patientName.Text, Complaints = patientComplaints.Text});
            MessageBox.Show("Добавлен пациент");
        }
    }
}
