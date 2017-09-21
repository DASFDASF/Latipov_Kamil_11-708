using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Expr11
{
    class Program
    {
        static void Main()
        {
            int h = 10000;
            int v = 50;
            int x = 10;
            double t = 500;
            //минимальное время можно найти используя систему уравнений
            //x*t1(время, за которое самолет набирает скорость x)+v*tmin = h
            //t1 + tmin = t
            //t1 = t - tmin
            //подставляем t1 в первое уравнение и выводим tmin 
            double tmin = (h - (x * t)) / (-x + v);

            double max = t;
            Console.WriteLine(tmin);
            Console.WriteLine(max);
        }
    }
}
