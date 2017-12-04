using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Program
    {
        static void Main()
        {
            
            var sumOfDividers = 0;
            var amountOfNumbers = 0;
            for (var i = 0; i <= 1000000; i++) 
             {
                var number = i;
		// ---check--- ваш цикл остановится вообще?
                while (i!=0)
                {
                    int a = i;
                    if (number % a == 0)
                    {
                        sumOfDividers += i;
                    }
                    a = a - 1;
                }
		// ---check--- почему % ??
                if (sumOfDividers%(2*i)==0)
                {
                   amountOfNumbers += 1;
                }
             }
           Console.WriteLine(amountOfNumbers);
        }
    }
}
