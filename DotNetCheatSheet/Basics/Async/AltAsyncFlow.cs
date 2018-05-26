using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace DotNetCheatSheet.Async
{
    public class AltAsyncFlow
    {
        //Alternate way, to do async requests with callpack functions and Task.
        static void AltAsyncFlowMain(string[] args)
        {
            Console.WriteLine("Downloading...");
            Download();
            Console.ReadLine();
        }

        static void Download()
        {
            //Anonymus function using callback message
            Network.Download((message) => Console.WriteLine("Download completed: " + message));
        }
    }

    public class Network
    {
        //Action used to make a callback function
        static public void Download(Action<string> callback)
        {
            Task.Run(() => {
                Thread.Sleep(3000);
                callback("Callback message");
            });
        }
    }
}
