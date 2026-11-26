using Microsoft.Data.SqlClient;
using Entities;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Common;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using LogicToData;
using Ninject;
namespace DataAccessLayer1
{
    public class DapperUnitOfWork : IUnitOfWork, IDisposable
    {
        //string connectionString = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\000\source\repos\DataAccessLayer1\Database1.mdf;Integrated Security=True";
        IDbConnection dbConnection;
        /// <summary>
        /// Репозиторий докторов
        /// </summary>
        public IRepository<Doctor> DoctorRepository { get; private set; }
        /// <summary>
        /// Репозиторий пациента
        /// </summary>
        public IRepository<Patient> PatientRepository { get; private set; }
        public DapperUnitOfWork(IDbConnection dbConnection, DoctorRepository doctorRepository, PatientRepository patientRepository)
        {
            this.dbConnection = dbConnection;
            DoctorRepository = doctorRepository;
            PatientRepository = patientRepository;
        }
        public void UpdateDoctorData(Doctor doctor)
        {
            DoctorRepository.Update(doctor);
        }
        public void UpdatePatientData(Patient patient)
        {
            PatientRepository.Update(patient);
        }
        public void Dispose()
        {
            dbConnection?.Dispose();
        }
    }
}
