using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Expr3._0
{
    class Program
    {
        static void Main(string[] args)
        {
            int H = 3;
            int b = 6 - H;
            int c = 180 - Math.Abs(b) * 30;
            Console.WriteLine(c);
        }
    }
}
