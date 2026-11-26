using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Shared
{
    public interface IDoctorViewRedraw
    {
        /// <summary>
        /// Событие для обновления докторов
        /// </summary>
        /// <param name="e">/lkjh</param>
        void RedrawForm(IEnumerable<DoctorEventArgs> e);
    }
}
