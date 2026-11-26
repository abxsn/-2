using LogicToData;
using Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Shared;
namespace BusinessLogic2
{
    public class DoctorService : IDoctorService
    {
        /// <summary>
        /// Репозиторий
        /// </summary>
        public IRepository<Doctor> doctorList { get; }
        /// <summary>
        /// 
        /// </summary>
        /// <param name="doctorList">репозиторий докторов</param>
        public DoctorService(IRepository<Doctor> doctorList)
        {
            this.doctorList = doctorList;
        }

        public event Action<IEnumerable<DoctorEventArgs>> DataChanged;

        /// <summary>
        /// Добавляет доктора в список докторов с его именем, специализацией и опытом работы
        /// </summary>
        /// <param name="doctorName">Имя доктора</param>
        /// <param name="specializationId">Айди специализации</param>
        /// <param name="experienceYears">Число лет опыта</param>
        public void AddDoctor(string doctorName, int specializationId, int experienceYears)
        {
            doctorList.Add(new Doctor() { ExperienceYears = experienceYears, Name = doctorName, Specialization = MedicalCatalog.AllPossibleComplaints.Keys.ToList()[specializationId] });
            DataChanged.Invoke(null);
        }
        /// <summary>
        /// Удаляет доктора из списка докторов
        /// </summary>
        /// <param name="doctorId">Айди доктора</param>
        public void RemoveDoctor(int doctorId)
        {
            Doctor doctor = doctorList.ReadById(doctorId);
            if (doctor != null)
            {
                doctorList.Delete(doctorId);
            }
            DataChanged.Invoke(GetAll().Select(s => new DoctorEventArgs { Id = s.Id, Name = s.Name, ExperienceYears = s.ExperienceYears, Specialization = s.Specialization }));
        }
        /// <summary>
        /// Изменяет свойства врача
        /// </summary>
        /// <param name="doctorId">Айди доктора</param>
        /// <param name="redactedParamId">Айди редактируемого параметра</param>
        /// <param name="newParam">Новое значение параметра</param>
        public void DoctorRedactor(int doctorId, int redactedParamId, string newParam)
        {
            Doctor doctor = doctorList.ReadById(doctorId);
            if (doctor == null) return;

            if (redactedParamId == 0)
            {
                doctor.Name = newParam;
            }
            else if (redactedParamId == 1)
            {
                doctor.Specialization = newParam;
            }
            else if (redactedParamId == 2)
            {
                int.TryParse(newParam, out int exp);
                doctor.ExperienceYears = exp;
            }
            doctorList.Update(doctor);
            DataChanged.Invoke(GetAll().Select(s => new DoctorEventArgs { Id = s.Id, Name = s.Name, ExperienceYears = s.ExperienceYears, Specialization = s.Specialization }));
        }
        /// <summary>
        /// 
        /// </summary>
        /// <returns>Существующие в репозитории id</returns>
        public List<int> GetExistingIds()
        {
            return doctorList.ReadAll().Select(s => s.Id).ToList();
        }
        /// <summary>
        /// Список докторов
        /// </summary>
        /// <returns></returns>
        public IEnumerable<Doctor> GetAll()
        {
            return doctorList.ReadAll();
        }
        /// <summary>
        /// Число докторов
        /// </summary>
        public int Count
        {
            get
            {
                return doctorList.Count();
            }
        }
    }
}
