using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace kklk
{
    class Program
    {
        static void Main()
        {
            int sequence = 0;
            int sequenceMax = 0;
            int a = Int32.Parse(Console.ReadLine());
            int lastSequence = 0;
            while (a != 0) 
             {
                if (a%2==0)
                {
                    sequence += 1;
                    lastSequence = sequence;
                }
                else if (a%2!=0 && sequence!=0)
                {
                    
                    sequenceMax = Math.Max(sequenceMax, sequence);
                    sequence = 0;
                }
                a = Int32.Parse(Console.ReadLine());
             }
            sequenceMax = Math.Max(sequenceMax, lastSequence);
            Console.WriteLine(sequenceMax);
        }
    }
}
