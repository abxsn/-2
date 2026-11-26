using BusinessLogic2;
using Shared;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Presenter
{
    internal class DoctorRemovePresenter
    {
        private IDoctorService model;
        /// <summary>
        /// Презентер для IDoctorViewRemove
        /// </summary>
        /// <param name="model"></param>
        /// <param name="view"></param>
        public DoctorRemovePresenter(IDoctorService model, IDoctorViewRemove view)
        {
            this.model = model;
            view.RemoveDataEvent += model.RemoveDoctor;
            model.DataChanged += _ => view.RedrawForm(model.GetAll().Select(s => new DoctorEventArgs { Id = s.Id, Name = s.Name, ExperienceYears = s.ExperienceYears, Specialization = s.Specialization }));
            view.RedrawForm(model.GetAll().Select(s => new DoctorEventArgs { Id = s.Id, Name = s.Name, ExperienceYears = s.ExperienceYears, Specialization = s.Specialization }));
        }
    }
}
