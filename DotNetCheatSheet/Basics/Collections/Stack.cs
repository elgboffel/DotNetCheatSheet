using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DotNetCheatSheet
{
    public class Stack
    {
        static void StackMain(string[] args)
        {
            //Last iteme to come in is first to come out
            var pancakes = new Stack<string>();

            pancakes.Push("First pancake made");
            pancakes.Push("Second pancake made");
            pancakes.Push("Third pancake made");

            foreach (var item in pancakes)
            {
                Console.WriteLine(item);
            }

            //Gets the last item and removes it from the stack
            Console.WriteLine(pancakes.Pop());

            //Shows the last item but without removing it
            Console.WriteLine(pancakes.Peek());
        }
    }
}
