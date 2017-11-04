using Sratrer.models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sratrer
{
    class Starter
    {
        static void Main(string[] args)
        {
            SortedList list = new SortedList();
            SortedList list1 = new SortedList();
            SortedList lis2 = new SortedList();
            list1.Sort(new MergeSort());
            list.Sort(new QuickSort());
            lis2.Sort(new SelectedSort());
        }
    }
}
