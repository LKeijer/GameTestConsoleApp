﻿using System;
using System.Collections.Generic;
using System.Text;

namespace GameTestConsoleApp
{
    public class Player
    {
            //Declarations
        public string characterName { get; set; }
        public int damage { get; set; }
        public int health { get; set; }
        public int strenght { get; set; }
        public int intelligence { get; set; }
        public int level { get; set; }

            //Constructor that takes a string and creates a new player object with characterName set.
        public Player (string name)
        {
            characterName = name;
        }

        public void SetBaseStats()
        {
            health = 100;
            strenght = 10;
            intelligence = 5;
        }
            

    }
}
