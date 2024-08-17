using CookieCookBook.CreateRecipe;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace CookieCookBook
{
    internal class Flours
    {
        public readonly bool isAFlour = true;
        public string name;
        public string description;


    }

    class AllPurposeFlour : Flours
    {
        
        public AllPurposeFlour(string _name,string _description)
        {
            name = _name;
            description = _description;
        }

    }

    class BreadFlour : Flours
    {
        public BreadFlour(string _name)
        {
            _name = name;
        }
    }

    class CakeFlour : Flours
    {
        public CakeFlour(string _name)
        {
            _name = name;
        }
    }

    class PastryFlour : Flours
    {
        public PastryFlour(string _name)
        {
            _name = name;
        }
    }

    class AlmondFlour : Flours
    {
        public AlmondFlour(string _name)
        {
            _name = name;
        }
    }

    class Sand : Flours
    {
        public Sand(string _name)
        {
            _name = name;
        }
    }

    class Cornmeal : Flours
    {
        public Cornmeal(string _name)
        {
            _name = name;
        }
    }

    class Oatmeal : Flours
    {
        public Oatmeal(string _name)
        {
            _name = name;
        }
    }

    class FlourMainFunctions
    {
        public static void MainLoop()
        {
            bool running = true;
            string _APFdescription = "A general purpose flour. Cookies that contain all purpos flour generally have a " +
                              "balanced texture, providing a good combination of tenderness and structure, making  " +
                              "it versatile for a variety of cookie types, from soft and chewy to crisp and firm.";
            Console.Clear();
            Program.WriteBorder();
            Program.WriteMenus(Program.logo, 2, 1);
            Program.WriteMenus(Ingredients.flours,10,10);
            
            do
            {
                ConsoleKey keyPressed = Console.ReadKey().Key;

                switch (keyPressed)
                {
                    case ConsoleKey.D1:
                    case ConsoleKey.NumPad1:
                        // make sure the check matches witth this so if the user says no, it doesn't add it anyway. 
                        AllPurposeFlour APF = new AllPurposeFlour("All Purpose Flour", _APFdescription);
                        Program.TextWrap(APF.description, 50,10,30);
                        CreateRecipeMainLoop.AddToRecipe("APF", 10, 40);
                        Console.ReadKey();
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
                        break;
                    case ConsoleKey.D6:
                    case ConsoleKey.NumPad6:
                        break;
                    case ConsoleKey.D7:
                    case ConsoleKey.NumPad7:
                        break;
                    case ConsoleKey.D8:
                    case ConsoleKey.NumPad8:
                        break;
                    case ConsoleKey.D9:
                    case ConsoleKey.NumPad9:
                        running = false;
                        break;

                }
            } while (running);



            
        }
    }
}


