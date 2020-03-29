using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestAppHackerRank.DaySteps {
    public class Day122 {


        public static void Run() {
            Node root = null;
            int T = Int32.Parse(Console.ReadLine());
            while (T-- > 0) {
                int data = Int32.Parse(Console.ReadLine());
                root = insert(root, data);
            }
            int height = getHeight(root);
            Console.WriteLine(height);

        }

        private class Node {
            public Node left, right;
            public int data;
            public Node(int data) {
                this.data = data;
                left = right = null;
            }
        }

        static int getHeight(Node root) {
            //Write your code here

            int heightLeft = 0;
            int heightRight = 0;

            if (root.left != null) {
                heightLeft = getHeight(root.left) + 1;
            }
            if (root.right != null) {
                heightRight = getHeight(root.right) + 1;
            }

            return (heightLeft > heightRight ? heightLeft : heightRight);
        }
        private static Node insert(Node root, int data) {
            if (root == null) {
                return new Node(data);
            } else {
                Node cur;
                if (data <= root.data) {
                    cur = insert(root.left, data);
                    root.left = cur;
                } else {
                    cur = insert(root.right, data);
                    root.right = cur;
                }
                return root;
            }
        }

    }
}
