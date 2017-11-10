using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WarFactoryDemo
{
    class BattleMachine : IWarMachine
    {
        private int ammo;
        private int armor;
        private int damage;
        private int speed;

        public BattleMachine(int ammo,int armor,int damage,int speed)
        {
            this.ammo = ammo;
            this.armor = armor;
            this.damage = damage;
            this.speed = speed;
        }

        public int Ammo()
        {
            return this.ammo;
        }

        public int Armor()
        {
            return this.armor;
        }

        public int Damage()
        {
            return this.damage;
        }

        public string GetMachineParams()
        {
            return $"{this.ammo} {this.armor} {this.damage} {this.speed}";
        }

        public int Speed()
        {
            return this.speed;
        }
    }
}
