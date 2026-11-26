using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities
{
    public class Illness : IDomainObject
    {
        /// <summary>
        /// Айди болезни
        /// </summary>
        public int Id { get; set; }
        /// <summary>
        /// Категория болезни
        /// </summary>
        public string Cathegory { get; set; }
        /// <summary>
        /// Название болезни
        /// </summary>
        public string Name { get; set; }
        /// <summary>
        /// Вред наносимый болезнью
        /// </summary>
        public int Destructivity { get; set; }
        /// <summary>
        /// Опыт необходимый для идентификации болезни
        /// </summary>
        public int ExperienceRequired { get; set; }
    }
}
