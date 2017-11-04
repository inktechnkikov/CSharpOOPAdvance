using Demo.interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Demo
{
    class MultifunctionalMachine:IPrintable,IScan
    {

        public MultifunctionalMachine()
        {

        }

        public string BeginScan()
        {
            return $"Start scanning";
        }

        public string Print()
        {
            return $"Start printing";
        }
    }
}
