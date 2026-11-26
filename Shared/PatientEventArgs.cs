using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel;

namespace Shared
{
    public class PatientEventArgs : EventArgs, INotifyPropertyChanged
    {
        public int Id { get; set; }
        /// <summary>
        /// Имя пациента
        /// </summary>
        public string Name { get; set; }
        /// <summary>
        /// Жалобы пациента
        /// </summary>
        public string Complaints { get; set; }
        /// <summary>
        /// Название диагноза
        /// </summary>
        public string DiagnosisName { get; set; }
        public event PropertyChangedEventHandler PropertyChanged;
    }
}
