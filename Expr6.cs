using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Expr6
{
    class Program
    {
        static void Main(string[] args)
        {
            int x0 = int.Parse(Console.ReadLine()); 
            int y0 = int.Parse(Console.ReadLine());
            //координаты первой точки прямой
            int x1 = int.Parse(Console.ReadLine());
            int y1 = int.Parse(Console.ReadLine());
            //координаты второй точки прямой
            int x2 = int.Parse(Console.ReadLine());
            int y2 = int.Parse(Console.ReadLine());
            //координаты точки , не относящейся к прямой 
            //самый легкий способ найти расстояние - применить формулу 
            int a = (y1 - y0) * x2 - (x1 - x0) * y2 + x1 * y0- y1 * x0;
            int a1 = (y1 - y0)* (y1 - y0);
            int a2 = (x1 - x0) * (x1 - x0);
            int a3 = a1 + a2;
            int a4 = Convert.ToInt32(Math.Sqrt(a3));
            int b = Math.Abs(a) + a4;
   
            Console.WriteLine(b);
            
            
        }
    }
}
