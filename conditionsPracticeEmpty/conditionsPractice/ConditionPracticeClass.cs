using System;
using System.Linq;
using System.Runtime.InteropServices;

namespace conditionsPractice
{
    public class ConditionPracticeClass
    {
        /*TODO: The method must receive one parameter of the int type as input - a number to check.
        The method must return a boolean value, depending on whether the input parameter is even or odd*/
        public static bool IsEven(int number)
        {
            if (number % 2 == 0)
            {
                return true;
            }
            return false;
        }

        /* TODO: Receives a string as input and returns true if the string contains only unique characters, false otherwise. */
        public static bool HasUniqueCharacters(string input)
        {
           if( input.Distinct().Count()== input.Length)
                    return true;
            
            return false;
        }

        /* TODO: Receives an integer as input and returns true if the number is divisible by both 5 and 7, excluding zero, false otherwise. */
        public static bool IsDivisibleBy5And7(int number)
        {
            if(number %35==0 && number != 0)
            {
                return true;
            }
            return false;
        }

        /* TODO: Performs the specified arithmetic operation (char input paramether) on two double input paramethers and returns the result. */
        public static double PerformOperation(char operation, double number1, double number2)
        {
            double res=0;
            switch (operation)
            {
                case '+': 
                    res=number1 + number2;
                    break;
                case '*':
                    res=number1 * number2;
                    break;
                case '-':
                    res=number1 - number2;
                    break;
                case '/':  
                    res=number1 / number2;
                    break;

            }
            return res;
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
            else if(number == 0)
            {
                return "Zero";
            }
            return "No Number";
        }

        /* TODO: Receives a string as input and returns true if the string is a palindrome, false otherwise. */
        public static bool IsPalindrome(string input)
        {
            string revers = new string(input.Reverse().ToArray());
            if(input==revers) return true;
            return false;
        }

        /* TODO: Receives a int year as input paramether and returns true if the year is a leap year, false otherwise. */
        public static bool IsLeapYear(int year)
        {
            return (year % 4 == 0 && (year / 100) % 4 == 0) ;
        }


        /* TODO: Receives a character as input and returns true if the character is a vowel, false otherwise. */
        public static bool IsVowel(char character)
        {
            string str= "aeyuio";
            if (str.ToLower().Contains(character.ToString().ToLower())) return true;
            return false;
        }

        /* TODO: Converts a binary number represented as a string to its integer equivalent. */
        public static int BinaryToDecimal(string binaryNumber)
        {
            double res=0;
            int ind = 0;
            for(int i=binaryNumber.Length-1; i >-1; i--)
            {
                if (Int32.Parse(binaryNumber[i].ToString())==1)
                res += Math.Pow(2, ind);
                ind++;
            }
            return (int)res;
        }

        /* TODO: Converts a binary number represented as a string to its hexadecimal string equivalent. */
        public static string BinaryToHexadecimal(string binaryNumber)
        {
            
            string num = binaryNumber;
            string res = "";
            while (true)
            {
                if (num.Length % 4 != 0)
                    num = '0' + num;
                else break;

                
            }
            for(int i=0; i < num.Length; i+=4)
            {
                double subres=0;
                int ind = 0;
                string subnum = num.Substring(i,4);
                for (int j=subnum.Length-1;j>-1;j--)
                {
                    if (Int32.Parse(subnum[j].ToString()) == 1)
                        subres += Math.Pow(2, ind);
                    ind++;
                }
                if (subres >= 10)
                {
                    switch (subres)
                    {
                        case 10:
                            res = res + 'A';
                            break;
                        case 11:
                            res = res + 'B';
                            break;
                        case 12:
                            res = res + 'C';
                            break;
                        case 13:
                            res = res + 'D';
                            break;
                        case 14:
                            res = res + 'E';
                            break;
                        case 15:
                            res = res + 'F';
                            break;

                    }
                }
                else res = res + (int)subres;
            }
            return res;
        }
    }
}
