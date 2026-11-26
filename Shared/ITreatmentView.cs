using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Shared
{
    public interface ITreatmentView : IView
    {
        /// <summary>
        /// Событие для лечения пациентов
        /// </summary>
        event Func<string> TreatmentRequired;
    }
}
