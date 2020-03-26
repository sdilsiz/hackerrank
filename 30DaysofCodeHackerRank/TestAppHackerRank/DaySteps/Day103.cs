using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestAppHackerRank {
    public class Day103 {
        public static void Run() {
            //If is odd, print Weird
            //If is even and in the inclusive range of 2 to 5  , print Not Weird
            //If is even and in the inclusive range of 6 to 20, print Weird
            //If is even and greater than 20, print Not Weird
            int N = Convert.ToInt32(Console.ReadLine());
            bool isEven = N % 2 == 0 ? true : false;

            if (N < 1 || N > 100) {
                Console.WriteLine("Not Weird");
            }

            if (!isEven) {
                Console.WriteLine("Weird");
            }

            if (N > 2 && N < 5 && isEven) {
                Console.WriteLine("Not Weird");
            }

            if (N > 6 && N <= 20 && isEven) {
                Console.WriteLine("Weird");
            }

            if (N > 20 && isEven) {
                Console.WriteLine("Not Weird");
            }


        }


    }
}
