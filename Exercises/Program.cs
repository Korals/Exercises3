using System;
using System.Collections.Generic;
using System.Linq;

namespace Exercises
{
    public class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Feel free to test out your stuff below...");

            var result = ReverseNumber(1234);
            Console.WriteLine(result);
        }

        // Check if a given string is a Palindrome
        // Input: tacocat
        // Output: true
        // Input: vilius
        // Output: false
        public static bool IsPalindrome(string someString)
        {

            if (someString == " ")
                return true;
            else if (someString != null)
            {
                var lowerString = someString.ToLower();
                return lowerString.SequenceEqual(lowerString.Reverse());
            }

            return false;
        }

        // Count Words in a String
        // Input: your mom is gamer
        // Output: 4
        public static int CountWords(string someString)
        {
            int wordCount = 0, index = 0;

            if (someString == null)
                return 0;
            // skip whitespace until first word
            while (index < someString.Length && char.IsWhiteSpace(someString[index]))
                index++;

            while (index < someString.Length)
            {
                // check if current char is part of a word
                while (index < someString.Length && !char.IsWhiteSpace(someString[index]))
                    index++;

                wordCount++;

                // skip whitespace until next word
                while (index < someString.Length && char.IsWhiteSpace(someString[index]))
                    index++;
            }

            return wordCount;
        }

        // How far away from 100
        // Input: 27
        // Output: 73
        // Input: 1000
        // Output: 900
        public static int HowFarFromOneHundred(int number)
        {
            var result = 0;
            var howFar = 100 - number;
            if (howFar > 0)
                result = howFar;
            else if (howFar < 0)
                result = howFar * (-1);
            else
                result = 0;

            return result;
        }

        // Get the last digit of given number
        // Input: 27
        // Output: 7
        // Input: 3245
        // Output: 5
        public static int GetTheLastDigitOfNumber(int number)
        {
            // code goes here ...

            return 0;
        }

        // Check if the given string starts with any of the following hi, hI, Hi, HI
        // Input: hi william
        // Output: true
        // Input: john wick
        // Output: false
        public static bool StartsWithHi(string input)
        {
            if (input.Contains("hi") == true || input.Contains("hI") == true || input.Contains("Hi") == true || input.Contains("HI") == true)
                return true;

            return false;
        }

        // Reverse a number
        // Input: 1234
        // Output: 4321
        // Input: 6969
        // Output: 9696
        public static int ReverseNumber(int input)
        {
            {
                for (int result = 0; ; result = result * 10 + input % 10, input /= 10) if (input == 0) return result;
                return 42;
            }

            return 0;
        }

        // Check of many letters 'e' or 'E' are in a string
        // Input: beetroot
        // Output: 2
        // Input: bomzas
        // Output: 0
        public static int HowManyEsInAString(string input)
        {
            if (input != null)
            { 
            char es = 'e';
            var result = input.Count(s => s == es);
            return result;
            }

            return 0;
        }
    }
}