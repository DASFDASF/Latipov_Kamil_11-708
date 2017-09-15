using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Expr1
{
    class Program
    {
        static void Main(string[] args)
        {
            //Expr1. Как поменять местами значения двух переменных?
            //Можно ли это сделать без ещё одной временной переменной. Стоит ли так делать?
            //Латипов Камиль 
            int a = 5;
            int b = 6;
             b = b - a;
             a = b + a;
             b = a - b;
            Console.WriteLine(a.ToString(), b.ToString());


        }
    }
}
