using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractDesignPattern
{
    class AsbtractDesignPattern
    {
        static void Main(string[] args)
        {
            CreateComputer();
        }
        public static void CreateComputer()
        {
            Computer pc = ComputerFactory.GetComputer(new PcFactory("6 Gb", "2TB", "AMD"));
            Computer server = ComputerFactory.GetComputer(new ServerFactory("16TB", "4 TB", "Intel Xeon"));
            Console.WriteLine("Personal computer -> " + pc);
            Console.WriteLine("Server machine -> " + server);
        }
    }
}
