using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestAppHackerRank {
    public class Day101 {


        public static void Run() {

            int i = 4;
            double d = 4.0;
            string s = "HackerRank ";

            // Declare second integer, double, and String variables.
            // Declare  variables: one of type int, one of type double, and one of type String.
            int intvariable = 12;
            double doublevariable = 4.0;
            string stringvariable = "is the best place to learn and practice coding!";
            // Read and save an integer, double, and String to your variables.
            //intvariable=Convert.ToInt32(Console.ReadLine());
            // Print the sum of both integer variables on a new line.
            Console.WriteLine((intvariable + i).ToString());

            // Print the sum of the double variables on a new line.
            Console.WriteLine(string.Format("{0:0.0}", doublevariable + d));
            // Concatenate and print the String variables on a new line
            Console.WriteLine(s + stringvariable);
            // The 's' variable above should be printed first.

            intvariable = Convert.ToInt32(Console.ReadLine());
            doublevariable = Convert.ToDouble(Console.ReadLine());
            stringvariable = Console.ReadLine();

            Console.WriteLine((intvariable + i).ToString());

            // Print the sum of the double variables on a new line.
            Console.WriteLine(string.Format("{0:0.0}", doublevariable + d));
            // Concatenate and print the String variables on a new line
            Console.WriteLine(s + stringvariable);
        }
    }
}
