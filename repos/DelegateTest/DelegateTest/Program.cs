using System;
using System.Collections.Generic;

namespace DelegateTest
{
    class Program
    {
        static void Main(string[] args)
        {
            //var myList = new List<int> { 1, 2, 3, 4 };

            Console.WriteLine(DecimalNumbers(10, n => n>=10 && n<=99));
            Console.WriteLine(DecimalNumbers(10, T));
        }
        public static bool DecimalNumbers(int n, Func<int,bool> isDecimal)
        {
            return isDecimal(n);
        }

        public static int DecimalNumbers(int n, Func<int, int> isDecimal)
        {
            return isDecimal(n);
        }

        public static int T(int n)
        {
            if (n >= 10 && n <= 99)
                return n;
            else
                return 0;
        }
    }
}
