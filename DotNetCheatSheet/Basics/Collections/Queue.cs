using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DotNetCheatSheet
{
    public class Queue
    {
        static void QueueMain(string[] args)
        {
            //First item to come in is first to come out
            var queue = new Queue<int>();

            queue.Enqueue(1);
            queue.Enqueue(2);
            queue.Enqueue(3);

            foreach (var item in queue)
            {
                Console.WriteLine(item);
            }

            //Gets the first item and removes it from the queue
            Console.WriteLine(queue.Dequeue());

            //Shows the first item but without removing it
            Console.WriteLine(queue.Peek());
        }
    }
}
