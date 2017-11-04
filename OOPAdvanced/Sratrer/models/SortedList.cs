using Sratrer.interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sratrer.models
{
    class SortedList
    {
        private List<object> list;

        public void Sort(SortStrategy strategy)
        {
            strategy.Sort(this.list);
        }
    }
}
