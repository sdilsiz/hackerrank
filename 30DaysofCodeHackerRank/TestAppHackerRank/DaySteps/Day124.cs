using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestAppHackerRank.DaySteps {
    public class Day124 {

        class Node {
            public int data;
            public Node next;
            public Node(int d) {
                data = d;
                next = null;
            }

        }

        public static void Run() {
            Node head = null;
            int T = Int32.Parse(Console.ReadLine());
            while (T-- > 0) {
                int data = Int32.Parse(Console.ReadLine());
                head = insert(head, data);
            }
            head = removeDuplicates(head);
            display(head);


        }

        private static void display(Node head) {
            Node start = head;
            while (start != null) {
                Console.Write(start.data + " ");
                start = start.next;
            }
        }

        private static Node insert(Node head, int data) {
            Node p = new Node(data);


            if (head == null)
                head = p;
            else if (head.next == null)
                head.next = p;
            else {
                Node start = head;
                while (start.next != null)
                    start = start.next;
                start.next = p;

            }
            return head;
        }

        private static Node removeDuplicates(Node head) {
            //Write your code here

            if (head == null || head.next == null) {
                return head;
            }

            if (head.data == head.next.data) {
                head.next = head.next.next;
                removeDuplicates(head);
            } else {
                removeDuplicates(head.next);
            }
            return head;
        }


    }
}
 