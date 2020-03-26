using System;

namespace TestAppHackerRank {
    internal class Day107 {
        internal static void Run() {
            int n = Convert.ToInt32(Console.ReadLine());

            int[] arr = Array.ConvertAll(Console.ReadLine().Split(' '), arrTemp => Convert.ToInt32(arrTemp));
            if (n > 1000 || n < 1) {
                return;
            }

            var tempArray = new int[arr.Length];

            for (int i = 0; i < arr.Length; i++) {
                tempArray[arr.Length - i - 1] = arr[i];
            }

            var str = string.Join(" ", tempArray);
            Console.WriteLine(str);

            Console.ReadLine();


        }


    }
}