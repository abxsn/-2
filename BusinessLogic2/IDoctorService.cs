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
    public interface IDoctorService
    {
        event Action<IEnumerable<DoctorEventArgs>> DataChanged;
        /// <summary>
        /// Репозиторий
        /// </summary>
        IRepository<Doctor> doctorList { get; }
        /// <summary>
        /// Добавляет доктора в список докторов с его именем, специализацией и опытом работы
        /// </summary>
        /// <param name="doctorName">Имя доктора</param>
        /// <param name="specializationId">Айди специализации</param>
        /// <param name="experienceYears">Число лет опыта</param>
        void AddDoctor(string doctorName, int specializationId, int experienceYears);
        /// <summary>
        /// Удаляет доктора из списка докторов
        /// </summary>
        /// <param name="doctorId">Айди доктора</param>
        void RemoveDoctor(int doctorId);
        /// <summary>
        /// Изменяет свойства врача
        /// </summary>
        /// <param name="doctorId">Айди доктора</param>
        /// <param name="redactedParamId">Айди редактируемого параметра</param>
        /// <param name="newParam">Новое значение параметра</param>
        void DoctorRedactor(int doctorId, int redactedParamId, string newParam);
        /// <summary>
        /// 
        /// </summary>
        /// <returns>Существующие в репозитории id</returns>
        List<int> GetExistingIds();
        /// <summary>
        /// Список докторов
        /// </summary>
        /// <returns></returns>
        IEnumerable<Doctor> GetAll();
        /// <summary>
        /// Число докторов
        /// </summary>
        int Count
        {
            get;
        }
    }
}
