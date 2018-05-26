using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DotNetCheatSheet
{
    public class Tuple
    {
        static void TupleMain(string[] args)
        {
            //E.G. use tuple when you want to return multiple value from a
            // function and not wanting to create a class
            var tuple = new Tuple<int, string, bool>(1, "Yo", true);

            Console.WriteLine(tuple.Item2);
        }
    }
}
