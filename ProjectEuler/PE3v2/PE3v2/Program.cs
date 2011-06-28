using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using MyMathFunctions;

namespace PE3v2
{
    // Second version. The idea is to work backwards from half the suspect and check each number is a prime factor or not.
    // Abandoned because it was also taking too long, and thought of a better solution, which will beimplemented in the next version.
    class Program
    {
        private const long PRIME_SUSPECT = 600851475143;

        static void Main(string[] args)
        {
            // first, check if the suspect is a prime number
            if (Prime.IsPrime(PRIME_SUSPECT))
            {
                Console.WriteLine("The Prime Suspect " + PRIME_SUSPECT.ToString() + "is itself a prime number!");
                Console.ReadLine();
                return;
            }           

            // divide by two. Anything higher cannot be a prime factor
            long newPrimeSuspect = PRIME_SUSPECT / 2;
            long greatestPrimeFactor = 0;

            // even numbers cannot be prime
            if (newPrimeSuspect % 2 == 0)
            {
                newPrimeSuspect--;
            }

            while (newPrimeSuspect > 2)
            {
                if (Prime.IsPrime(newPrimeSuspect) && PRIME_SUSPECT % newPrimeSuspect == 0)
                {
                    greatestPrimeFactor = newPrimeSuspect;
                    break;
                }

                newPrimeSuspect -= 2;
            }

            if (greatestPrimeFactor > 0)
            {
                Console.WriteLine("The Greatest Prime Factor of " + PRIME_SUSPECT.ToString() + " is " + greatestPrimeFactor.ToString());
            }
            else
            {
                Console.WriteLine("Unable to find a Prime Factor for " + PRIME_SUSPECT.ToString());
            }

            Console.ReadLine();
        }
    }
}
