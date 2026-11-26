using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Shared
{
    public interface IPatientViewAdd : IView
    {
        /// <summary>
        /// Событие добавления пациентов
        /// </summary>
        event Action<PatientEventArgs> AddDataEvent;
    }
}
