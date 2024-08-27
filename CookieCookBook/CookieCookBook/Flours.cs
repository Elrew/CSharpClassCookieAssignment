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
        public BreadFlour(string _name, string _description)
        {
            name = _name;
            description = _description;
        }
    }

    class CakeFlour : Flours
    {
        public CakeFlour(string _name, string _description)
        {
            name = _name;
            description = _description;
        }
    }

    class PastryFlour : Flours
    {
        public PastryFlour(string _name, string _description)
        {
            name = _name;
            description = _description;
        }
    }

    class AlmondFlour : Flours
    {
        public AlmondFlour(string _name, string _description)
        {
            name = _name;
            description = _description;
        }
    }

    class Sand : Flours
    {
        public Sand(string _name, string _description)
        {
            name = _name;
            description = _description;
        }
    }

    class Cornmeal : Flours
    {
        public Cornmeal(string _name, string _description)
        {
            name = _name;
            description = _description;
        }
    }

    class Oatmeal : Flours
    {
        public Oatmeal(string _name, string _description)
        {
            name = _name;
            description = _description;
        }
    }

    class FlourMainFunctions
    {
        static ConsoleKey keyPressed;
        public static void MainLoop()
        {
            bool running = true;
            
            string _APFDescription = "All purpose flour: Cookies that contain all purpos flour generally have a " +
                              "balanced texture, providing a good combination of tenderness and structure, making  " +
                              "it versatile for a variety of cookie types, from soft and chewy to crisp and firm.";

            string _BFDescription = "Bread Flour: Cookies that contain bread flour tend to be chewier and denser, " +
                "with a more substantial bite, due to the higher protein content that develops more gluten compared to" +
                " all-purpose flour. This can make the cookies less tender and more structured, giving them a slightly " +
                "different texture than those made with all-purpose or cake flour";

            string _CFDescription = "Cake Flour: Cookies that contain cake flour tend to be lighter and softer " +
                " in texture due to the lower protein content of the flour. " +
                " This makes them ideal for cookies that are almost cake-like, such as sugar cookies or soft-batch" +
                " chocolate chip cookies.";

            string _PFDescription = "Pastry flour. Cookies that contain pastry flour are typically tender and delicate, with a fine" +
                " crumb, making them perfect for recipes like shortbread, butter cookies, and other baked goods where a soft, " +
                "melt-in-your-mouth texture is desired.";

            string _AFDescription = "Almond flour. Cookies that contain almond flour are a popular choice for those who are gluten " +
                "intolerant, offering a moist, tender texture with a slightly nutty flavor, making them both delicious and suitable" +
                " for gluten-free diets.";

            string _SandDescription = "Sand. Cookies that contain sand have a gritty texture that sticks with you all day long. It is " +
                "a great way to feel like a pirate, school teacher, or any one who has ever had a nice day at a windy beach. Enjoy in" +
                " moderation as sand is known to destroy your kidneys after consuming just a few pounds";

            string _CMDescription = "Cornmeal. Cookies that contain cornmeal have a unique texture with a " +
                "subtle crunch and a slightly nutty, sweet flavor that adds a delightful contrast to the softness of the dough.";

            string _OMDescription = "Oatmeal. Cookies that contain oatmeal are often chewy, hearty, and have a slightly nutty flavor, making them perfect for adding raisins, nuts, or chocolate chips for extra texture and taste.";

            ReprintOptions();
            do
            {

                keyPressed = Console.ReadKey().Key;
                ReprintOptions();

                switch (keyPressed)
                {
                    case ConsoleKey.D1:
                    case ConsoleKey.NumPad1:
                        // make sure the check matches with this so if the user says no, it doesn't add it anyway. 
                        AllPurposeFlour APF = new AllPurposeFlour("All Purpose Flour", _APFDescription);
                        Program.TextWrap(APF.description, 50,10,50);
                        CreateRecipeMainLoop.AddToRecipe("APF");
                        ReprintOptions();
                        break;
                    case ConsoleKey.D2:
                    case ConsoleKey.NumPad2:
                        BreadFlour BF = new BreadFlour("Bread Flour", _BFDescription);
                        Program.TextWrap(BF.description, 50, 10, 50);
                        CreateRecipeMainLoop.AddToRecipe("BF");
                        ReprintOptions();
                        break;
                    case ConsoleKey.D3:
                    case ConsoleKey.NumPad3:
                        CakeFlour CF = new CakeFlour("Cake Flour", _CFDescription);
                        Program.TextWrap(CF.description, 50, 10, 50);
                        CreateRecipeMainLoop.AddToRecipe("CF");
                        ReprintOptions();
                        break;
                    case ConsoleKey.D4:
                    case ConsoleKey.NumPad4:
                        PastryFlour PF = new PastryFlour("Pastry Flour", _PFDescription);
                        Program.TextWrap(PF.description, 50, 10, 50);
                        CreateRecipeMainLoop.AddToRecipe("PF");
                        ReprintOptions();
                        break;
                    case ConsoleKey.D5:
                    case ConsoleKey.NumPad5:
                        AlmondFlour AF = new AlmondFlour("Almond Flour", _AFDescription);
                        Program.TextWrap(AF.description, 50, 10, 50);
                        CreateRecipeMainLoop.AddToRecipe("AF");
                        ReprintOptions();
                        break;
                    case ConsoleKey.D6:
                    case ConsoleKey.NumPad6:
                        Sand sand = new Sand("Sand", _SandDescription);
                        Program.TextWrap(sand.description, 50, 10, 50);
                        CreateRecipeMainLoop.AddToRecipe("Sand");
                        ReprintOptions();
                        break;
                    case ConsoleKey.D7:
                    case ConsoleKey.NumPad7:
                        Cornmeal CM = new Cornmeal("Cornmeal", _CMDescription);
                        Program.TextWrap(CM.description, 50, 10, 50);
                        CreateRecipeMainLoop.AddToRecipe("CM");
                        ReprintOptions();
                        break;
                    case ConsoleKey.D8:
                    case ConsoleKey.NumPad8:
                        Oatmeal OM = new Oatmeal("Oatmeal", _OMDescription);
                        Program.TextWrap(OM.description, 50, 10, 50);
                        CreateRecipeMainLoop.AddToRecipe("AF");
                        ReprintOptions();
                        break;
                    case ConsoleKey.D9:
                    case ConsoleKey.NumPad9:
                        running = false;
                        break;

                }
            } while (running);



            
        }

        public static void ReprintOptions()
        {
            Console.Clear();
            Program.WriteBorder();
            Program.WriteMenus(Program.logo, 2, 1);
            Program.WriteMenus(Ingredients.flours, 10, 10);
        }
    }
}


