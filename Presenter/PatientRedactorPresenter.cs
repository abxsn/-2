using BusinessLogic2;
using Shared;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Presenter
{
    internal class PatientRedactorPresenter
    {
        private IPatientService model;
        /// <summary>
        /// Презентер для редактирования пациентов
        /// </summary>
        /// <param name="view"></param>
        /// <param name="model"></param>
        public PatientRedactorPresenter(IPatientViewRedactor view, IPatientService model)
        {
            this.model = model;
            view.EditDataEvent += model.PatientRedactor;
            model.DataChanged += _ => view.RedrawForm(model.GetAll().Select(s => new PatientEventArgs() { Id = s.Id, Name = s.Name, Complaints = s.Complaints, DiagnosisName = s.DiagnosisName }).ToList());
            view.RedrawForm(model.GetAll().Select(s => new PatientEventArgs() { Id = s.Id, Name = s.Name, Complaints = s.Complaints, DiagnosisName = s.DiagnosisName }).ToList());
        }
    }
}
