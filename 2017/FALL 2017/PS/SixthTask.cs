using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp13
{
    class Program
    {
        static void Main(string[] args)
        {
            int N  = Convert.ToInt32(Console.ReadLine());
            int factorial = 1;
            for (int i = 1; i <= N; i++)
            {
                
                factorial *= i;
            }
            int lastNum = factorial % 10;
            Console.WriteLine(lastNum);
        }
        
    }
}
