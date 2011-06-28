using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using MyMathFunctions;

namespace PE3v3
{
    // This version will look for lowest common denominator which will provide an operand which is itself a prime number
    // Abandoned. This took too long also
    class Program
    {
        private const long PRIME_SUSPECT = 600851475143;
        static void Main(string[] args)
        {
            long upperLimit = PRIME_SUSPECT / 2;
            long GreatestPrimeFactor = 0;

            for (long i = 2; i < upperLimit; i++)
            {
                // Status indication
                if (i % 100000000 == 0)
                {
                    Console.WriteLine("i = " + i.ToString());
                }

                if (PRIME_SUSPECT % i == 0)
                {
                    long quotient = PRIME_SUSPECT/i;

                    if (Prime.IsPrime(quotient))
                    {
                        GreatestPrimeFactor = quotient;
                    }
                }
            }

            if (GreatestPrimeFactor > 0)
            {
                Console.WriteLine("Greatest Prime Factor for " + PRIME_SUSPECT.ToString() + "Found: " + GreatestPrimeFactor.ToString());
            }
            else
            {
                Console.WriteLine("Greatest Prime Factor for " + PRIME_SUSPECT.ToString() + " NOT found!");
            }

            Console.ReadLine();
        }
    }
}
