using Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLogic2
{
    public interface IMedicalCatalog
    {

        /// <summary>
        /// По названию специализации находит её айди
        /// </summary>
        /// <param name="name">Название специализации</param>
        /// <returns>Айди специализации</returns>
        int GetSpecializationId(string name);
        /// <summary>
        /// По названию жалобы находит её айди
        /// </summary>
        /// <param name="name">Название жалобы</param>
        /// <returns>Айди жалобы</returns>
        int GetComplaintId(string name);
        /// <summary>
        /// Словарь всех возможных диагнозов (ключ - группа, значение - диагноз)
        /// </summary>
        Dictionary<string, List<Illness>> AllPossibleDiagnosis { get; }
        /// <summary>
        /// Всевозможные жалобы
        /// </summary>
        Dictionary<string, List<string>> AllPossibleComplaints { get; }
    }
}
