using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DotNetCheatSheet.Collections
{
    public class List
    {
        static void ListMain()
        {
            //Hash will remove dublicate values
            //Hash is extremly fast when it comes to adding a new item,
            //faster then dictionary or HashSet, since they are checking for dublicates
            //and rebuilding hash.
            //Slow when finding certain value
            var hash = new HashSet<string>();

            hash.Add("Yo");
            hash.Add("Yo");

            Console.WriteLine(hash.Count());
        }
    }
}
