using LogicToData;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLogic2
{
    public interface ILogic
    {
        /// <summary>
        /// Класс операций которые будут происходить с пациентом
        /// </summary>
        IPatientService PatientService { get; set; }
        /// <summary>
        /// Класс операций которые будут происходить с доктором
        /// </summary>
        IDoctorService DoctorService { get; set; }
        /// <summary>
        /// Класс операций которые будут происходить с пациентом
        /// </summary>
        ITreatmentService TreatmentService { get; set; }
        /// <summary>
        /// Класс операций которые будут происходить между пациентом и доктором
        /// </summary>
        /// <param name="doctorPatientUnitOfWork">UnitOfWork</param>
        IAppointmentService AppointmentService { get; set; }
        /// <summary>
        /// список врачей, пациентов
        /// </summary>
        IUnitOfWork doctorPatientUnitOfWork { get; set; }
        int specializationsCount { get; }
        int complaintsCount { get;}
    }
}
