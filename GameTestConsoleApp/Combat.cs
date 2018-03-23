using System;
using System.Collections.Generic;
using System.Text;

namespace GameTestConsoleApp
{
    class Combat
    {
        //public Player SolveCombat(Player player, Enemies enemy, out bool winBool)
        //{
        //    while (enemy.health > 0)
        //    {
        //        if (player.health > 0)
        //        {
        //            player.health = player.health - enemy.damage;
        //            enemy.health = enemy.health - player.damage;
        //        }
        //        else
        //        {
        //            break;
        //        }
        //    }
        //    if (player.health > 0)
        //    {
        //        winBool = true;
        //        return player;
        //    }
        //    else
        //    {
        //        winBool = false;
        //        return player;
        //    }

        //}

        public void UpdatePlayerStats(Player player, Weapons weapon)
        {
            Console.WriteLine("Your current health is: " + player.health);
            Console.WriteLine("Your current weapon durability is " + weapon.durability);
            Console.WriteLine("___________________________________________________");
        }


        public Player SolveCombat2(Player player, Enemies enemy)
        {
            while (enemy.health > 0 && player.health > 0)
            {
                player.health -= enemy.damage;
                enemy.health -= player.damage;
            }
            if (player.health < 0)
            {
                Console.WriteLine("You've been defeated by a " + enemy.name);
                return player;
            }
            else
            {
                Console.WriteLine("You've won the fight against " + enemy.name);
                return player;
            }
        }


        public Weapons DecreaseDurability(Weapons playerWeapon, Enemies enemyWeight)
        {
            playerWeapon.durability = playerWeapon.durability - (enemyWeight.weight * 0.2);
            return playerWeapon;
        }

        public void ResetEnemy(Enemies deadEnemy)
        {
            
        }
    }
}
