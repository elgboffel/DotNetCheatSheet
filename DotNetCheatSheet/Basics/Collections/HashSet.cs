using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DotNetCheatSheet.Collections
{
    public class HashSet
    {
        static void HashSetMain()
        {
            //Hash will remove dublicate values
            //Hash is extremly fast when it comes to finding a certain
            //value within the collection
            var hash = new HashSet<string>();

            hash.Add("Yo");
            hash.Add("Yo");

            Console.WriteLine(hash.Count());
        }
    }
}
