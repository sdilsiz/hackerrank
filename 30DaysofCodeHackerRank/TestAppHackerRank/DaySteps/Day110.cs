using System;
using System.Collections.Generic;
using System.IO;

namespace TestAppHackerRank {

    internal class Day110 {
        internal static void Run() {
            int n = Convert.ToInt32(Console.ReadLine());

            string binary = Convert.ToString(n, 2); // convert 5 to its binary representation
            //Console.WriteLine(binary);
            var txtArray = binary.Split('0');
            var maxLength = 0;
            for (int i = 0; i < txtArray.Length; i++) {
                //Console.WriteLine(txtArray[i]);
                if (maxLength < txtArray[i].Length) {
                    maxLength = txtArray[i].Length;
                } 
            }
            Console.WriteLine(maxLength);
            Console.Read();
        }

    }
}