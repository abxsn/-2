using Dapper;
using DataAccessLayer1;
using Entities;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using LogicToData;
namespace DataAccessLayer1

{
    public class PatientRepository : IRepository<Patient> 
    {
        IDbConnection db;
        DBContext dbContext;
        public PatientRepository(IDbConnection connection)
        {
            db = connection;
        }
        public void Add(Patient item)
        {
            string sql = "INSERT INTO Patients (Name, Complaints, Health, DoctorId, DiagnosisName, DiagnosisCathegory, DiagnosisRequiredExperience, RealDiagnosisName, RealDiagnosisCathegory, RealDiagnosisRequiredExperience, RealDiagnosisDestructivity) OUTPUT INSERTED.Id VALUES (@Name, @Complaints, @Health, @DoctorId, @DiagnosisName, @DiagnosisCathegory, @DiagnosisRequiredExperience, @RealDiagnosisName, @RealDiagnosisCathegory, @RealDiagnosisRequiredExperience, @RealDiagnosisDestructivity);";
            int id = db.Query<int>(sql, item).FirstOrDefault();
            item.Id = id;
        }

        public int Count()
        {
            string sql = "SELECT * FROM Patients";
            return db.Query<Patient>(sql).Count();
        }

        public void Delete(int id)
        {
            string sql = "DELETE FROM Patients WHERE Id=@id";
            db.Execute(sql, new { Id = id });
        }

        public void Dispose()
        {
            db.Dispose();
        }

        public IEnumerable<Patient> ReadAll()
        {
            string sql = "SELECT * FROM Patients";
            return db.Query<Patient>(sql);
        }

        public Patient ReadById(int id)
        {
            string sql = "SELECT * FROM Patients WHERE Id=@id";
            return db.Query<Patient>(sql, new { Id = id }).FirstOrDefault();
        }

        public void Update(Patient item)
        {
            string sql = "UPDATE Patients SET Name = @Name, Complaints = @Complaints, Health = @Health, DoctorId = @DoctorId, DiagnosisName = @DiagnosisName, DiagnosisCathegory = @DiagnosisCathegory, DiagnosisRequiredExperience = @DiagnosisRequiredExperience, RealDiagnosisName = @RealDiagnosisName, RealDiagnosisCathegory = @RealDiagnosisCathegory, RealDiagnosisRequiredExperience = @RealDiagnosisRequiredExperience, RealDiagnosisDestructivity = @RealDiagnosisDestructivity WHERE Id = @Id;";
            db.Execute(sql, item);
        }
    }
}
