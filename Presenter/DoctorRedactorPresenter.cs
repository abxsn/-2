using BusinessLogic2;
using Shared;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Presenter
{
    internal class DoctorRedactorPresenter
    {
        private IDoctorService model;
        /// <summary>
        /// Презентер для IDoctorService
        /// </summary>
        /// <param name="view"></param>
        /// <param name="model"></param>
        public DoctorRedactorPresenter(IDoctorViewRedactor view, IDoctorService model)
        {
            this.model = model;
            view.EditDataEvent += model.DoctorRedactor;
            model.DataChanged += _ => view.RedrawForm(model.GetAll().Select(s => new DoctorEventArgs { Id = s.Id, Name = s.Name, ExperienceYears = s.ExperienceYears, Specialization = s.Specialization }));
            view.RedrawForm(model.GetAll().Select(s => new DoctorEventArgs { Id = s.Id, Name = s.Name, ExperienceYears = s.ExperienceYears, Specialization = s.Specialization }));
        }
    }
}
