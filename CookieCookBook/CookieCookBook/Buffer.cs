using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CookieCookBook
{
    internal class Buffer
    {

        public static List<object> bufferedRecipe = new List<object>();

        public static void FinishRecipe()
        {
            // this will solidify anything in the buffer list and then kick off the save to JSON 
        }
    }
}
