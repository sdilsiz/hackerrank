﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestAppHackerRank.DaySteps {
    public class Day119 {


        public class Calculator : AdvancedArithmetic {
            public int divisorSum(int n) {

                int sum = 0;
                for (int i = 1; i <= n; i++) {
                    if (n % i == 0) {
                        sum += i;
                    }
                }
                return sum;
            }
        }

        interface AdvancedArithmetic {
            int divisorSum(int n);
        }


        public static void Run() {

            int n = Int32.Parse(Console.ReadLine());
            AdvancedArithmetic myCalculator = new Calculator();
            int sum = myCalculator.divisorSum(n);
            Console.WriteLine("I implemented: AdvancedArithmetic\n" + sum);
        }
    }
}
