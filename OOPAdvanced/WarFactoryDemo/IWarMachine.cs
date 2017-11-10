using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WarFactoryDemo
{
   public interface IWarMachine
    {
        int Damage();
        int Speed();
        int Armor();
        int Ammo();
        string GetMachineParams();
    }
}
