using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestAppHackerRank {

    /// <summary>
    ///  Scope
    /// </summary>
    public static class Day114 {

        class Difference {
            private int[] elements;
            public int maximumDifference;
            public Difference(int[] elements) {
                this.elements = elements;
            }

            internal void computeDifference() {
                var maxDiff = 0;
                for (int i = 0; i < elements.Length; i++) {
                    for (int j = i; j < elements.Length; j++) {
                        var abs = Math.Abs(elements[i] - elements[j]);
                        if (abs > maxDiff) {
                            maxDiff = abs;
                        }
                    }
                }
                maximumDifference = maxDiff;
            }
            // Add your code here

        } // End of Difference Class

        public static void Run() {
            Convert.ToInt32(Console.ReadLine());

            int[] a = Console.ReadLine().Split(' ').Select(x => Convert.ToInt32(x)).ToArray();

            Difference d = new Difference(a);

            d.computeDifference();

            Console.Write(d.maximumDifference);
        }
    }
}
