using System;
using System.Linq;

namespace LogicalProgramsTest
{
    /// <summary>
    /// Problem No 9 : Reverse Each Word in a String Using C#  Example => "hi hello" to "ih olleh"               
    /// </summary>
    class ReverseEachWordInString
    {
        public static void ReverseEachWord()
        {
            // Method-1
            // Without using any built-in function:
            Console.Write("Enter a String : ");
            string str = Console.ReadLine();

            string strRev = "";

            foreach (var word in str.Split(' '))
            {
                string temp = " ";
                foreach (var ch in word.ToCharArray())
                {
                    temp = ch + temp;
                }
                strRev = strRev + temp + "";
            }
            Console.WriteLine(strRev);              

            // Method-2
            // Using Linq to Reverse Each Word in C#
            Console.WriteLine("\nReverse each word of the string using Linq");
            Console.Write("Enter a String : ");
            string originalString = Console.ReadLine();

            string reverseWordString = string.Join(" ", originalString
            .Split(' ')
            .Select(x => new String(x.Reverse().ToArray() )));
            Console.WriteLine($"Reverse Word String : {reverseWordString}");
            Console.ReadKey();

            /*
            Explanation for the above code:
 
            Split the input string using a single space as the separator.
            Split() method for returning a string array that contains each word of the input string.
            Select method for constructing a new string array, by reversing each character in each word.
            Join method for converting the string array into a string.
            */
        }

    }
}
