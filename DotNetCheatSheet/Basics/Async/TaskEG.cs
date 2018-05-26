using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace DotNetCheatSheet.Async
{
    public class TaskEG
    {
        static void TaskMain(string[] args)
        {
            Console.WriteLine("Downloading...");
            download();
            Console.ReadLine();
        }

        static void download()
        {
            //Task represents a single async operation that does not return a value
            //Task.Run uses and anonymus function to run code, a simple way to do an
            //async operation
            System.Threading.Tasks.Task.Run(() =>
            {
                Thread.Sleep(3000); // Simulate an async call
                Console.WriteLine("Download Complete");
            });
        }
    }
}
