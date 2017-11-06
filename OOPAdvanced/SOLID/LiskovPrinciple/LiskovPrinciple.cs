using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LiskovPrinciple
{
    class LiskovPrinciple
    {
        static void Main(string[] args)
        {
            Square square = new Square();
            square.Height = 3;
            Rectangle rectangle = new Rectangle
            {
                Height = 2,
                Width = 3
            };
            double rectangleResult = AreaCalculator.CalcualteArea(rectangle);
            double squareResult = AreaCalculator.CalculateArea(square);
            Console.WriteLine(rectangleResult);
            Console.WriteLine(squareResult);
        }
    }
}
