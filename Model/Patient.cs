using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities
{
    public class Patient : IDomainObject
    {
        private int _health = 15;
        /// <summary>
        /// Здоровье пациента
        /// </summary>
        public int Health
        {
            get
            {
                return _health;
            }
            set
            {
                _health = value;
            }
        }
        private string _complaints;
        /// <summary>
        /// Привязанный к пациенту доктор
        /// </summary>
        public int? DoctorId { get; set; }
        [NotMapped]
        /// <summary>
        /// Привязанный к пациенту доктор
        /// </summary>
        public Doctor doctor {  get; set; }
        /// <summary>
        /// Айди пациента
        /// </summary>
        public int Id { get; set; }
        /// <summary>
        /// Имя пациента
        /// </summary>
        public string Name { get; set; }
        /// <summary>
        /// Жалобы пациента
        /// </summary>
        public string Complaints
        {
            get {  return _complaints; }
            set 
            {
                _complaints = value; 
            }
        }
        /// <summary>
        /// Название диагноза
        /// </summary>
        public string DiagnosisName { get; set; }
        /// <summary>
        /// Категория диагноза
        /// </summary>
        public string DiagnosisCathegory { get; set; }
        /// <summary>
        /// Требуемый опыт для постановки диагноза
        /// </summary>
        public int DiagnosisRequiredExperience { get; set; } 
        /// <summary>
        /// Название настоящего диагноза
        /// </summary>
        public string RealDiagnosisName { get; set; }
        /// <summary>
        /// Категория настоящего диагоза
        /// </summary>
        public string RealDiagnosisCathegory { get; set; }
        /// <summary>
        /// Требуемый опыт для постановки настоящего диагноща
        /// </summary>
        public int RealDiagnosisRequiredExperience { get; set; } 
        /// <summary>
        /// Вред который наносит настоящий диагноз
        /// </summary>
        public int RealDiagnosisDestructivity { get; set; }
        /// <summary>
        /// Диагноз
        /// </summary>
        [NotMapped]
        public Illness Diagnosis
        {
            get
            {
                return new Illness() { Cathegory = DiagnosisCathegory, ExperienceRequired = DiagnosisRequiredExperience, Name = DiagnosisName };
            }
            set
            {
                if (value == null)
                {
                    return;
                }
                DiagnosisName = value.Name;
                DiagnosisCathegory = value.Cathegory;
                DiagnosisRequiredExperience = value.ExperienceRequired;
            }
        }
        /// <summary>
        /// Настоящий диагноз
        /// </summary>
        [NotMapped]
        public Illness RealDiagnosis
        {
            get
            {
                return new Illness() { Cathegory = RealDiagnosisCathegory, ExperienceRequired = RealDiagnosisRequiredExperience, Name = RealDiagnosisName };
            }
            set
            {
                RealDiagnosisName = value.Name;
                RealDiagnosisCathegory = value.Cathegory;
                RealDiagnosisRequiredExperience = value.ExperienceRequired;
                RealDiagnosisDestructivity = value.Destructivity;
            }
        }
    }
}
