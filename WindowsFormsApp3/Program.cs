using BusinessLogic2;
using LogicToData;
using Entities;
using Ninject;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using Shared;
namespace WindowsFormsApp3
{
    internal static class Program
    {
        /// <summary>
        /// Главная точка входа для приложения.
        /// </summary>
        [STAThread]
        static void Main()
        {
            IKernel ninjectKernel = new StandardKernel(new NinjectModule());
            ILogic logic = ninjectKernel.Get<ILogic>();
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new Form1());
        }
        /// <summary>
        /// </summary>
        /// <returns>Список списков строк, являющихся свойствами пациентов</returns>
        public static List<string[]> PatientStringData(IEnumerable<Patient> patients)
        {
            List<string[]> patientStrings = new List<string[]>();
            foreach (Patient patient in patients)
            {
                patientStrings.Add(new string[4] { patient.Name, patient.Complaints, patient.DiagnosisName, patient.Id.ToString() });
            }
            return patientStrings;
        }
        public static List<string[]> PatientEventArgsStringData(IEnumerable<PatientEventArgs> patients)
        {
            List<string[]> patientStrings = new List<string[]>();
            if (patients == null) return patientStrings;
            foreach (PatientEventArgs patient in patients)
            {
                patientStrings.Add(new string[4] { patient.Name, patient.Complaints, patient.DiagnosisName, patient.Id.ToString() });
            }
            return patientStrings;
        }
        /// <summary>
        /// </summary>
        /// <returns>Список списков строк, являющихся свойствами врачей</returns>
        public static List<string[]> DoctorStringData(IEnumerable<Doctor> doctors)
        {
            List<string[]> doctorStrings = new List<string[]>();
            foreach (Doctor doctor in doctors)
            {
                doctorStrings.Add(new string[4] { doctor.Name, doctor.Specialization, doctor.ExperienceYears.ToString(), doctor.Id.ToString() });
            }
            return doctorStrings;
        }
        public static List<string[]> DoctorEventArgsStringData(IEnumerable<DoctorEventArgs> doctors)
        {
            List<string[]> doctorStrings = new List<string[]>();
            foreach (DoctorEventArgs doctor in doctors)
            {
                doctorStrings.Add(new string[4] { doctor.Name, doctor.Specialization, doctor.ExperienceYears.ToString(), doctor.Id.ToString() });
            }
            return doctorStrings;
        }
        public static List<int> PatientIdsEventArgs(IEnumerable<PatientEventArgs> e)
        {
            return e.Select(s => s.Id).ToList();
        }
        public static List<int> DoctorIdsEventArgs(IEnumerable<DoctorEventArgs> e)
        {
            return e.Select(s => s.Id).ToList();
        }
        /// <summary>
        /// </summary>
        /// <returns>Все возможные специализации</returns>
        public static List<string> SpecializationsString()
        {
            return MedicalCatalog.AllPossibleComplaints.Keys.ToList();
        }
        /// <summary>
        /// </summary>
        /// <returns>Все возможные жалобы</returns>
        public static List<string> ComplaintsString()
        {
            return MedicalCatalog.AllPossibleComplaints.Values.SelectMany(s => s).ToList();
        }
    }
    public static class Starter
    {
        public static void StartForm(Form1 form)
        {

        }
    }
}
