using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Shared
{
    public interface IDoctorViewRemove : IView, IDoctorViewRedraw
    {
        /// <summary>
        /// Событие удаления докторов
        /// </summary>
        event Action<int> RemoveDataEvent;
    }
}
