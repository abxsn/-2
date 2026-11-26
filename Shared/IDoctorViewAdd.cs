using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Shared
{
    public interface IDoctorViewAdd : IView
    {
        /// <summary>
        /// Событие для добавления докторов
        /// </summary>
        event Action<DoctorEventArgs> AddDataEvent;
    }
}
