using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class SingletonDemo
    {
        static void Main(string[] args)
        {

            Singleton firstSingleton = new Singleton();
            firstSingleton.PrintDetails("This is first message");
            Singleton secondSingleton = new Singleton();
            secondSingleton.PrintDetails("This is second message");
            Console.ReadKey();
        }
    }
}
