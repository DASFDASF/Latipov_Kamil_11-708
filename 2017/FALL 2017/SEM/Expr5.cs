using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Expr5
{
    class Program
    {
        static void Main(string[] args)
        {
            int a = 1809;
            int b = 1912;
            int c = b - a;
            int d = c / 4;
            d -= (d * 4) / 100;
            d += ((d * 100) / 4) / 400;
            Console.WriteLine(d);
            

        }
    }
}
