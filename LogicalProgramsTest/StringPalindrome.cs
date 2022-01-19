using System;
using System.Text;

namespace LogicalProgramsTest
{
    /// <summary>
    /// Prob No 3: Check the given string is Palindrome or not.
    /// </summary>
    class StringPalindrome
    {
        public void StPalindrome()
        {
            Console.Write("Enter a string to Check Palindrome : ");
            string name = Console.ReadLine();
            string reverse = string.Empty;

            for (int i = name.Length - 1; i >= 0; i--)
            {
                reverse = reverse + name[i];               //ABA
            }

            if (name == reverse)
            {
                Console.WriteLine($"{name} is Palindrome.");
            }
            else
            {
                Console.WriteLine($"{name} is not Palindrome");
            }
        }

    }


    /// <summary>
    /// Case 6: Check the given String is Palindrome or not using String Builder
    /// </summary>
    public class PalindromeChecker
    {
        // Method-1 : Using bool return type method

        public static bool isPalindrome(String str)
        {
            StringBuilder sb = new StringBuilder();

            for (int i = str.Length - 1; i >= 0; i--)
            {
                sb.Append(str[i]);
            }
            String rev = sb.ToString();
            Console.WriteLine(rev);

            if (str.Equals(rev))
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        // Method-2 : Without any return type Method
        public static void StrPalindrome()
        {
            Console.WriteLine("Enter your string to check Palindrome");
            string str = Console.ReadLine();
            StringBuilder sb = new StringBuilder();

            for (int i = str.Length - 1; i >= 0; i--)
            {
                sb.Append(str[i]);
            }
            String rev = sb.ToString();

            if (str.Equals(rev))
            {
                Console.WriteLine($"{str} is Palindrome");      // $ is used to take value
            }
            else
            {
                Console.WriteLine($"{str} is not Palindrome");
            }
        }
    }
}
