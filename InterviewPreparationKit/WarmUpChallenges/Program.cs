using System.CodeDom.Compiler;
using System.Collections.Generic;
using System.Collections;
using System.ComponentModel;
using System.Diagnostics.CodeAnalysis;
using System.Globalization;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Runtime.Serialization;
using System.Text.RegularExpressions;
using System.Text;
using System;

namespace WarmUpChallenges
{
    class Program
    {
        static void Main(string[] args)
        {

            // var result = CountingValleys.countingValleys(8, "UDDDUDUU"); Console.WriteLine(result);
            // int[] array = new int[] { 0, 0, 1, 0, 0, 1, 0 };
            // var result = JumpingOnTheClouds.jumpingOnClouds(array); Console.WriteLine(result);
            // var x = RepeatedString.repeatedString("kmretasscityylpdhuwjirnqimlkcgxubxmsxpypgzxtenweirknjtasxtvxemtwxuarabssvqdnktqadhyktagjxoanknhgilnm", 736778906400);
            // Console.WriteLine(x);



        }


        public interface Iperson
        {
            int Name { get; set; }
            void Print();
        }

        public class Person : Iperson
        {
            public int Name { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }

            public void Print()
            {
                throw new NotImplementedException();
            }
        }


        static int sockMerchant(int n, int[] ar)
        {

            var newArray = new int[n, 2];

            for (int i = 0; i < n; i++)
            {
                newArray[i, 0] = ar[i];
                newArray[i, 1] = 0;
            }

            var colorcounter = 0;
            for (int i = 0; i < n; i++)
            {
                if (newArray[i, 1] == 1) { continue; }
                for (int j = 0; j < n; j++)
                {
                    if (i == j) { continue; }
                    if (newArray[j, 1] == 1) { continue; }

                    if (newArray[i, 0] == newArray[j, 0])
                    {
                        colorcounter++;
                        newArray[i, 1] = 1;
                        newArray[j, 1] = 1;
                        break;
                    }
                }
            }

            for (int i = 0; i < n; i++)
            {
                Console.WriteLine(newArray[i, 0] + "--" + newArray[i, 1]);
            }


            return colorcounter;
        }
    }
}
