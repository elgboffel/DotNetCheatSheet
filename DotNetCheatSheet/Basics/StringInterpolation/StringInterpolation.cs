using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DotNetCheatSheet.StringInterpolation
{
    public class StringInterpolation
    {
        static void StringInterpolationMain(string[] args)
        {
            var point = new { x = 1.123456, y = 2.7654321 };

            Console.WriteLine($"x {point.x:N2} y {point.y,10:N2}");
        }
    }
}
