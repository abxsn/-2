using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Shared
{
    public class DoctorEventArgs : EventArgs, INotifyPropertyChanged
    {
        /// <summary>
        /// Айди врача
        /// </summary>
        public int Id { get; set; }
        /// <summary>
        /// Специализация врача
        /// </summary>
        public string Specialization { get; set; }
        /// <summary>
        /// Имя врача
        /// </summary>
        public string Name { get; set; }
        /// <summary>
        /// Опыт врача
        /// </summary>
        public int ExperienceYears { get; set; }
        public event PropertyChangedEventHandler PropertyChanged;
    }
}
