using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DotNetCheatSheet.Collections
{
    public class Dictionary
    {
        static void DictionaryMain()
        {
            //Dictionary will break with dublicate keys
            //Dictionary is extremly fast when it comes to finding a certain
            //Key within the collection. It is however slow when finding a certain value
            //in that case HashSet is fastest and List is even faster aswell
            var dictionary = new Dictionary<string, string>();

            dictionary.Add("Tv", "Samsung");
            dictionary.Add("Tommer", "32");

            foreach (var item in dictionary)
            {
                Console.WriteLine(item.Value);
            }

            //Gets the keys value
            Console.WriteLine(dictionary["Tv"]);
        }
    }
}
