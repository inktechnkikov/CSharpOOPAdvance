using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ISPRefactored
{
    public class HumanWorker : IWorkable, ISlepable, IEatable
    {
        public void eat()
        {
            throw new NotImplementedException();
        }

        public void sleep()
        {
            throw new NotImplementedException();
        }

        public void work()
        {
            throw new NotImplementedException();
        }
    }
}
