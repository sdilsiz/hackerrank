using System;

namespace TestAppHackerRank {
    internal class OdevIntermediate9 {
        internal static void Run() {
            //throw new NotImplementedException();
            //lkjasd;flkjas;
            string isim = "Ahmet";

            isPolindrom(isim);

        }

        static bool isPolindrom(string isim) {

            string[] array = new[] { isim };  // {"A" , "h" , "m" ,  "e" , "t"};

            for (int i = array.Length - 1; i >= 0; i--) {
                Console.Write(array[i]);


            }

            return false;
        }
    }
}
 