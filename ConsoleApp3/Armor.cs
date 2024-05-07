using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp3
{
    using System;

    public class Armor
    {
        private string name;
        private int durability;
        private int defence;

        public Armor(string name, int durability, int defence)
        {
            this.name = name;
            this.durability = durability;
            this.defence = defence;
        }

        public class ArmorBuilder
        {
            private string name;
            private int durability;
            private int defence;

            public ArmorBuilder SetName(string name)
            {
                this.name = name;
                return this;
            }

            public ArmorBuilder SetDurability(int durability)
            {
                this.durability = durability;
                return this;
            }

            public ArmorBuilder SetDefence(int defence)
            {
                this.defence = defence;
                return this;
            }

            public Armor Build()
            {
                return new Armor(name, durability, defence);
            }
        }
    }

}
