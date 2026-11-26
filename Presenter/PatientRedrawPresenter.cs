using BusinessLogic2;
using Shared;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Presenter
{
    internal class PatientRedrawPresenter
    {
        private IPatientService model;
        /// <summary>
        /// Презентер для обновления пациентов
        /// </summary>
        /// <param name="view"></param>
        /// <param name="model"></param>
        public PatientRedrawPresenter(IPatientViewRedraw view, IPatientService model)
        {
            this.model = model;
            model.DataChanged += view.RedrawForm;
        }
    }
}
