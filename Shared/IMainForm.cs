using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Shared
{
    public interface IMainForm : IDoctorIdsView, IPatientIdsView
    {
        /// <summary>
        /// Событие для добавления пациента
        /// </summary>
        event Action AddPatient;
        /// <summary>
        /// Событие для удаления пациента
        /// </summary>
        event Action RemovePatient;
        /// <summary>
        /// Событие для редактирования пациента
        /// </summary>
        event Action RedactPatient;
        /// <summary>
        /// Событие для добавления доктора
        /// </summary>
        event Action AddDoctor;
        /// <summary>
        /// Событие для удаления доктора
        /// </summary>
        event Action RemoveDoctor;
        /// <summary>
        /// Событие для редактирования доктора
        /// </summary>
        event Action RedactDoctor;
        /// <summary>
        /// Событие для организации приема
        /// </summary>
        event Action ArrangeAnAppointment;
        /// <summary>
        /// Событие для лечения пациентов
        /// </summary>
        event Action StartTreatment;
        /// <summary>
        /// Открыть список пациентов
        /// </summary>
        event Action OpenPatientList;
        /// <summary>
        /// Открыть список докторов
        /// </summary>
        event Action OpenDoctorList;
    }
}
