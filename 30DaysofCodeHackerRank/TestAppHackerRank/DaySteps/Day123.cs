using System;
using System.Collections;
using System.Collections.Generic;
using System.IO;
using System.Linq;

namespace TestAppHackerRank.DaySteps {
    public class Day123 {

        class Node {
            public Node left, right;
            public int data;
            public Node(int data) {
                this.data = data;
                left = right = null;
            }
        }

        static void levelOrder(Node root) {

            Queue<Node> q = new Queue<Node>();
            Node n;
            if (root != null) q.Enqueue(root);

            while (q.Count > 0) {
                n = q.Dequeue();
                Console.Write(n.data + " ");
                if (n.left != null) q.Enqueue(n.left);
                if (n.right != null) q.Enqueue(n.right);
            }
        }

        static Node insert(Node root, int data) {
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

        public static void Run() {
            Node root = null;
            int T = Int32.Parse(Console.ReadLine());
            while (T-- > 0) {
                int data = Int32.Parse(Console.ReadLine());
                root = insert(root, data);
            }
            levelOrder(root);

        }
    }
}
