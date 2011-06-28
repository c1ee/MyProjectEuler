using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

// Writing this comment after realising this rendition will not work. The number 600851475143 is too large to
// check every number for primes if starting from 0. 
// A new version will be made, which will be going down, rather than up. That should be faster.

namespace PE3
{    
    class Program
    {
        private const long PRIME_SUSPECT = 600851475143;      
        private static long _PrimeNumber = 0;

        // Resets the static primeNumber variable to ensure the first call to GetNextPrimeNumber is 2
        static void ResetPrimeNumber()
        {
            _PrimeNumber = 0;
        }

        // Call this consecutively to get prime numbers in ascending order. 
        // Make sure to call ResetPrimeNumber before calling this if you want to start from the beginning
        static void GetNextPrimeNumber()
        {
            if (_PrimeNumber < 2)
            {
                _PrimeNumber = 2;
                return;
            }

            if (_PrimeNumber == 2)
            {
                _PrimeNumber = 3;
                return;
            }

            do
            {
                _PrimeNumber += 2;
            } while (!IsPrime(_PrimeNumber));

        }

        static bool IsPrime(long num)
        {
            if (num <= 1)
            {
                return false;
            }
            if (num == 2)
            {
                return true;
            }

            long root = (long)Math.Sqrt(num);

            for (long i = 3; i <= root; i+=2)
            {
                if (num % i == 0)
                    return false;
            }

            return true;
        }

        static void Main(string[] args)
        {
            DateTime startTime, endTime;
            startTime = DateTime.Now;
            Console.WriteLine("Starting now: " + startTime.ToString());
            ResetPrimeNumber();
            long largestPrimeFactor = 1;
            long limit = PRIME_SUSPECT / 2; // no point looking up up numbers greater than divided by half

            do
            {
                GetNextPrimeNumber();
                if (PRIME_SUSPECT % _PrimeNumber == 0)
                {
                    largestPrimeFactor = _PrimeNumber;
                }
            } while (_PrimeNumber < limit);
            
            endTime = DateTime.Now;
            Console.WriteLine("Finished: " + endTime.ToString());
            Console.WriteLine("Largest Prime Factor of " + PRIME_SUSPECT.ToString() + "is: " + largestPrimeFactor.ToString());
            Console.WriteLine("Took " + (startTime - endTime).ToString());

            Console.ReadLine();
        }
    }
}
