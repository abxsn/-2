using BusinessLogic2;
using Shared;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Presenter
{
    internal class DoctorRedrawPresenter
    {
        private IDoctorService model;
        /// <summary>
        /// Презентер для IDoctorViewRedraw
        /// </summary>
        /// <param name="model"></param>
        /// <param name="view"></param>
        public DoctorRedrawPresenter(IDoctorService model, IDoctorViewRedraw view)
        {
            this.model = model;
        }
    }
}
