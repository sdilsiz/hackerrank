using System;
using System;
using System.Collections.Generic;
using System.IO;

namespace fibonacci
{
   

    class Program
    {

        public static int Fibonacci(int n)
        {
            // Write your code here.
            if (n == 0) return 0;
            if (n == 1) return 1;

            return Fibonacci(n - 1) + Fibonacci(n - 2);
        }

        static void Main(String[] args)
        {
            int n = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine(Fibonacci(n));
        }
    }
}
