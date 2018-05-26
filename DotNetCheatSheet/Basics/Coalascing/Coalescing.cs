using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DotNetCheatSheet
{
   public class Person
    {
        public string Name { get; set; }
    }

    public class Coalescing
    {
        static void CoalescingMain(string[] args)
        {
            string s = null; //"Yo";
            var s2 = s ?? "default";

            //Coalescing has to be null to work, so using nullable with int
            //Otherwise they will be atleast have the value 0 and not be null;
            int? i = null;
            var i2 = i ?? 100;

            Console.WriteLine(s2);

            Console.WriteLine(i2);

            //Conditional null checking
            Person person = null; // new Person() { Name = "Johnny" };

            //Traditional null check
            //if (person != null)
            //    Console.WriteLine(person.Name);

            //nested null conditional opreator
            Console.WriteLine(person?.Name?.Length);

            Console.WriteLine(person?.Name ?? "No Name");
        }
    }
}
