using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestAppHackerRank {
    public class Day4 {


        public static void Run() {
        }

        public class Person {
            public Person(int initialAge) {
                if (initialAge < 0) {
                    Console.WriteLine("Age is not valid, setting age to 0");
                    initialAge = 0;
                }
                age = initialAge;
            }
            public int age { get; set; }

            public void yearPasses() { age++; }

            /// <summary>
            /// should perform the following conditional actions:
            //            If , print You are young..
            //If and, print You are a teenager..
            //Otherwise, print You are old..
            /// </summary>
            public void amIOld() {
                if (age < 13) {
                    Console.WriteLine("You are young..");
                }
                if (age >= 13 && age < 18) {
                    Console.WriteLine("You are a teenager..");
                }
                if (age > 18) {
                    Console.WriteLine(" You are old..");
                }

            }

        }
    }
}
