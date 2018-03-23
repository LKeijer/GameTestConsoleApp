using System;
using System.Collections.Generic;
using System.Text;

namespace GameTestConsoleApp
{
    public abstract class Enemies
    { 
            //integers
        public int damage { get; set; }
        public int health { get; set; }
        public int level { get; set; }

        //doubles
        public double weight { get; set; }

        //strings
        public string name { get; set; }

        public abstract void ResetEnemy();
    }

    public class Rat : Enemies
    {
        public Rat()
        {
            damage = 5;
            health = 20;
            level = 0;
            weight = 0.5;
            name = "Rat";
        }
        public override void ResetEnemy()
        {
            damage = 5;
            health = 20;
            level = 0;
            weight = 0.5;
            name = "Rat";
        }
    }

    public class Wolf : Enemies
    {
        public Wolf()
        {
            damage = 12;
            health = 40;
            level = 1;
            weight = 5;
            name = "Wolf";
        }
        public override void ResetEnemy()
        {
            damage = 12;
            health = 40;
            level = 1;
            weight = 5;
            name = "Wolf";
        }

        
    }

}
