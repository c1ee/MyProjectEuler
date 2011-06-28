using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace PE9
{
    class Program
    {
        private const int TARGET = 1000;
        // Problem 9
        // A Pythagorean triplet is a set of three natural numbers, a  b  c, for which,
           
        // a2 + b2 = c2
        // For example, 32 + 42 = 9 + 16 = 25 = 52.
           
        // There exists exactly one Pythagorean triplet for which a + b + c = 1000.
        // Find the product abc.
        
        static void Main(string[] args)
        {
            // Find all the combination of a + b + c = TARGET
            
            List<int[]> possibilities = new List<int[]>();

            for (int i = 1; i < TARGET; i++)
            {
                for (int j = i + 1; j < (TARGET - (i + j)); j++)
                {
                    int k = TARGET - (i + j);

                    if ((i + j + k) == TARGET)
                    {
                        possibilities.Add(new int[] { i, j, k });                        
                    }
                }
            }

            // Now trawl through the possibilities and find the one which satisfies the equation
            // a^2 + b^2 = c^2 
            int a = 0;
            int b = 0;
            int c = 0;

            foreach (int[] possibility in possibilities)
            {
                int i, j, k;

                i = possibility[0];
                j = possibility[1];
                k = possibility[2];

                int iSq = i*i;
                int jSq = j*j;
                int kSq = k*k;

                if ((iSq + jSq) == kSq)
                {
                    a = i;
                    b = j;
                    c = k;
                    break;
                }
            }

            Console.WriteLine("a = " + a.ToString());
            Console.WriteLine("b = " + b.ToString());
            Console.WriteLine("c = " + c.ToString());

            Console.WriteLine("Product of a, b and c is " + (a*b*c).ToString());
            Console.ReadKey();
        }
    }
}
