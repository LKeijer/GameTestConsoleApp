using System;

namespace GameTestConsoleApp
{
    class Program
    {

        static void Main(string[] args)
        {

            #region 1st
                //Creates a player object with the variable name currentplayer.
            //Player currentPlayer = new Player();

                //Prints out the current stats of the Player object
            //Console.WriteLine("Current HP = {0}, Current Strenght = {1}, Current Intelligence = {2}", currentPlayer.health, currentPlayer.strenght, currentPlayer.intelligence);

                //Creates a new ShortSword object with the variable name currentWeapon.
            //ShortSword currentWeapon = new ShortSword();\

                //Sets the Player object 'damage' property as the 'damage' property of the ShortSword object. <--------This needs to be in a seperate class called Equip or something.
            //currentPlayer.damage = currentWeapon.damage;

                //Prints out the stats of the current ShortSword object
            //currentWeapon.ShowWeapon();

                    //Combat related
            //Combat combat = new Combat();
            //Rat rat = new Rat();

                    //Starts a fight with a rat
            //if (currentPlayer.health > 0)
            //{
            //    combat.SolveCombat2(currentPlayer, rat);
            //    rat.ResetEnemy();
            //    combat.DecreaseDurability(currentWeapon, rat);
            //    combat.UpdatePlayerStats(currentPlayer, currentWeapon);
            //}
            //else
            //{
            //    Console.WriteLine("You died, game over");
            //}

                    //Starts a fight with a wolf 5 times
            //Wolf wolf = new Wolf();
            //{
            //    for (int i = 0; i < 5; i++)
            //    {
            //        if (currentPlayer.health > 0)
            //        {
            //            combat.SolveCombat2(currentPlayer, wolf);
            //            wolf.ResetEnemy();
            //            combat.DecreaseDurability(currentWeapon, wolf);
            //            combat.UpdatePlayerStats(currentPlayer, currentWeapon);
            //        }
            //        else
            //        {
            //            Console.WriteLine("You died, game over");
            //        }
            //    }
            //}

            //Console.ReadKey();
            #endregion



            TestClass test = new TestClass();
            test.TestReadKey();
        }
    }
}
