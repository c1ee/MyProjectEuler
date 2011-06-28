using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace MyMathFunctions
{
    public class MyMathClass
    {
        public MyMathClass()
        {
            if (_PrimeList == null)
            {
                _PrimeList = new List<long>();

                // Initialise the Prime List with the first two primes
                _PrimeList.Add(2);
                _PrimeList.Add(3);
            }
        }

        // our cache
        private List<long> _PrimeList;

        // Using strict Sieve of Eratosthenes method
        public List<long> GetListOfPrimesUpTo(long maxNumber)
        {
            // Initialise list of candidates
            Dictionary<long, bool> listOfPrimes = new Dictionary<long, bool>();

            for (long i = 2; i <= maxNumber; i++)
            {
                listOfPrimes.Add(i, true);
            }

            // Start the sieve
            long prime = 2; // always 2 at the start

            while (prime < Math.Sqrt(maxNumber))
            {
                for (int i = 2; (i * prime) <= maxNumber; i++)
                {
                    listOfPrimes[i*prime] = false;
                }

                do
                {
                    prime++;
                } while (listOfPrimes[prime] == false);
            }

            return (from primeToInsert in listOfPrimes where primeToInsert.Value select primeToInsert.Key).ToList();
        }

        public long GetSumOfPrimesUpTo(long number)
        {
            return GetListOfPrimesUpTo(number).Sum();
        }

        public long FindNthPrime(int index)
        {
            if (index < 1)
            {
                throw new ArgumentOutOfRangeException();
            }

            // Check if we have it in cache
            if (_PrimeList.Count >= index)
            {
                return _PrimeList[index - 1];
            }

            // We don't have it in cache, so we have to find it                        
            for (long i = _PrimeList.Last() + 2; ; i += 2)
            {
                if (IsPrime(i))
                {
                    _PrimeList.Add(i);
                }

                if (_PrimeList.Count == index)
                {
                    return i;
                }
            }

            throw new InvalidOperationException("Shouldn't have got to this part. Method is buggy");
        }

        public static bool IsPrime(long number)
        {
            #region "Low hanging fruits"
            if (number <= 1)
            {
                return false;
            }

            if (number == 2)
            {
                return true;
            }

            if (number % 2 == 0)
            {
                return false;
            }
            #endregion

            long root = (long)Math.Sqrt(number);

            for (long i = 3; i <= root; i += 2)
            {
                if (number % i == 0)
                    return false;
            }

            return true;
        }

        // A variation which returns the lcd of the number as well as the bool result
        // comment later: is it lcd or gcd? not sure
        public static bool IsPrime(long number, ref long lcd)
        {
            lcd = 0;
            if (number <= 1)
            {
                return false;
            }
            if (number == 2)
            {
                return true;
            }

            long root = (long)Math.Sqrt(number);

            for (long i = 3; i <= root; i += 2)
            {
                if (number % i == 0)
                    lcd = i;
                    return false;
            }

            return true;
        }

        

        private static long GetGreatestAdjacentHorizontalProductInGrid(int[][] grid, int adjacentCount)
        {
            throw new NotImplementedException();
        }

        private static long GetGreatestAdjacentVerticalProductInGrid(int[][] grid, int adjacentCount)
        {
            throw new NotImplementedException();
        }

        private static long GetGreatestAdjacentLeftDiagonalProductInGrid(int[][] grid, int adjacentCount)
        {
            throw new NotImplementedException();
        }

        private static long GetGreatestAdjacentRightDiagonalProductInGrid(int[][] grid, int adjacentCount)
        {
            throw new NotImplementedException();
        }

        private static long GetGreatestAdjacentProductInList(int[] intArray, int adjacentCount)
        {
            throw new NotImplementedException();
        }

        public static long GetGreatestAdjacentProductInGrid(int[][] grid, int adjacentCount)
        {
            throw new NotImplementedException();
        }
    }
}
