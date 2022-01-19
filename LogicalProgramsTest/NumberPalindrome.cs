using System;

namespace LogicalProgramsTest
{
    /// <summary>
    /// Problem No 4: Check the given number is Palindrome or not. eg:- 545
    /// </summary>
    class NumberPalindrome
    {
        public void NumPalindrome()
        {
            Console.Write("Enter a Number To Check Palindrome : ");
            int number = int.Parse(Console.ReadLine());
            int remineder, sum = 0;
            int temp = number;
            while (number > 0)
            {              
                remineder = number % 10;             
                sum = (sum * 10) + remineder;                
                number = number / 10;
            }
            if (temp == sum)
            {
                Console.WriteLine($"Number {temp} is Palindrome.");
            }
            else
            {
                Console.WriteLine($"Number {temp} is not Palindrome");
            }
        }
    }
}
