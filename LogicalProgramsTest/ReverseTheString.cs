using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LogicalProgramsTest
{
    /// <summary>
    /// Problem No 8: Reverse the string elements eg:- hi hello --> olleh ih
    /// </summary>
    class ReverseTheString
    {
        public static string ReverseStr(string Input)
        {
            // Converting string to character array
            char[] charArray = Input.ToCharArray();

            // Declaring an empty string
            string reverseString = string.Empty;

            // Iterating the each character from right to left
            for (int i = charArray.Length - 1; i >= 0; i--)
            {
                reverseString += charArray[i];
            }
            // Return the reversed string.
            return reverseString;   
        }

    }
}
