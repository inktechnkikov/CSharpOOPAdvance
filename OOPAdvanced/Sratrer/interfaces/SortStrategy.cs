using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sratrer.interfaces
{
    public interface SortStrategy
    {
        void Sort(IList<object> list);
    }
}
