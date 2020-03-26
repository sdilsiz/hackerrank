using System;

namespace TestAppHackerRank {
    internal class Day105 {
        internal static void Run() {
            int n = Convert.ToInt32(Console.ReadLine());

            for (var i = 1; i < 11; i++)

                Console.WriteLine(n + " x " + i + " = " + n * i);
        }
    }
}