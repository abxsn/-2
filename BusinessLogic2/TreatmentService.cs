using Entities;
using LogicToData;
using Shared;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLogic2
{
    public class TreatmentService : ITreatmentService
    {
        /// <summary>
        /// Репозиторий пациентов
        /// </summary>
        public IRepository<Patient> patientList { get; }
        /// <summary>
        /// 
        /// </summary>
        /// <param name="patientList">Репозиторий пациентов</param>
        public TreatmentService(IRepository<Patient> patientList)
        {
            this.patientList = patientList;
        }

        /// <summary>
        /// Событие изменения состояния пациентов
        /// </summary>
        public event Action<IEnumerable<PatientEventArgs>> DataChanged;

        /// <summary>   
        /// Лечит всех пациентов из списка пациентов
        /// </summary>
        /// <returns>Успех/неудачу лечения/сообщение о смерти пациента</returns>
        public string StartTreatment()
        {
            foreach (Patient patient in patientList.ReadAll().ToList())
            {
                if (patient.DiagnosisName == patient.RealDiagnosisName)
                {
                    patient.Complaints = string.Empty;
                    patientList.Update(patient);
                    patientList.Delete(patient.Id);
                    DataChanged.Invoke(patientList.ReadAll().Select(s => new PatientEventArgs() { Id = s.Id, Name = s.Name, Complaints = s.Complaints, DiagnosisName = s.DiagnosisName }).ToList());
                    return $"Лечение {patient.Name} удалось!\n";
                }
                else
                {
                    patient.Health -= patient.RealDiagnosisDestructivity;
                    patientList.Update(patient);
                    if (patient.Health <= 0)
                    {
                        patient.doctor = null;
                        patientList.Delete(patient.Id);
                        DataChanged.Invoke(patientList.ReadAll().Select(s => new PatientEventArgs() { Id = s.Id, Name = s.Name, Complaints = s.Complaints, DiagnosisName = s.DiagnosisName }).ToList());
                        return $"Пациент {patient.Name} умер\n";
                    }
                    else
                    {
                        return $"Пациенту {patient.Name} стало лишь хуже. Лечение не действует.\n";
                    }
                }
            }
            return "Нет пациентов для лечения";
        }
    }
}
