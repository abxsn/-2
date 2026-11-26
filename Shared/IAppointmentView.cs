using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Shared
{
    public delegate string Appoint(int a, int b);
    public interface IAppointmentView : IView
    {
        /// <summary>
        /// Событие для записывания на прием пациента
        /// </summary>
        event Appoint ArrangeAnAppointmentEvent;
        /// <summary>
        /// Обновление данных во вью
        /// </summary>
        /// <param name="patients"></param>
        /// <param name="doctors"></param>
        void RedrawForm(IEnumerable<PatientEventArgs> patients, IEnumerable<DoctorEventArgs> doctors);
    }
}
