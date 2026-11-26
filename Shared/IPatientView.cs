using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Entities;
namespace Shared
{
    public interface IPatientView
    {
        /// <summary>
        /// Событие добавления пациентов
        /// </summary>
        event Action<PatientEventArgs> AddDataEvent;
        /// <summary>
        /// Событие удаления пациентов
        /// </summary>
        event Action<int> RemoveDataEvent;
    }
}