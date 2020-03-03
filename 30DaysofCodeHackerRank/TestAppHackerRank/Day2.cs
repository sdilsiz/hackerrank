using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestAppHackerRank {
    public class Day2 {
        public static void Run() {

            double meal_cost = Convert.ToDouble(Console.ReadLine());

            int tip_percent = Convert.ToInt32(Console.ReadLine());

            int tax_percent = Convert.ToInt32(Console.ReadLine());

            solve(meal_cost, tip_percent, tax_percent);

        }

        static void solve(double meal_cost, int tip_percent, int tax_percent) {

            double tip = meal_cost * tip_percent / 100;
            double tax = meal_cost * tax_percent / 100;
            Console.WriteLine(Convert.ToInt32(tip + tax + meal_cost));
        }
    }
}
