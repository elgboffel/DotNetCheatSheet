using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace DotNetCheatSheet.Threads
{
    public class ThreadsEG
    {
        static void ThreadsEGMain(string[] args)
        {
            for (int i = 0; i < 200; i++)
            {
                var thread = new Thread(new ThreadStart(Work));
                thread.Start();

                //Optimized performance. Once a thread is done, it will be reused for a new Task
                Task.Run(() => {
                    Console.WriteLine("Starting task in thread: " + Thread.CurrentThread.ManagedThreadId);
                    Thread.Sleep(3000);
                    Console.WriteLine("Task Complete");
                });
            }
        }

        //This can cause our system to lag since each task will be a new Thread
        static void Work()
        {
            Console.WriteLine("Starting in thread: " + Thread.CurrentThread.ManagedThreadId);
            Thread.Sleep(3000);
            Console.WriteLine("Work Complete");
        }
    }
}
