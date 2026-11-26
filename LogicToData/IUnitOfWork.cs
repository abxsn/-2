using Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LogicToData
{

    public interface IUnitOfWork
    {
        /// <summary>
        /// Репозиторий докторов
        /// </summary>
        IRepository<Doctor> DoctorRepository { get; }
        /// <summary>
        /// Репозиторий пациентов
        /// </summary>
        IRepository<Patient> PatientRepository { get; }
        /// <summary>
        /// Обновляет данные всех докторов
        /// </summary>
        /// <param name="doctor"></param>
        void UpdateDoctorData(Doctor doctor);
        /// <summary>
        /// Обновляет данные всех пациентов
        /// </summary>
        /// <param name="patient"></param>
        void UpdatePatientData(Patient patient);
    }
}