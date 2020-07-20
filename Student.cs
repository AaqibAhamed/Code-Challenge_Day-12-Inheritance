using System;
using System.Collections.Generic;
using System.Text;

namespace Code_Challenge_Day_12_Inheritance
{
    class Student : Person
    {
        private int[] testScores;

        char grade;
        int average;
        int sum;
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
        Student()
        {

        }

        public Student(string firstName, string lastName, int id, int[] scores)
        {
            this.firstName = firstName;

            this.lastName = lastName;

            this.id = id;

            this.testScores = scores;
        }

        /*	
        *   Method Name: Calculate
        *   Return: A character denoting the grade.
        */
        // Write your method here

        public char Calculate()
        {
            foreach (var item in testScores)
            {
                sum += item;
            }

            average = sum / testScores.Length;

            if (average >= 90 && average <= 100)
            {
                grade = 'O';
            }
            else if (average >= 80 && average <= 90)
            {
                grade = 'E';
            }
            else if (average >= 70 && average <= 80)
            {
                grade = 'A';
            }
            else if (average >= 55 && average <= 70)
            {
                grade = 'P';
            }
            else if (average >= 40 && average <= 55)
            {
                grade = 'D';
            }
            else if (average < 40)
            {
                grade = 'T';
            }

            return grade;
        }
    }

}
