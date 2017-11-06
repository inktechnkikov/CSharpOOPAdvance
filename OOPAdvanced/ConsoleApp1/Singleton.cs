using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Singleton
    {
        private static int counter = 0;
        public Singleton()
        {
            counter++;
            Console.WriteLine($"counter value {counter.ToString()}");
        }
        public void PrintDetails(string msg)
        {
            Console.WriteLine(msg);
        }
    }
}
