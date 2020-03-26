using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestAppHackerRank {
    /// <summary>
    /// Abstract Classes
    /// </summary>
    internal class Day113 {
        private class MyBook : Book {

            int price { get; set; }
            public MyBook(String title, String author, int price) : base(title, author) {
                this.price = price;
            }
            public override void display() {
                Console.Write("Title: {0} \nAuthor: {1} \nPrice: {2}", title, author, price);
            }
        }
         abstract class Book {

            protected String title;
            protected String author;

            public Book(String t, String a) {
                title = t;
                author = a;
            }
            public abstract void display();


        }

        internal static void Run() {


            String title = Console.ReadLine();
            String author = Console.ReadLine();
            int price = Int32.Parse(Console.ReadLine());
            Book new_novel = new MyBook(title, author, price);
            new_novel.display();
        }
    }
}
