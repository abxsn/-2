using Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;
using LogicToData;
using Shared;

namespace BusinessLogic2
{
    public class Logic : ILogic
    {
        /// <summary>
        /// Класс операций которые будут происходить с пациентом
        /// </summary>
        public IPatientService PatientService {  get; set; }
        /// <summary>
        /// Класс операций которые будут происходить с пациентом
        /// </summary>
        public IDoctorService DoctorService { get; set; }
        /// <summary>
        /// Класс операций которые будут происходить с пациентом
        /// </summary>
        public ITreatmentService TreatmentService { get; set; }
        /// <summary>
        /// Класс операций которые будут происходить с пациентом
        /// </summary>
        public IAppointmentService AppointmentService { get; set; }
        /// <summary>
        /// Класс операций которые будут происходить между пациентом и доктором
        /// </summary>
        /// <param name="doctorPatientUnitOfWork">UnitOfWork</param>
        public Logic(IUnitOfWork doctorPatientUnitOfWork)
        {
            this.doctorPatientUnitOfWork = doctorPatientUnitOfWork;
            PatientService = new PatientService(doctorPatientUnitOfWork.PatientRepository);
            DoctorService = new DoctorService(doctorPatientUnitOfWork.DoctorRepository);
            TreatmentService = new TreatmentService(doctorPatientUnitOfWork.PatientRepository);
            AppointmentService = new AppointmentService(doctorPatientUnitOfWork.PatientRepository, doctorPatientUnitOfWork.DoctorRepository);
        }
        /// <summary>
        /// Число специализаций
        /// </summary>
        public int specializationsCount
        {
            get
            {
                return MedicalCatalog.AllPossibleDiagnosis.Keys.Count;
            }
        }
        /// <summary>
        /// Число жалоб
        /// </summary>
        public int complaintsCount
        {
            get
            {
                return MedicalCatalog.AllPossibleComplaints.Values.SelectMany(s => s).ToList().Count;
            }
        }
        private Random rnd = new Random();
        /// <summary>
        /// список врачей, пациентов
        /// </summary>
        public IUnitOfWork doctorPatientUnitOfWork { get; set; }
        /// <summary>
        /// Список возможных имен (не используется)
        /// </summary>
        public List<string> doctors = new List<string>
        {
            "Иванов Петр Сергеевич",
            "Смирнова Елена Николаевна",
            "Васильев Андрей Владимирович",
            "Кузнецова Ольга Игоревна",
            "Петров Александр Александрович",
            "Соколов Дмитрий Михайлович",
            "Морозова Наталья Викторовна",
            "Волков Сергей Юрьевич",
            "Попова Татьяна Александровна",
            "Лебедев Михаил Николаевич",
            "Козлов Артем Дмитриевич",
            "Новикова Ирина Сергеевна"
        };
        
    }
}
