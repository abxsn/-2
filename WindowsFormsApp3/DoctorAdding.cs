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
using static System.Windows.Forms.VisualStyles.VisualStyleElement.Button;

namespace WindowsFormsApp3
{
    public partial class DoctorAdding : Form, IDoctorViewAdd
    {
        public DoctorAdding()
        {
            InitializeComponent();
            doctorName.Visible = true;
            label1.Visible = true;
            label2.Visible = true;
            label3.Visible = true;
            doctorSpecializations.Visible = true;
            doctorSpecializations.DataSource = Program.SpecializationsString();
            doctorExperience.Visible = true;
            doctorExperience.DataSource = new List<int> { 0, 1, 2, 3, 4, 5 };
            MessageBox.Show("Подсказка для врача:\nДоступные категории и болезни для диагностики:\n- Общие симптомы (Хроническая усталость, Авитаминоз, Переутомление)\n- Органы дыхания (ОРВИ, Острый бронхит, Пневмония, Ангина)\n- Нервная система (Мигрень, ВСД, Невралгия)\n- Сердечно-сосудистая система (Гипертония, Стенокардия, Аритмия)\n- ЖКТ (Острый гастрит, Язва желудка, Панкреатит, Пищевое отравление)");
        }
        public void ShowDialogView()
        {
            ShowDialog();
        }

        public event Action<DoctorEventArgs> AddDataEvent;

        private void button1_Click(object sender, EventArgs e)
        {
            AddDataEvent.Invoke(new DoctorEventArgs { Name = doctorName.Text, Specialization = doctorSpecializations.Text, ExperienceYears = (int)doctorExperience.SelectedItem });
            MessageBox.Show("Добавлен врач");
        }
    }
}
