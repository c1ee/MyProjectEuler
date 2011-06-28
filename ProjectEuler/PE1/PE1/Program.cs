using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace PE1
{
    class Program
    {
        public static void Main(string[] args)
        {
            int sum = 0;
            for (int i = 1; i < 1000; i++)
            {
                if (i % 3 == 0 || i % 5 == 0)
                {
                    sum += i;
                }
            }

            Console.WriteLine("Total Sum is: " + sum.ToString());

            Console.Read();
        }
    }
}
