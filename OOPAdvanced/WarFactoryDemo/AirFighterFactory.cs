using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WarFactoryDemo
{
    class AirFighterFactory : IMachineBuilder
    {
        private int ammo;
        private int armor;
        private int damage;
        private int speed;

        public AirFighterFactory(int ammo,int armor,int damage,int speed)
        {
            this.ammo = ammo;
            this.armor = armor;
            this.damage = damage;
            this.speed = speed;
        }

        public IWarMachine BuildMachine()
        {
            return new BattleMachine(ammo, armor, damage,
                speed);
        }
    }
}
