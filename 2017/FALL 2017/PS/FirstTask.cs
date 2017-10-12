using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PS1
{
    class Program
    {
        static void Main(string[] args)
        {
            int ticket = Convert.ToInt32(Console.ReadLine());
            int sumOne = (ticket / 100000) + ((ticket % 100000) / 10000) + ((ticket % 10000)/ 1000);
            int sumTwo = (ticket % 10) + (ticket % 100) / 10 + (ticket % 1000) / 100;
            Console.WriteLine(sumOne);
            Console.WriteLine(sumTwo);

        }
    }
}
