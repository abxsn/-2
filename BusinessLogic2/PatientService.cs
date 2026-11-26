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
    public class PatientService : IPatientService
    {
        private Random rnd = new Random();
        /// <summary>
        /// Событие изменения состояния пациентов
        /// </summary>
        public event Action<IEnumerable<PatientEventArgs>> DataChanged;

        /// <summary>
        /// Репозиторий пациентов
        /// </summary>
        public IRepository<Patient> patientList { get; }
        /// <summary>
        /// 
        /// </summary>
        /// <param name="patientList">Репозиторий пациентов</param>
        public PatientService(IRepository<Patient> patientList)
        {
            this.patientList = patientList;
        }
        /// <summary>
        /// Добавляет пациента в список пациентов с именем и жалобами
        /// </summary>
        /// <param name="patientName">Имя пациента</param>
        /// <param name="patientComplaints">Жалоба пациента</param>
        public void AddPatient(string patientName, int patientComplaints) //можно добавить подключить случайного пациента и пациента данные которого только вводятся
        {
            var b = MedicalCatalog.AllPossibleComplaints.Values.SelectMany(s1 => s1).ToList()[patientComplaints];
            var c = MedicalCatalog.AllPossibleComplaints.FirstOrDefault(s => s.Value.Contains(b)).Key;
            var a = MedicalCatalog.AllPossibleDiagnosis.FirstOrDefault(s => s.Key == c).Value;
            int thing = rnd.Next(a.Count);
            Illness generatedIllness = a[thing];
            Patient patient = new Patient()
            {
                Complaints = MedicalCatalog.AllPossibleComplaints.Values.SelectMany(s => s).ToList()[patientComplaints],
                Name = patientName,
                RealDiagnosis = generatedIllness,
            };
            patientList.Add(patient);
            DataChanged.Invoke(GetAll().Select(s => new PatientEventArgs() { Id = s.Id, Name = s.Name, Complaints = s.Complaints, DiagnosisName = s.DiagnosisName }).ToList());
        }
        /// <summary>
        /// Удаляет пациента из списка пациентов
        /// </summary>
        /// <param name="patientId">Айди пациента</param>
        public void RemovePatient(int patientId)
        {
            Patient patient = patientList.ReadById(patientId);
            if (patient != null)
            {
                patientList.Delete(patientId);
            }
            DataChanged.Invoke(GetAll().Select(s => new PatientEventArgs() { Id = s.Id, Name = s.Name, Complaints = s.Complaints, DiagnosisName = s.DiagnosisName }).ToList());
        }
        /// <summary>
        /// Изменяет свойства пациента
        /// </summary>
        /// <param name="patientId">Айди пациента</param>
        /// <param name="redactedParamId">Айди редактируемого параметра</param>
        /// <param name="newParam">Новое значение параметра</param>
        public void PatientRedactor(int patientId, int redactedParamId, string newParam)
        {
            Patient patient = patientList.ReadById(patientId);
            if (patient == null) return;

            if (redactedParamId == 0)
            {
                patient.Name = newParam;
            }
            else if (redactedParamId == 1)
            {
                patient.Complaints = newParam;
                var c = MedicalCatalog.AllPossibleComplaints.FirstOrDefault(s => s.Value.Contains(newParam)).Key;
                var a = MedicalCatalog.AllPossibleDiagnosis.FirstOrDefault(s => s.Key == c).Value;
                int thing = rnd.Next(a.Count);
                Illness generatedIllness = a[thing];
                patient.RealDiagnosis = generatedIllness;
                
            }
            patientList.Update(patient);
            DataChanged.Invoke(GetAll().Select(s => new PatientEventArgs() { Id = s.Id, Name = s.Name, Complaints = s.Complaints, DiagnosisName = s.DiagnosisName }).ToList());
        }
        /// <summary>
        /// 
        /// </summary>
        /// <returns>Список существующих id</returns>
        public List<int> GetExistingIds()
        {
            return patientList.ReadAll().Select(s => s.Id).ToList();
        }
        /// <summary>
        /// 
        /// </summary>
        /// <returns>Список пациентов</returns>
        public IEnumerable<Patient>GetAll()
        {
            return patientList.ReadAll();
        }
        /// <summary>
        /// Число пациентов
        /// </summary>
        public int Count
        {
            get
            {
                return patientList.Count();
            }
        }
    }
}
