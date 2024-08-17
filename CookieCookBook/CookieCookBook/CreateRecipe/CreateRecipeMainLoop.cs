using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CookieCookBook.CreateRecipe
{
    internal class CreateRecipeMainLoop
    {

        public static void MainLoop()
        {
            List<string> menuOptions = new List<string>
            {
                "1) Flours",
                "2) Sweeteners",
                "3) Wet Ingredients",
                "4) Flavor Enhancers",
                "5) Go Back",

            };
            bool running = true;

            Console.Clear();
            Program.WriteBorder();
            Program.WriteMenus(menuOptions,10,10);

            do 
            {


                ConsoleKey keyPressed = Console.ReadKey().Key;

                switch(keyPressed)
                {
                    case ConsoleKey.D1:
                    case ConsoleKey.NumPad1:
                        FlourMainFunctions.MainLoop();
                        break;
                    case ConsoleKey.D2:
                    case ConsoleKey.NumPad2:
                        break;
                    case ConsoleKey.D3:
                    case ConsoleKey.NumPad3:
                        break;
                    case ConsoleKey.D4:
                    case ConsoleKey.NumPad4:
                        break;
                    case ConsoleKey.D5:
                    case ConsoleKey.NumPad5:
                        running = false;
                        break;

                }
            } while (running);
        }

    }
}
