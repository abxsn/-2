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
    public partial class TreatmentForm : Form, ITreatmentView
    {
        public TreatmentForm()
        {
            InitializeComponent();
        }
        public void ShowDialogView()
        {
            MessageBox.Show(TreatmentRequired?.Invoke());
        }
        public event Func<string> TreatmentRequired;
    }
}
