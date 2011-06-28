using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using MyMathFunctions;
using System.Diagnostics;

namespace PE10
{
    class Program
    {
        // Problem 10

        // The sum of the primes below 10 is 2 + 3 + 5 + 7 = 17.
        // Find the sum of all the primes below two million.

        private const int TARGET = 2000000;

        static void Main(string[] args)
        {
            Stopwatch stopwatch = Stopwatch.StartNew();

            MyMathClass mathClass = new MyMathClass();

            long sumOfPrimes = mathClass.GetSumOfPrimesUpTo(TARGET);

            stopwatch.Stop();

            Console.WriteLine("Sum of primes below " + TARGET.ToString() + " is " + sumOfPrimes.ToString());
            Console.WriteLine("Elapsed time is: " + stopwatch.ElapsedMilliseconds + " milliseconds");

            Console.ReadKey();
        }
    }
}
