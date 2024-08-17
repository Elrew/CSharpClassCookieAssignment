using System.Diagnostics;
using System.Security.Cryptography.X509Certificates;

namespace CookieCookBook
{
    internal class Program
    {
        
        static void Main(string[] args)
        {
            bool running = true;   
            List<string> mainMenu = new List<string>
            {
                "1) Open Saved Recipes",
                "2) Create New Recipe",
                "3) Exit Application"
            };


            do
            {
                Console.SetWindowSize(110, 50);
                WriteBorder();
                WriteMenus(mainMenu, 2, 1);
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
                        running = false;
                        break;
                }


            } while (running);

        }


        
        static void WriteMenus(List<string> x, int xPos, int yPos)
        {
            foreach (string item in x)
            {
                Console.SetCursorPosition(xPos, yPos);
                yPos++;
                Console.WriteLine(item);
            }
        }

        static void WriteBorder()
        {
            //top 
            for(int i = 0; i <=109 ; i++)
            {
                Console.SetCursorPosition(i,0);
                Console.WriteLine("#");
            }
            //bottom
            for (int i = 0; i <= 109; i++)
            {
                Console.SetCursorPosition(i, 48);
                Console.WriteLine("#");
            }
            //left
            for (int i = 0; i <= 48; i++)
            {
                Console.SetCursorPosition(1, i);
                Console.WriteLine("#");
            }
            //right
            for (int i = 0; i <= 48; i++)
            {
                Console.SetCursorPosition(110, i);
                Console.WriteLine("#");
            }
        }
    }
}
