using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CookieCookBook
{
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
