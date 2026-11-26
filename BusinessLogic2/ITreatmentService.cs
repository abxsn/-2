using Entities;
using LogicToData;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Shared;

namespace BusinessLogic2
{
    public interface ITreatmentService
    {

        event Action<IEnumerable<PatientEventArgs>> DataChanged;
        /// <summary>
        /// Репозиторий пациентов
        /// </summary>
        IRepository<Patient> patientList { get; }
        /// <summary>   
        /// Лечит всех пациентов из списка пациентов
        /// </summary>
        /// <returns>Успех/неудачу лечения/сообщение о смерти пациента</returns>
        string StartTreatment();
    }
}
