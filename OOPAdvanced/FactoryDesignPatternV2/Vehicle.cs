using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FactoryDesignPatternV2
{
   public interface Vehicle
    {
        string GetEngine();
        int GetHP();
        int GetMaxSpeed();
        string PrintVehicleInfo();
    }
}
