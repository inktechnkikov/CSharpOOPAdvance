using StartUpMachine.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StartUpMachine
{
    class StartUp
    {
        static void Main(string[] args)
        {
            CoffeMachine machine = new CoffeMachine();
            string input;
            while((input = Console.ReadLine()) != "End")
            {
                string[] inputArgs = input.Split();
                if(inputArgs.Length == 1)
                {
                    machine.InsertCoin(inputArgs[0]);
                }
                else
                {
                    machine.BuyCoffee(inputArgs[0], inputArgs[1]);
                }
                foreach (var coffeType in machine.CoffeSold)
                {
                    Console.WriteLine(coffeType);
                }
            }
        }
    }
}
