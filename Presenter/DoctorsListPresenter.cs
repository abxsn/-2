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
    internal class DoctorsListPresenter
    {
        IDoctorService model;
        IDoctorsListView view;
        /// <summary>
        /// Презентер для показа списка докторов
        /// </summary>
        /// <param name="model"></param>
        /// <param name="view"></param>
        public DoctorsListPresenter(IDoctorService model, IDoctorsListView view)
        {
            this.model = model;
            this.view = view;
            model.DataChanged += _ => view.RedrawForm(model.GetAll().Select(s => new DoctorEventArgs { Id = s.Id, Name = s.Name, ExperienceYears = s.ExperienceYears, Specialization = s.Specialization }));
            view.RedrawForm(model.GetAll().Select(s => new DoctorEventArgs { Id = s.Id, Name = s.Name, ExperienceYears = s.ExperienceYears, Specialization = s.Specialization }));
        }
    }
}
