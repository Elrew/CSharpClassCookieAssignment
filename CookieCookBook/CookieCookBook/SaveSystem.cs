using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;

namespace CookieCookBook
{
    internal class SaveSystem
    {
        public static List<List<object>> SavedRecipeLists = new List<List<object>>();
        // this saves the whole thing, not just serialize. So, bad naming convetion but Idgaff right now 
        public static void SerializeToJSON() 
        {
            string jsonString = JsonSerializer.Serialize(Buffer.bufferedRecipe);
            string directoryPath = Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments), "CookieRecipes");
            string filePath = Path.Combine(directoryPath, "SavedRecipes.json");
            if (SavedRecipes.folderExists)
            {
                // need to make a check to make sure I am not recreating a bunch of recipes that are already in the file. 
                File.AppendAllText(filePath, jsonString);
                Buffer.bufferedRecipe.Clear();
            }
            else
            {
                Directory.CreateDirectory(directoryPath);
                File.AppendAllText(filePath, jsonString);
                Buffer.bufferedRecipe.Clear();
            }


        }

        public static void LoadSaveRecipes()
        {
            string path = Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments), "CookieRecipes", "SavedRecipes.json");
            string jsonContent = File.ReadAllText(path);
            var savedJSONToVar = JsonSerializer.Deserialize<string[]>(jsonContent);
        }

        public static void BuildRecipeFromList(List<object> JSONFile)
        {
            foreach(List<object> line in JSONFile)
            {
                if (line != null)
                {
                    break;
                }

                SavedRecipeLists.Add(line);

            }


        }

    }

    internal class SavedRecipes
    {
        public static bool folderExists = Directory.Exists(Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments), "CookieRecipes"));
        public static bool CheckSaveFolder()
        {
            if (folderExists)
            {
                return true;
            }
            return false;
        }
    }
}
