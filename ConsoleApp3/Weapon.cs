using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp3
{
    public class Weapon
    {
        private string name;
        private int durability;
        private int strength;
        private double weight;

        public Weapon(string name, int durability, int strength, double weight)
        {
            this.name = name;
            this.durability = durability;
            this.strength = strength;
            this.weight = weight;
        }

        public class WeaponBuilder
        {
            private string name;
            private int durability;
            private int strength;
            private double weight;

            public WeaponBuilder SetName(string name)
            {
                this.name = name;
                return this;
            }

            public WeaponBuilder SetDurability(int durability)
            {
                this.durability = durability;
                return this;
            }

            public WeaponBuilder SetStrength(int strength)
            {
                this.strength = strength;
                return this;
            }

            public WeaponBuilder SetWeight(double weight)
            {
                this.weight = weight;
                return this;
            }

            public Weapon Build()
            {
                return new Weapon(name, durability, strength, weight);
            }
        }
    }
}
