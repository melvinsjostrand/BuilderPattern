using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp3
{
    public class Soldier
    {
        private string name;
        private int health;
        private int age;
        private List<Armor> armors;
        private Weapon weapon;

        public Soldier(string name, int health, int age, List<Armor> armors, Weapon weapon)
        {
            this.name = name;
            this.health = health;
            this.age = age;
            this.armors = armors;
            this.weapon = weapon;
        }

        public string GetName()
        {
            return name;
        }

        public void SetName(string name)
        {
            this.name = name;
        }

        public int GetHealth()
        {
            return health;
        }

        public void SetHealth(int health)
        {
            this.health = health;
        }

        public int GetAge()
        {
            return age;
        }

        public void SetAge(int age)
        {
            this.age = age;
        }

        public List<Armor> GetArmors()
        {
            return armors;
        }

        public void SetArmors(List<Armor> armors)
        {
            this.armors = armors;
        }

        public Weapon GetWeapon()
        {
            return weapon;
        }

        public void SetWeapon(Weapon weapon)
        {
            this.weapon = weapon;
        }
    }
}
