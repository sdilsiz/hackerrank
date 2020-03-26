using System;
using System.Collections.Generic;
using System.IO;

namespace TestAppHackerRank {

    internal class Day109 {
        internal static void Run() {

            //TextWriter textWriter = new StreamWriter(@System.Environment.GetEnvironmentVariable("OUTPUT_PATH"), true);

            int n = Convert.ToInt32(Console.ReadLine());

            int result = factorial(n);

            //textWriter.WriteLine(result);

            //textWriter.Flush();
            //textWriter.Close();
            Console.WriteLine(result);

            Console.Read();

        }


        static int factorial(int n) {
            if (n == 0 || n == 1) {
                return 1;
            } else {
                return n * factorial(n - 1);
            }

        }



    }
}