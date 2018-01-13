using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterviewQuestion
{
    class Program
    {
        static void Main(string[] args)
        {
            int a = 9;
            int b = 5;

            Swap(a, b);
        }

        // Question 1: 
        // Assume you have a method isSubstring which checks if one word is a substring of
        // another.Given two strings, s1 and s2, write code to check if s2 is a rotation of s1 using
        // only one call to isSubstring(i.e., “waterbottle” is a rotation of “erbottlewat”).


        // Write a function to swap a number in place without temporary variables.

        static void Swap (int a, int b)
        {
            a = b - a; // a = 9, b = 5; 5 - 9 = -4
            b = b - a; // 5 - (-4) = 9
            a = a + b; // -4 + 9 = 5

            Console.WriteLine("a is: " + a);
            Console.WriteLine("b is: " + b);
        }
    }
}
