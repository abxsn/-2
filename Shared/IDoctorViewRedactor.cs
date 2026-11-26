using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Shared
{
    public interface IDoctorViewRedactor : IDoctorViewRedraw, IView
    {
        /// <summary>
        /// Событие для редактирования докторов
        /// </summary>
        event Action<int, int, string> EditDataEvent;
    }
}
