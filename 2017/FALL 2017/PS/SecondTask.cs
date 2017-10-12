using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp11
{
    class Program
    {
        private static void Main()
        {
            double a1 = int.Parse(Console.ReadLine());
            double an = int.Parse(Console.ReadLine()); //последний элемент прогрессии
            double d = int.Parse(Console.ReadLine());
            double n = (an - a1 + d) / d; //n - количество элементов 
            double sum = n*((a1 + an) / 2);
            Console.WriteLine(n + " " + sum);
        }
    }
}
