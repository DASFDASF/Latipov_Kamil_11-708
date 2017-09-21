using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Expr13
{
    class Program
    {
        static void Main()
        {
            
            double lengthFence= 10;
            double lengthRope = 6;
             if (lengthRope  <= lengthFence/2)
             {
                double yardage = Math.PI * (lengthRope * lengthRope);
                Console.WriteLine(yardage);

             }
             else if (lengthRope>= lengthFence*Math.Sqrt(2))
             {
                double yardage = lengthFence * lengthFence;
                Console.WriteLine(yardage);
            }
             else
             {
                double angle = 2 * Math.Acos((lengthFence/2) / lengthRope);
                double excessSegment = ((lengthRope * lengthRope) * (angle - Math.Sin(angle))) / 2;
                double yardage = (Math.PI * (lengthRope * lengthRope)) - 4*excessSegment;
                Console.WriteLine(yardage);
            }
            
            
           

        }

    }
}
