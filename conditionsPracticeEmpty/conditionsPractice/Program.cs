using System;

namespace conditionsPractice
{
    internal class Program
    {
        static void Main(string[] args)
        {
            bool isPol = ConditionPracticeClass.IsPalindrome("12321");
            bool isDivicible = ConditionPracticeClass.IsDivisibleBy5And7(35);
            Console.WriteLine("Is divisible 5 and 7? " + isDivicible);
            bool uniqueChar = ConditionPracticeClass.HasUniqueCharacters("abcdefghi");
            Console.WriteLine("String is unique? " + uniqueChar);
            bool isEven = ConditionPracticeClass.IsEven(12);
            Console.WriteLine("number Even? " + isEven);
            Console.ReadKey();
        }
    }
}
