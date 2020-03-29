using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestAppHackerRank.DaySteps {

    /// <summary>
    /// Queues and Stacks
    /// </summary>
    public static class Day118 {

        public class Solution {
            Stack<char> p;
            Queue<char> q;
            public Solution() {
                p = new Stack<char>();
                q = new Queue<char>();
            }

            public void pushCharacter(char ch) {
                p.Push(ch);
            }
            public void enqueueCharacter(char ch) {
                q.Enqueue(ch);
            }
            public char popCharacter() {
                return p.Pop();
            }
            public char dequeueCharacter() {
                return q.Dequeue();
            }

 

            public static void Run() {

                // read the string s.
                string s = Console.ReadLine();

                // create the Solution class object p.
                Solution obj = new Solution();

                // push/enqueue all the characters of string s to stack.
                foreach (char c in s) {
                    obj.pushCharacter(c);
                    obj.enqueueCharacter(c);
                }

                bool isPalindrome = true;

                // pop the top character from stack.
                // dequeue the first character from queue.
                // compare both the characters.
                for (int i = 0; i < s.Length / 2; i++) {
                    char char1 = (char)obj.popCharacter();
                    char char2 = (char)obj.dequeueCharacter();
                    if (char1 != char2) {
                        isPalindrome = false;
                        break;
                    }
                }

                // finally print whether string s is palindrome or not.
                if (isPalindrome) {
                    Console.Write("The word, {0}, is a palindrome.", s);
                } else {
                    Console.Write("The word, {0}, is not a palindrome.", s);
                }



            }




        }

    }
}