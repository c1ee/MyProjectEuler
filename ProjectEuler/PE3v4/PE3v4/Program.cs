using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using MyMathsLibrary;

// Project Euler Problem 3:
// The prime factors of 13195 are 5, 7, 13 and 29.
// What is the largest prime factor of the number 600851475143 ?

// Working solution
namespace PE3v4
{
    class Program
    {
        private const long THE_PRIME_SUSPECT = 600851475143;
        static void Main(string[] args)
        {
            DateTime start = DateTime.Now;
            long gcd = 1;
            bool isPrime = false;
            long primeSuspect = THE_PRIME_SUSPECT;            
            
            isPrime = MyMathsClass.IsPrime(primeSuspect, ref gcd);

            if (isPrime)
            {
                // the original suspect is itself a prime number!
                // exit
            }

            primeSuspect = gcd;

            while(!MyMathsClass.IsPrime(primeSuspect, ref gcd))
            {
                primeSuspect = gcd;
            }

            if (primeSuspect < 2)
            {
                Console.WriteLine("primeSuspect = gcd = " + primeSuspect.ToString());
            }
            else
            {
                DateTime end = DateTime.Now;
                Console.WriteLine("Found gpf = " + primeSuspect.ToString());
                Console.WriteLine("Took " + (start - end).ToString() + " seconds");
            }

            Console.ReadKey();
        }
    }
}
