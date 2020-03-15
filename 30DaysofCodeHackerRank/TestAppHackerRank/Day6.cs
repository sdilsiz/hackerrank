using System;

namespace TestAppHackerRank {
    internal class Day6 {
        internal static void Run() {

            var S = string.Empty;
            var S_Array = new string[10];
            var S_ArrayResult = new string[10];
            var textcount = Convert.ToInt32(Console.ReadLine());

            if (textcount > 10 || textcount < 1) {
                return;
            }

            for (int i = 0; i < textcount; i++) {
                S = Console.ReadLine();
                S_Array[i] = S;
                S_ArrayResult[i] = SplitText(S);
            }

            for (int i = 0; i < textcount; i++) {
                Console.WriteLine(S_ArrayResult[i]);
            }
            Console.ReadLine();
        }

        private static string SplitText(string S) {
            var t1 = string.Empty;
            var t2 = string.Empty;
            if (S.Length > 10000) {
                return "";
            }
            for (int i = 0; i < S.Length; i++) {
                if (i % 2 == 0) {
                    t1 = t1.Insert(t1.Length, S[i].ToString());
                } else {
                    t2 = t2.Insert(t2.Length, S[i].ToString());
                }
            }
            return $@"{t1} {t2}";
        }
    }
}