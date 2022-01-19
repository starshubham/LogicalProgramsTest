using System;

namespace LogicalProgramsTest
{
    /// <summary>
    /// Problem No 2: Reverse the given number. eg:- 789 --> 987
    /// </summary>
    class ReverseTheNumber
    {
        public void ReverseNumber()
        {
            int n, reverse = 0, rem;
            Console.Write("Enter a number: ");
            n = int.Parse(Console.ReadLine());
            while (n != 0)
            {
                rem = n % 10;                   
                reverse = reverse * 10 + rem;   
                n /= 10;
            }
            Console.Write("Reversed Number is : " + reverse);
        }
        
    }
}
