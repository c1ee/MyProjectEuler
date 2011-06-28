using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using MyMathFunctions;

namespace PE7
{
    // Problem 7
    // By listing the first six prime numbers: 2, 3, 5, 7, 11, and 13, we can see that the 6th prime is 13.
    // What is the 10001st prime number?

    // First attempt

    class Program
    {
        static void Main(string[] args)
        {
            MyMathClass mathClass = new MyMathClass();

            DateTime start = DateTime.Now;

            int n;

            //n = 1;
            //Console.WriteLine("Prime number for n = " + n.ToString() + " is: " + mathClass.FindNthPrime(n));

            //n = 2;
            //Console.WriteLine("Prime number for n = " + n.ToString() + " is: " + mathClass.FindNthPrime(n));

            //n = 3;
            //Console.WriteLine("Prime number for n = " + n.ToString() + " is: " + mathClass.FindNthPrime(n));

            //n = 5;
            //Console.WriteLine("Prime number for n = " + n.ToString() + " is: " + mathClass.FindNthPrime(n));

            //n = 8;
            //Console.WriteLine("Prime number for n = " + n.ToString() + " is: " + mathClass.FindNthPrime(n));

            n = 10001;
            Console.WriteLine("Prime number for n = " + n.ToString() + " is: " + mathClass.FindNthPrime(n));

            Console.WriteLine("Time it took is: " + (DateTime.Now - start).ToString());

            Console.ReadKey();
        }
    }
}
