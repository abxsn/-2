using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Shared
{
    public interface IPatientViewRemove : IView, IPatientViewRedraw, IPatientsListView
    {
        /// <summary>
        /// Событие для удаления пациентов
        /// </summary>
        event Action<int> RemoveDataEvent;
    }
}
