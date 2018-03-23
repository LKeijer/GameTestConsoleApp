using System;
using System.Collections.Generic;
using System.Text;

namespace GameTestConsoleApp
{
    public class Player
    {
        public string characterName { get; set; }
        public int damage { get; set; }
        public int health { get; set; }
        public int strenght { get; set; }
        public int intelligence { get; set; }
        public int level { get; set; }

        public Player ()
        {
            health = 100;
            strenght = 10;
            intelligence = 5;
        }

        public Player (string name)
        {
            characterName = name;
        }
            

    }
}
