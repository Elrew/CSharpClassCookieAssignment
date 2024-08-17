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
            Program.WriteMenus(Program.logo, 2, 1);
            Program.WriteMenus(menuOptions, 10, 10);

            do
            {


                ConsoleKey keyPressed = Console.ReadKey().Key;

                switch (keyPressed)
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

        public static void AddToRecipe(string ingredientName, int x, int y)
        {
            string add = "Do you want to add this ingredient to the current recipe? [Y/N]";
            Program.TextWrap(add, 50, 20, 30);
            string answer = Console.ReadLine();
            if (answer.ToLower() == "y" || answer.ToLower() == "yes")
            {
                Buffer.bufferedRecipe.Add(ingredientName);
            }
            else if (answer.ToLower() == "n" || answer.ToLower() == "no")
            {

            }
            else
            {
                Console.SetCursorPosition(20, 10);
                Console.WriteLine("Invalid input. Please try again");
                Console.ReadKey();
            }
        }
    }

    
}
