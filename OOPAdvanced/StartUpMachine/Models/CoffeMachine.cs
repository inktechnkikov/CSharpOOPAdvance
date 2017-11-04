using StartUpMachine.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StartUpMachine.Models
{
   public class CoffeMachine
    {
        private int coins;
        private IList<CoffeType> coffeSold;

       public IEnumerable<CoffeType> CoffeSold
        {
            get
            {
                return this.coffeSold;
            }
        }
        public CoffeMachine()
        {
            this.coffeSold = new List<CoffeType>();
        }
        public void BuyCoffee(string size,string type)
        {

            CoffePrice coffePrice = (CoffePrice)Enum.Parse(typeof(CoffePrice), size);
            CoffeType coffeType = (CoffeType)Enum.Parse(typeof(CoffeType), type);
            if(this.coins >= (int)coffePrice)
            {
                this.coffeSold.Add(coffeType);
                this.coins = 0;
            }
        }
        public void InsertCoin(string coin)
        {
            Coins coins = (Coins)Enum.Parse(typeof(Coins), coin);
            this.coins += (int)coins;
        }
    }
}
