using System;

namespace LogicalProgramsTest
{
    public class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter your Choice: ");
            Console.WriteLine("\n1.Fibonacci Series" +
                "\n2.Reverse the numbers" +
                "\n3.String Palindrome" +
                "\n4.Number Palindrome" +
                "\n5.Reverse the String Using String Builder" +
                "\n6.String Palindrome Using String Builder" +
                "\n7.Largest number in Array" +
                "\n8.Reverse The Given String" +
                "\n9.Reverse Each Word in the given string");

            int Choice = int.Parse(Console.ReadLine());

            switch (Choice)
            {
                case 1:
                    FibonacciSeries fibonacci = new FibonacciSeries();
                    fibonacci.Fibonacci();
                    break;
                case 2:
                    ReverseTheNumber reverse = new ReverseTheNumber();
                    reverse.ReverseNumber();
                    break;
                case 3:
                    StringPalindrome palindrome = new StringPalindrome();
                    palindrome.StPalindrome();
                    break;
                case 4:
                    NumberPalindrome numPalindrome = new NumberPalindrome();
                    numPalindrome.NumPalindrome();
                    break;
                case 5:
                    ReverseStringUsingStringBuilder rev = new ReverseStringUsingStringBuilder();
                    rev.ReverseString();
                    break;
                case 6:
                    // Method-1
                    PalindromeChecker.StrPalindrome();
                    // Method-2
                    Console.WriteLine("\nEnter your string to check palindrome.");
                    string input = Console.ReadLine();
                    Console.WriteLine(PalindromeChecker.isPalindrome(input));
                    break;
                case 7:
                    LargestNumberInArray largest = new LargestNumberInArray();
                    int largestNum = largest.Largest();
                    Console.WriteLine("Largest number in the given array is: " + largestNum);
                    break;
                case 8:
                    string revString = ReverseTheString.ReverseStr("hi hello");
                    Console.WriteLine(revString);
                    break;
                case 9:
                    ReverseEachWordInString.ReverseEachWord();
                    break;
                default:
                    Console.WriteLine("Please Enter a Valid Key.");
                    break;
            }

        }
    }
}
