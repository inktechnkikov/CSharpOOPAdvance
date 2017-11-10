using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CoffeFactoryDemo
{
   public class Coffe
    {

        private int MilkContent;
        private int CoffeeContent;

        public int GetCoffeContent
        {
            get { return CoffeeContent; }
            set { CoffeeContent = value; }
        }

        public int GetMilkContent
        {
            get { return MilkContent; }
            set { MilkContent = value; }
        }
        public Coffe(int milk,int coffee)
        {
            this.MilkContent = milk;
            this.CoffeeContent = coffee;
        }

    }
}
