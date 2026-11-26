using BusinessLogic2;
using Shared;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Presenter
{
    public class DoctorPresenter
    {
        private IDoctorService model;
        public DoctorPresenter(IDoctorService model, IDoctorViewRedraw view)
        {
            this.model = model;
        }
    }
}
