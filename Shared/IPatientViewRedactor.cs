using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Shared
{
    public interface IPatientViewRedactor : IPatientViewRedraw, IView
    {
        /// <summary>
        /// Событие изменения пациентов
        /// </summary>
        event Action<int, int, string> EditDataEvent;
    }
}
