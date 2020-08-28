using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;


/// <summary>
/// 
/// </summary>
namespace TestAppHackerRank {

    /// <summary>
    /// Write function that reverses a list, preferably in place.
    /// </summary>
    public class OdevString14 {




        public static void Execute() {


            //Console.WriteLine("hell");
            var liste = new List<string>() { "1", "2", "3", "4", "5","6" };
            var adet = 3;
            //let var 
            //DataTable'//
            //ahmet temha
            //0 son eleman
            //    1 sondan bir
            //3// 0 2 11  bitecek

                //4 eleman 0 3 1 2 yariya kadar
                //5 eleman 0 4 1 3 2 2 yerleri degistirilecek

            foreach (var item in liste) {
                //Console.WriteLine(item);

                //var ilkeleman = liste[i];
                //var sonrakieleman = liste[liste.Count - i - 1];
                //Console.WriteLine(ilkeleman);

                //Console.WriteLine(sonrakieleman);
                //Console.WriteLine("****");

                //liste[i] = sonrakieleman;
                //liste[liste.Count - i - 1] = ilkeleman;
            }
            //0 3
            for (int i = 0; i < liste.Count / 2; i++) {

                var ilkeleman= liste[i];
                var sonrakieleman= liste[liste.Count-i-1];
                Console.WriteLine(ilkeleman);

                Console.WriteLine(sonrakieleman);
                Console.WriteLine("****");

                liste[i] = sonrakieleman;
                liste[liste.Count - i - 1] = ilkeleman;

            }
            foreach (var item in liste) {
                Console.WriteLine(item);

            }
            //liste.Reverse();
            Console.Read();

        }
    }

}
