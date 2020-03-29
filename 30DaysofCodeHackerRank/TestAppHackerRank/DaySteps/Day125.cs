using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestAppHackerRank.DaySteps {
    public class Day125 {
        public static void Run() {
            var T = Convert.ToInt32(Console.ReadLine());
            if (T > 30) {
                return;
            }
            for (int i = 0; i < T; i++) {
                var n = Convert.ToInt32(Console.ReadLine());
                bool primeNot = true;
                for (int j = 2; j*j < n+1; j++) {
                    if (n % j == 0) {
                        primeNot = false;
                        break;
                    }
                }

                if (!primeNot || n == 1|| n > 2000000000 || n == 2 ) {
                    Console.WriteLine("Not prime");
                } else {
                    Console.WriteLine("Prime");
                }
            }
        }
    }
}
