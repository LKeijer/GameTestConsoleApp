using System;
using System.Collections.Generic;
using System.Text;

namespace GameTestConsoleApp
{
    public class TestClass
    {
        public string TestReadKey()
        {
                //From MSDN

            ConsoleKeyInfo ckiStruct; //Struct that holds which button has been pressed, and the state of the shift, alt and control modifier keys

                //Prevent example from ending if CTL + C is pressed.

            Console.TreatControlCAsInput = true;


            Console.WriteLine("Press any combination of CTL, ALT, and SHIFT, and a console key.");
            Console.WriteLine("Press the Escape (Esc) key to quit: \n");
            Console.WriteLine("------------Press 1 to create a character------------");

            //Logic for determining which key has been pressed
            var keyPress = Console.ReadKey(true); //true sets it to hide the key input
            
            if (keyPress.Key == ConsoleKey.D1)
            {
                Console.WriteLine("Please enter your name:");
                Console.ReadLine(); //Return user input to set as character name <-----TODO
            }
            else
            {
                Console.WriteLine("Press 1 for character creation");
            }



            //MSDN
            do
            {
                ckiStruct = Console.ReadKey(true);

                if ((ckiStruct.Modifiers & ConsoleModifiers.Alt) != 0) Console.Write("ALT+");
                if ((ckiStruct.Modifiers & ConsoleModifiers.Shift) != 0) Console.Write("SHIFT+");
                if ((ckiStruct.Modifiers & ConsoleModifiers.Control) != 0) Console.Write("CTL+");
                Console.WriteLine(ckiStruct.Key.ToString());
            }
            while (ckiStruct.Key != ConsoleKey.Escape);

                //Dummycode to return a string
            string x = string.Empty;
            return x;
        }
    }
}
