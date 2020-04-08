using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace TestAppHackerRank.DaySteps {
    public class Day128 {
        public static void Run() {
            int N = Convert.ToInt32(Console.ReadLine());
            string[] firstNm = new string[N];
            for (int NItr = 0; NItr < N; NItr++) {
                string[] firstNameEmailID = Console.ReadLine().Split(' ');

                string firstName = firstNameEmailID[0];

                string emailID = firstNameEmailID[1];

                //string email = firstName;
                Regex regex = new Regex(@"^([a-z0-9_\-\.]+)@gmail.com$");
                Match match = regex.Match(emailID);
                if (match.Success)
                    firstNm[NItr] = firstName;
                else {
                    firstNm[NItr] ="";
                }
            }

            Array.Sort(firstNm, StringComparer.InvariantCulture);

            for (int i = 0; i < N; i++) {
                if (!string.IsNullOrEmpty(firstNm[i])) {
                    Console.WriteLine(firstNm[i]);
                }
                
            }
            Console.Read();
        }
    }
}
