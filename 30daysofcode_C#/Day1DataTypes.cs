using System;
using System.Collections.Generic;
using System.IO;

class Solution {
    static void Main(String[] args) {
        int i = 4;
        double d = 4.0;
        string s = "HackerRank ";

		int intvariable=Convert.ToInt32(Console.ReadLine());
        double doublevariable=Convert.ToDouble(Console.ReadLine());
        string stringvariable=Console.ReadLine();
        // Read and save an integer, double, and String to your variables.
        //intvariable=Convert.ToInt32(Console.ReadLine());
        // Print the sum of both integer variables on a new line.
        Console.WriteLine((intvariable+i).ToString());
        
        // Print the sum of the double variables on a new line.
        Console.WriteLine(string.Format("{0:0.0}",  doublevariable+d));
        // Concatenate and print the String variables on a new line
        Console.WriteLine((s+stringvariable).ToString());
        // The 's' variable above should be printed first.
//   Console.WriteLine(ri.ToString());
//         Console.WriteLine(rd.ToString("#.0"));
//         Console.WriteLine(rs.ToString());
    }