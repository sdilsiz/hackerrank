﻿using System;
using System.Collections.Generic;
using System.IO;

namespace TestAppHackerRank {

    internal class Day112 {
        internal static void Run() {
            string[] inputs = Console.ReadLine().Split();
            string firstName = inputs[0];
            string lastName = inputs[1];
            int id = Convert.ToInt32(inputs[2]);
            int numScores = Convert.ToInt32(Console.ReadLine());
            inputs = Console.ReadLine().Split();
            int[] scores = new int[numScores];
            for (int i = 0; i < numScores; i++) {
                scores[i] = Convert.ToInt32(inputs[i]);
            }

            Student s = new Student(firstName, lastName, id, scores);
            s.printPerson();
            Console.WriteLine("Grade: " + s.Calculate() + "\n");

        }
        class Person {
            protected string firstName;
            protected string lastName;
            protected int id;

            public Person() { }
            public Person(string firstName, string lastName, int identification) {
                this.firstName = firstName;
                this.lastName = lastName;
                this.id = identification;
            }
            public void printPerson() {
                Console.WriteLine("Name: " + lastName + ", " + firstName + "\nID: " + id);
            }
        }

        class Student : Person {
            private int[] testScores;
            public Student(string firstName, string lastName, int identification, int[] testScores) {
                this.firstName = firstName;
                this.lastName = lastName;
                this.id = identification;
                this.testScores = testScores;
            }

            internal string Calculate() {


                int sum = 0;

                for (int i = 0; i < testScores.Length; i++) {
                    sum += testScores[i];
                }
                decimal avg = 0;
                try {
                    avg = (decimal)sum / testScores.Length;
                } catch (Exception) {


                }


                if (avg >= 90 && avg <= 100) {
                    return "O";
                } else if (avg >= 80 && avg < 90) {
                    return "E";
                } else if (avg >= 70 && avg < 80) {
                    return "A";
                } else if (avg >= 55 && avg < 70) {
                    return "P";
                } else if (avg >= 40 && avg < 55) {
                    return "D";
                } else if (avg < 40) {
                    return "T";
                }

                return "D";
            }
            /*	
*   Class Constructor
*   
*   Parameters: 
*   firstName - A string denoting the Person's first name.
*   lastName - A string denoting the Person's last name.
*   id - An integer denoting the Person's ID number.
*   scores - An array of integers denoting the Person's test scores.
*/
            // Write your constructor here

            /*	
            *   Method Name: Calculate
            *   Return: A character denoting the grade.
            */
            // Write your method here
        }
    }





}