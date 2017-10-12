using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp12
{
    class Program
    {
        
        static void Count(int a)
        {
            while (a > 0)

            {
                int n = 0;
                a /= 10;
                n =n + 1;
            }
        }
        static bool Main(int k)
        {
            
            double sum = 0;
            for (int i = 0; i <= n; i++)
            {
                
                int m = a % 10;
                a /= 10;
                if (m == 1)
                {
                    sum += Math.Pow(2, i);
                }
            }

            return sum / k == 0;

        }



    }
}
