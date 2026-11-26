using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Shared
{
    public interface IPatientViewRedraw
    {
        /// <summary>
        /// Событие для обновления пациентов
        /// </summary>
        /// <param name="e"></param>
        void RedrawForm(IEnumerable<PatientEventArgs> e);
    }
}   
