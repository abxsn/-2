using LogicToData;
using Entities;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Common;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessLayer1
{
    internal class EntityUnitOfWork : IUnitOfWork, IDisposable
    {
        /// <summary>
        /// Репозиторий докторов
        /// </summary>
        public IRepository<Doctor> DoctorRepository { get; private set; }
        /// <summary>
        /// Репозиторий пациента
        /// </summary>
        public IRepository<Patient> PatientRepository { get; private set; }
        private DBContext _context;
        public EntityUnitOfWork(DBContext context, DoctorRepository doctorRepository, PatientRepository patientRepository)
        {
            _context = context;
            DoctorRepository = doctorRepository;
            PatientRepository = patientRepository;
        }
        /// <summary>
        /// Обновляет данные докторов
        /// </summary>
        /// <param name="doctor"></param>
        public void UpdateDoctorData(Doctor doctor)
        {
            DoctorRepository.Update(doctor);
        }
        /// <summary>
        /// Обновляет данные пациентов
        /// </summary>
        /// <param name="patient"></param>
        public void UpdatePatientData(Patient patient)
        {
            PatientRepository.Update(patient);
        }
        /// <summary>
        /// Удаляет контекст
        /// </summary>
        public void Dispose()
        {
            _context.Dispose();
        }
    }
}
