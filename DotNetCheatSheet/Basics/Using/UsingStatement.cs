using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DotNetCheatSheet.Using
{
    public class Ressource : IDisposable
    {
        public void Dispose()
        {
            Console.WriteLine("Disposing our resource");
        }
    }

    public class UsingStatement
    {
        static void UsingStatementMain(string[] args)
        {
            //using will automaticly call the dispose method and close the ressorurce
            //required it has a dispose method
            using (var ressource = new Ressource())
            {
                Console.WriteLine("Using my ressource");
            }
            Console.WriteLine("Finished");
        }
    }
}
