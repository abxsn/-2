using BusinessLogic2;
using Shared;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Presenter
{
    internal class PatientsListPresenter
    {
        IPatientService model;
        ITreatmentService service;
        IPatientsListView view;
        /// <summary>
        /// Презентер для показа пациентов
        /// </summary>
        /// <param name="model"></param>
        /// <param name="view"></param>
        /// <param name="service"></param>
        public PatientsListPresenter(IPatientService model, IPatientsListView view, ITreatmentService service)
        {
            this.model = model;
            this.view = view;
            model.DataChanged += _ => view.RedrawForm(model.GetAll().Select(s => new PatientEventArgs() { Id = s.Id, Name = s.Name, Complaints = s.Complaints, DiagnosisName = s.DiagnosisName }).ToList());
            service.DataChanged += _ => view.RedrawForm(model.GetAll().Select(s => new PatientEventArgs() { Id = s.Id, Name = s.Name, Complaints = s.Complaints, DiagnosisName = s.DiagnosisName }).ToList());
            view.RedrawForm(model.GetAll().Select(s => new PatientEventArgs() { Id = s.Id, Name = s.Name, Complaints = s.Complaints, DiagnosisName = s.DiagnosisName }).ToList());
        }
    }
}
