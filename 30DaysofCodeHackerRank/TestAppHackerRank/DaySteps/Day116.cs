using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestAppHackerRank.DaySteps {

    /// <summary>
    /// Exceptions - String to Integer
    /// </summary>
    public static class Day116 {
        public static void Run() {
            string S = Console.ReadLine();
            if (S.Length > 6) {
                return;
            }

            try {
                int x = Convert.ToInt32(S);
                Console.WriteLine(S);
            } catch (Exception) {

                Console.WriteLine("Bad String");
            }


        }
    }
}
