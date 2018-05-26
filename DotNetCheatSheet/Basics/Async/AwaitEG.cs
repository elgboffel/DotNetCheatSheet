using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;

namespace DotNetCheatSheet.Async
{
    public class AwaitEG
    {
        static void AwaitMain(string[] args)
        {
            Console.WriteLine("Downloading...");
            download();
            Console.ReadLine();
        }

        static async void download()
        {
            var client = new HttpClient();

            var data = await client.GetStringAsync("http://www.mccode.dk");
            Console.WriteLine(data);
        }
    }
}
