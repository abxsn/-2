using BusinessLogic2;
using Shared;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Presenter
{
    internal class TreatmentPresenter
    {
        private ITreatmentService model;
        /// <summary>
        /// Презентер для лечения пациентов
        /// </summary>
        /// <param name="view"></param>
        /// <param name="model"></param>
        public TreatmentPresenter(ITreatmentView view, ITreatmentService model)
        {
            this.model = model;
            view.TreatmentRequired += model.StartTreatment;
        }
    }
}
