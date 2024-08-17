using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CookieCookBook
{
    internal class Flours
    {
        public readonly bool isAFlour = true;
        public string name;


    }

    class AllPurposeFlour : Flours
    {
        public AllPurposeFlour(string _name)
        {
            _name = name;
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

            Console.Clear();
            Program.WriteBorder();
            Program.WriteMenus(Ingredients.flours,10,10);
            
            do
            {
                ConsoleKey keyPressed = Console.ReadKey().Key;

                switch (keyPressed)
                {
                    case ConsoleKey.D1:
                    case ConsoleKey.NumPad1:
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


