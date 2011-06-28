using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace PE2
{
    class Program
    {
        static void Main(string[] args)
        {
            int first = 1;
            int second = 2;            
            int evenSum = 0;
            int next;

            do
            {

                if (second%2 == 0)
                {
                    evenSum += second;
                }

                next = first + second;

                first = second;
                second = next;
            } while (next < 4000000);

            Console.WriteLine("evenSum is: " + evenSum.ToString());
            Console.ReadLine();
        }

        
    }
}
