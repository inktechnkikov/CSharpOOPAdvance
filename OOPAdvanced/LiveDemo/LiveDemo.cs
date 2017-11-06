using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LiveDemo
{
    class LiveDemo
    {
        public delegate void WorkPerformedDelegate(int hours, Worktype worktype);

        static void Main(string[] args)
        {
            WorkPerformedDelegate dele = new WorkPerformedDelegate(WorkPerformered);
            dele(5, Worktype.Meetings);
            WorkPerformedDelegate secondDelegate = new WorkPerformedDelegate(WorkPerformered);
            secondDelegate(4,Worktype.Sport);

        }
        public static void WorkPerformered(int hours,Worktype worktype)
        {
            Console.WriteLine("WorkPerformed for " + hours + " hours");
        }
    }
}
