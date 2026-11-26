using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BusinessLogic2;

using Shared;

namespace Presenter
{
    internal class MainFormPresenter
    {
        private IDoctorService model1;
        private IPatientService model2;
        /// <summary>
        /// Презентер для главной формы
        /// </summary>
        /// <param name="mainForm"></param>
        /// <param name="model1"></param>
        /// <param name="model2"></param>
        public MainFormPresenter(IMainForm mainForm, IDoctorService model1, IPatientService model2)
        {
            this.model1 = model1;
            this.model2 = model2;
            mainForm.DoctorIds = model1.GetExistingIds();
            mainForm.PatientIds = model2.GetExistingIds();
        }
    }
}
