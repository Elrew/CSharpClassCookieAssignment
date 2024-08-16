namespace CookieCookBook
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.SetWindowSize(110, 50);
            WriteBorder();
            Console.ReadKey();

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


        }
    }
}
