using System;
using System.Linq;

namespace conditionsPractice
{
    public class ConditionPracticeClass
    {
        /*TODO: The method must receive one parameter of the int type as input - a number to check.
        The method must return a boolean value, depending on whether the input parameter is even or odd*/
        public static bool IsEven(int number)
        {
            return number % 2 == 0;
        }

        /* TODO: Receives a string as input and returns true if the string contains only unique characters, false otherwise. */
        public static bool HasUniqueCharacters(string input)
        {
            return input.Distinct().Count() == input.Length;
        }

        /* TODO: Receives an integer as input and returns true if the number is divisible by both 5 and 7, excluding zero, false otherwise. */
        public static bool IsDivisibleBy5And7(int number)
        {
            return number % 35 == 0 && number != 0;
        }

        /* TODO: Performs the specified arithmetic operation (char input paramether) on two double input paramethers and returns the result. */
        public static double PerformOperation(char operation, double number1, double number2)
        {
            double result = 0;

            switch (operation)
            {
                case '+':
                    result = number1 + number2;
                    break;
                case '-':
                    result = number1 - number2;
                    break;
                case '*':
                    result = number1 * number2;
                    break;
                case '/':
                    result = number1 / number2;
                    break;
                default:
                    Console.WriteLine("Невідома операція.");
                    break;
            }

            return result;
        }

        /* TODO: Receives an integer as input and returns "Positive" if the number is positive, "Negative" if the number is negative, "Zero" if the number is zero. */
        public static string CheckNumber(int number)
        {
            if (number > 0)
            {
                return "Positive";
            }
            else if (number < 0)
            {
                return "Negative";
            }
            else
            {
                return "Zero";
            }
        }

        /* TODO: Receives a string as input and returns true if the string is a palindrome, false otherwise. */
        public static bool IsPalindrome(string input)
        {
            input = input.ToLower();
            string reversed = new string(input.Reverse().ToArray());

            return input == reversed;
        }

        /* TODO: Receives a int year as input paramether and returns true if the year is a leap year, false otherwise. */
        public static bool IsLeapYear(int year)
        {
            if (year % 4 != 0)
                return false;

            if (year % 100 != 0)
                return true;

            if (year % 400 == 0)
                return true;

            return false;
        }


        /* TODO: Receives a character as input and returns true if the character is a vowel, false otherwise. */
        public static bool IsVowel(char character)
        {
            char lowerChar = char.ToLower(character);
            return lowerChar == 'a' || lowerChar == 'e' || lowerChar == 'i' || lowerChar == 'o' || lowerChar == 'u';
        }

        /* TODO: Converts a binary number represented as a string to its integer equivalent. */
        public static int BinaryToDecimal(string binaryNumber)
        {
            int resultNumber = 0;
            int power = 0;

            for (int i = binaryNumber.Length - 1; i >= 0; i--)
            {
                int digit = binaryNumber[i] - '0';
                resultNumber += digit * (int)Math.Pow(2, power);
                power++;
            }

            return resultNumber;
        }

        /* TODO: Converts a binary number represented as a string to its hexadecimal string equivalent. */
        public static string BinaryToHexadecimal(string binaryNumber)
        {
            string hexadecimalNumber = "";
            int prevIndex = 0;
            int currentIndex = binaryNumber.Length % 4;
            if (currentIndex == 0) currentIndex = 4;
            while (currentIndex <= binaryNumber.Length)
            {
                string tempBinary = binaryNumber.Substring(prevIndex, currentIndex);
                int power = 0;
                int tempNumber = 0;
                for (int i = tempBinary.Length - 1; i >= 0; i--)
                {
                    if (tempBinary[i] == '1') tempNumber += (int)Math.Pow(2, power);
                    power++;
                }
                if (tempNumber < 10) hexadecimalNumber += tempNumber;
                else if (tempNumber == 10) hexadecimalNumber += 'A';
                else if (tempNumber == 11) hexadecimalNumber += 'B';
                else if (tempNumber == 12) hexadecimalNumber += 'C';
                else if (tempNumber == 13) hexadecimalNumber += 'D';
                else if (tempNumber == 14) hexadecimalNumber += 'E';
                else hexadecimalNumber += 'F';
                prevIndex = currentIndex;
                currentIndex += 3;
            }
            return hexadecimalNumber;
        }
    }
}
