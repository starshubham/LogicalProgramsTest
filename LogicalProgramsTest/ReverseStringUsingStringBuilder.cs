using System;
using System.Text;

namespace LogicalProgramsTest
{
    /// <summary>
    /// Problem No 5: Reverse the string using string builder.
    /// </summary>
    class ReverseStringUsingStringBuilder
    {
        public void ReverseString()
        {
            Console.WriteLine("Enter the string to reverse :");
            string name = Console.ReadLine();

            StringBuilder builder = new StringBuilder();
            for (int i = name.Length - 1; i >= 0; i--)
            {
                builder.Append(name[i]);
            }
            string newName = builder.ToString();

            Console.WriteLine(newName);
        }
    }
}
