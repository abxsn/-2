using BusinessLogic2;
using Shared;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Presenter
{
    internal class PatientAddPresenter
    {
        private IPatientService model;
        /// <summary>
        /// Презентер для добавления пациентов
        /// </summary>
        /// <param name="view"></param>
        /// <param name="model"></param>
        public PatientAddPresenter(IPatientViewAdd view, IPatientService model)
        {
            this.model = model;
            view.AddDataEvent += OnAddData;
        }
        /// <summary>
        /// Подписчик AddDataEvent во view
        /// </summary>
        /// <param name="patient"></param>
        private void OnAddData(PatientEventArgs patient)
        {
            model.AddPatient(patient.Name, MedicalCatalog.GetComplaintId(patient.Complaints));
        }
    }
}
