using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Expr2
{
    class Program
    {
        static void Main(string[] args)
        {
            int a = 123;
            int b = (a%10);
            b = b * 100 + ((a % 100)/10)*10 + a / 100;
            Console.WriteLine(b);
            
        }
    }
}
