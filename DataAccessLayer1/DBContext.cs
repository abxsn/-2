using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Entities;

namespace DataAccessLayer1
{
    public class DBContext : DbContext 
    {
        public DBContext() : base("DbConnection") 
        {
            Database.SetInitializer<DBContext>(null);
        }
        public DbSet<Patient> Patients { get; set; }
        public DbSet<Doctor> Doctors { get; set; }
    }
}
