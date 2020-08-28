using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestAppHackerRank {
    public class Liste6 {
        public static void Run() {

            string isim = "Ahmet";

            isPolindrom(isim);
            Console.Read();
        }


        static bool isPolindrom(string isim) {

            //string[] array = new[] { isim };  // {"A" , "h" , "m" ,  "e" , "t"};{"Ahmet"}

            //for (int i = array.Length - 1; i >= 0; i--) {
            //    Console.Write(array[i]);
            //}



            char[] chararray = isim.ToCharArray();  // {"A" , "h" , "m" ,  "e" , "t"};{"Ahmet"}

            for (int i = chararray.Length - 1; i >= 0; i--) {
                Console.Write(chararray[i]);
            }


            //isim.ToCharArray()

            return false;
        }
    }



}


 
       


//    }
//}