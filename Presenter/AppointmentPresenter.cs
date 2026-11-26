using BusinessLogic2;
using Shared;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Presenter
{
    internal class AppointmentPresenter
    {
        private IAppointmentService model;
        /// <summary>
        /// Презентер для IAppointmentView
        /// </summary>
        /// <param name="view"></param>
        /// <param name="model"></param>
        public AppointmentPresenter(IAppointmentView view, IAppointmentService model)
        {
            this.model = model;
            view.ArrangeAnAppointmentEvent += model.ArrangeAnAppointment;
            model.DataChanged += (a, b) => view.RedrawForm(model.patientList.ReadAll().Select(s => new PatientEventArgs() { Id = s.Id, Name = s.Name, Complaints = s.Complaints, DiagnosisName = s.DiagnosisName }).ToList(), model.doctorList.ReadAll().Select(s => new DoctorEventArgs { Id = s.Id, Name = s.Name, ExperienceYears = s.ExperienceYears, Specialization = s.Specialization }).ToList());
            view.RedrawForm(model.patientList.ReadAll().Select(s => new PatientEventArgs() { Id = s.Id, Name = s.Name, Complaints = s.Complaints, DiagnosisName = s.DiagnosisName }).ToList(), model.doctorList.ReadAll().Select(s => new DoctorEventArgs { Id = s.Id, Name = s.Name, ExperienceYears = s.ExperienceYears, Specialization = s.Specialization }).ToList());
        }
    }
}
