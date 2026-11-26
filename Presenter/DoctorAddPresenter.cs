using BusinessLogic2;
using Shared;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Presenter
{
    internal class DoctorAddPresenter
    {
        private IDoctorService model;
        /// <summary>
        /// Презентер для IDoctorViewAdd
        /// </summary>
        /// <param name="model"></param>
        /// <param name="view"></param>
        public DoctorAddPresenter(IDoctorService model, IDoctorViewAdd view)
        {
            this.model = model;
            view.AddDataEvent += OnAddData;
        }
        /// <summary>
        /// Подписчик AddDataEvent во view
        /// </summary>
        /// <param name="doctor"></param>
        public void OnAddData(DoctorEventArgs doctor)
        {
            model.AddDoctor(doctor.Name, MedicalCatalog.GetSpecializationId(doctor.Specialization), doctor.ExperienceYears);
        }
    }
}
