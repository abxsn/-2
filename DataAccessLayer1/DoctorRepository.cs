using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Entities;
using Dapper;
using System.Data;
using System.Data.SqlClient;
using LogicToData;

namespace DataAccessLayer1
{
    public class DoctorRepository : IRepository<Doctor>
    {
        IDbConnection db;   
        public DoctorRepository(IDbConnection connection)
        {
            db = connection;
        }   
        public void Add(Doctor item)
        {
            string sql = "INSERT INTO Doctors (Specialization, Name, ExperienceYears) VALUES(@Specialization, @Name, @ExperienceYears);" +
                            "SELECT CAST(SCOPE_IDENTITY() as int)";
            int id = db.Query<int>(sql, item).FirstOrDefault();
            item.Id = id;
        }   
        
        public void Delete(int id)
        {
            string sql = "DELETE FROM Doctors WHERE Id=@id";
            db.Execute(sql, new {Id = id});
        }

        public void Dispose()
        {
            db.Dispose();
        }

        public IEnumerable<Doctor> ReadAll()
        {
            string sql = "SELECT * FROM Doctors";
            return db.Query<Doctor>(sql);
        }

        public Doctor ReadById(int id)
        {
            string sql = "SELECT * FROM Doctors WHERE Id=@id";
            return db.Query<Doctor>(sql, new { Id = id }).FirstOrDefault();
        }

        public void Update(Doctor item)
        {
            string sql = "UPDATE Doctors SET Name=@Name, Specialization=@Specialization, ExperienceYears=@ExperienceYears WHERE Id=@Id";
            db.Execute(sql, item);
        }
        public int Count()
        {
            string sql = "SELECT * FROM Doctors";
            return db.Query<Doctor>(sql).Count();
        }
    }
}
