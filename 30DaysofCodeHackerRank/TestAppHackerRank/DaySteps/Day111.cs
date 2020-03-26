using System;
using System.Collections.Generic;
using System.IO;

namespace TestAppHackerRank {

    internal class Day111 {
        internal static void Run() {
            int[][] arr = new int[6][];

            for (int i = 0; i < 6; i++) {
                arr[i] = Array.ConvertAll(Console.ReadLine().Split(' '), arrTemp => Convert.ToInt32(arrTemp));

            }


            //for (int i = 0; i < arr.Length; i++) {
            //    for (int j = 0; j < arr[i].Length; j++) {
            //        if (arr[i][j] > 9 || arr[i][j] < -9) {
            //            return;
            //        }
            //    }
            //}

            var max = -63;

            for (int i = 0; i + 2 < arr.Length; i++) {
                for (int j = 0; j + 2 < arr[i].Length; j++) {

                    var sum = arr[i][j] + arr[i][j + 1] + arr[i][j + 2]
                                        + arr[i + 1][j + 1]
                             + arr[i + 2][j] + arr[i + 2][j + 1] + arr[i + 2][j + 2];

                    if (sum > max) {
                        max = sum;
                    }
                }


            }
            Console.WriteLine(max);
            Console.Read();

        }

    }
}