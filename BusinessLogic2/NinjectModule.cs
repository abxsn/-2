using LogicToData;
using Entities;
using Ninject;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.Data.SqlClient;
using DataAccessLayer1;
namespace BusinessLogic2
{
    public class NinjectModule : Ninject.Modules.NinjectModule
    {
        public override void Load() 
        {
            string connectionString = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\000\source\repos\DataAccessLayer1\Database1.mdf;Integrated Security=True";
            Bind<ILogic>().To<Logic>().InSingletonScope();
            Bind<IDbConnection>()
                .ToMethod(ctx => new SqlConnection(connectionString))
                .InSingletonScope();
            Bind<IRepository<Patient>>().To<PatientRepository>().InSingletonScope();
            Bind<IRepository<Doctor>>().To<DoctorRepository>().InSingletonScope();
            Bind<IUnitOfWork>().To<DapperUnitOfWork>().InSingletonScope();
            //Bind<DBContext>().ToSelf().InSingletonScope();
            // Bind<IRepository<Patient>>().To<EntityRepository<Patient>>().InSingletonScope();
            // Bind<IRepository<Doctor>>().To<EntityRepository<Doctor>>().InSingletonScope();
            // Bind<IUnitOfWork>().To<EfUnitOfWork>().InSingletonScope();



        }
    }
}
