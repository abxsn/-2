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
    public class AppointmentService : IAppointmentService
    {
        private Random rnd = new Random();

        /// <summary>
        /// Событие изменения состояний пациентов и докторов
        /// </summary>
        public event Action<IEnumerable<DoctorEventArgs>, IEnumerable<PatientEventArgs>> DataChanged;

        /// <summary>
        /// Репозиторий пациентов
        /// </summary>
        public IRepository<Patient> patientList { get; }
        /// <summary>
        /// Список врачей
        /// </summary>
        public IRepository<Doctor> doctorList { get; }
        /// <summary>
        /// 
        /// </summary>
        /// <param name="patientList"> список пациентов</param>
        /// <param name="doctorList">список докторов</param>
        public AppointmentService(IRepository<Patient> patientList, IRepository<Doctor> doctorList)
        {
            this.patientList = patientList;
            this.doctorList = doctorList;
        }

        /// <summary>
        /// Использует привязанного пациента к врачу и дает ему диагноз
        /// </summary>
        /// <param name="idPatient">Айди пациента</param>
        /// <returns>Строку возможность постановки диагноза</returns>
        public string GivePatientADiagnosis(int idPatient) //Функция зависящая от пациента и от доктора, т.к. метод LinkPatient привязывает конкретного ДОКТОРА к пациенту. Здесь привязанный к пациенту ДОКТОР дает диагноз пациенту (2/2)
        {

            Patient patient = patientList.ReadById(idPatient);
            Doctor doctor = doctorList.ReadById(patient.DoctorId.Value);
            if (doctor.ExperienceYears >= patientList.ReadById(idPatient).RealDiagnosis.ExperienceRequired)
            {
                if (doctor.Specialization == patient.RealDiagnosis.Cathegory)
                {
                    patient.Diagnosis = new Illness() { Name = patient.RealDiagnosis.Name, Cathegory = patient.RealDiagnosis.Cathegory, ExperienceRequired = patient.RealDiagnosis.ExperienceRequired };
                    patientList.Update(patient);
                    return "Вашему пациенту был поставлен диагноз ВЕРНО!";
                }
                else
                {
                    return "Данный врач не подходит для постановки диагноза вашему пациенту";
                }
            }
            else if (doctor.Specialization != patient.RealDiagnosisCathegory)
            {
                return "Данный врач не подходит для постановки диагноза вашему пациенту";
            }
            else
            {
                patient.Diagnosis = MedicalCatalog.AllPossibleDiagnosis.FirstOrDefault(s => s.Key == patient.RealDiagnosis.Cathegory).Value[rnd.Next(MedicalCatalog.AllPossibleDiagnosis.FirstOrDefault(s => s.Key == patient.RealDiagnosis.Cathegory).Value.Count())];
                patientList.Update(patient);
                return "Врачу не хватило его опыта, вследствие чего поставленный только что диагноз может быть неверным.";
            }
        }
        /// <summary>
        /// Привязывает пациента к врачу и дает ему диагноз
        /// </summary>
        /// <param name="patientId">Айди пациента</param>
        /// <param name="doctorId">Айди доктора</param>
        /// <returns>Возвращает строку о том подходит врач или нет</returns>
        public string ArrangeAnAppointment(int patientId, int doctorId) //Функция зависящая от обоих сущностей (1/1)
        {
            Doctor doctor = doctorList.ReadById(doctorId);
            Patient patient = patientList.ReadById(patientId);
            if (LinkPatient(patientId, doctorId) == true)
            {
                string st = GivePatientADiagnosis(patientId);
                DataChanged.Invoke(doctorList.ReadAll().Select(s => new DoctorEventArgs { Id = s.Id, Name = s.Name, ExperienceYears = s.ExperienceYears, Specialization = s.Specialization }), patientList.ReadAll().Select(s => new PatientEventArgs() { Id = s.Id, Name = s.Name, Complaints = s.Complaints, DiagnosisName = s.DiagnosisName }).ToList());
                return st;
            }
            else if (doctor.Specialization != patient.RealDiagnosisCathegory)
            {
                return "Данный врач не подходит для постановки диагноза вашему пациенту";
            }
            return "";
        }

        /// <summary>
        /// Привязывает пациента к доктору
        /// </summary>
        /// <param name="idPatient">Айди пациента</param>
        /// <param name="idDoctor">Айди доктора</param>
        /// <returns>true если привязка удалась иначе false</returns>
        public bool LinkPatient(int idPatient, int idDoctor)
        {
            foreach (Doctor doctor in doctorList.ReadAll())
            {
                if (idDoctor == doctor.Id)
                {
                    if (doctor.Specialization == patientList.ReadById(idPatient).RealDiagnosis.Cathegory)
                    {
                        Patient patient = patientList.ReadById(idPatient);
                        patient.DoctorId = doctor.Id;
                        patientList.Update(patient);
                        return true;
                    }
                }
            }
            return false;
        }
    }
}
