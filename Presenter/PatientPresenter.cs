using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BusinessLogic2;
using Entities;
using Shared;
namespace Presenter
{
    internal class PatientPresenter
    {
        private IPatientService model;
        /// <summary>
        /// Презентер для пациентов
        /// </summary>
        /// <param name="view"></param>
        /// <param name="model"></param>
        public PatientPresenter(IPatientViewRedraw view, IPatientService model)
        {
            this.model = model;
        }
    }
}
