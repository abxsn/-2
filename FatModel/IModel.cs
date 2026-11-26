using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FatModel
{
    internal interface IModel<T>
    {
        Action DataChanged();
        void Insert(int id);
        void Remove(T item);
    }
}
