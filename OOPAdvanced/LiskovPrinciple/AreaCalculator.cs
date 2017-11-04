using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LiskovPrinciple
{
   public class AreaCalculator
    {
        public static double CalcualteArea(Rectangle r)
        {
            return r.Height * r.Width;
        }
        public static double CalculateArea(Square s)
        {
            return s.Height * s.Height;
        }
    }
}
