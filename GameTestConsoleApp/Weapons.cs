using System;
using System.Collections.Generic;
using System.Text;

namespace GameTestConsoleApp
{
    public abstract class Weapons
    {
        public int damage;
        public double durability;
        public string name;
    }

    public class ShortSword : Weapons
    {
        public ShortSword()
        {
            name = "ShortSword";
            damage = 10;
            durability = 20;
        }

        public void ShowWeapon()
        {
            Console.WriteLine("Currently Equipped: "+name);
            Console.WriteLine("The damage is " + damage.ToString());
            Console.WriteLine("Durability is " + durability.ToString());
        }
    }

}
