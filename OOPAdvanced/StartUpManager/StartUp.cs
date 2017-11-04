using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StartUpManager
{
    class StartUp
    {
        static void Main(string[] args)
        {
            Scale<int> scale = new Scale<int>();
            scale.Compare(2, 4);
            Console.WriteLine(scale);
        }
    }
}
