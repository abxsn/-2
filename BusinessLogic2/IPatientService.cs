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
    public interface IPatientService
    {
        event Action<IEnumerable<PatientEventArgs>> DataChanged;
        /// <summary>
        /// Репозиторий пациентов
        /// </summary>
        IRepository<Patient> patientList { get; }
        /// <summary>
        /// Добавляет пациента в список пациентов с именем и жалобами
        /// </summary>
        /// <param name="patientName">Имя пациента</param>
        /// <param name="patientComplaints">Жалоба пациента</param>
        void AddPatient(string patientName, int patientComplaints);
        /// <summary>
        /// Удаляет пациента из списка пациентов
        /// </summary>
        /// <param name="patientId">Айди пациента</param>
        void RemovePatient(int patientId);
        /// <summary>
        /// Изменяет свойства пациента
        /// </summary>
        /// <param name="patientId">Айди пациента</param>
        /// <param name="redactedParamId">Айди редактируемого параметра</param>
        /// <param name="newParam">Новое значение параметра</param>
        void PatientRedactor(int patientId, int redactedParamId, string newParam);
        /// <summary>
        /// 
        /// </summary>
        /// <returns>Список существующих id</returns>
        List<int> GetExistingIds();
        /// <summary>
        /// 
        /// </summary>
        /// <returns>Список пациентов</returns>
        IEnumerable<Patient> GetAll();
        /// <summary>
        /// Число пациентов
        /// </summary>
        int Count
        {
            get;
        }
    }
}
