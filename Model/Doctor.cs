using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities
{
    public class Doctor : IDomainObject
    {
        /// <summary>
        /// Айди врача
        /// </summary>
        public int Id { get; set; }
        /// <summary>
        /// Специализация врача
        /// </summary>
        public string Specialization { get; set; }
        /// <summary>
        /// Имя врача
        /// </summary>
        public string Name { get; set; }
        /// <summary>
        /// Опыт врача
        /// </summary>
        public int ExperienceYears { get; set; }
        /// <summary>
        /// Привязанные к врачу пациенты
        /// </summary>
    }
}
