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
    public interface IAppointmentService
    {
        event Action<IEnumerable<DoctorEventArgs>, IEnumerable<PatientEventArgs>> DataChanged;
        /// <summary>
        /// Репозиторий пациентов
        /// </summary>
        IRepository<Patient> patientList { get; }
        /// <summary>
        /// Список врачей
        /// </summary>
        IRepository<Doctor> doctorList { get; }

        /// <summary>
        /// Использует привязанного пациента к врачу и дает ему диагноз
        /// </summary>
        /// <param name="idPatient">Айди пациента</param>
        /// <returns>Строку возможность постановки диагноза</returns>
        string GivePatientADiagnosis(int idPatient);
        /// <summary>
        /// Привязывает пациента к врачу и дает ему диагноз
        /// </summary>
        /// <param name="patientId">Айди пациента</param>
        /// <param name="doctorId">Айди доктора</param>
        /// <returns>Возвращает строку о том подходит врач или нет</returns>
        string ArrangeAnAppointment(int patientId, int doctorId);
        /// <summary>
        /// Привязывает пациента к доктору
        /// </summary>
        /// <param name="idPatient">Айди пациента</param>
        /// <param name="idDoctor">Айди доктора</param>
        /// <returns>true если привязка удалась иначе false</returns>
        bool LinkPatient(int idPatient, int idDoctor);
    }
}
