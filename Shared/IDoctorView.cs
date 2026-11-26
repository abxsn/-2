using Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Shared
{
    public interface IDoctorView
    {
        /// <summary>
        /// Событие для добавления докторов
        /// </summary>
        event Action<DoctorEventArgs> AddDataEvent;
        /// <summary>
        /// Событие для удаления докторов
        /// </summary>
        event Action<int> RemoveDataEvent;
    }
}
