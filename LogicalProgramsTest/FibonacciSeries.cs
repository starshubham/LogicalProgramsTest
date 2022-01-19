using System;

namespace LogicalProgramsTest
{
    /// <summary>
    /// Problem No 1: Find Fibonacci Series till the nth term.
    /// Fibonacci Series is a series in which each term is sum of last two terms.
    /// Example: { 0 1 1 2 3 5 8 13 21 34 55 89 }
    /// </summary>
    class FibonacciSeries
    {
        public void Fibonacci()
        {
            int n1 = 0, n2 = 1, n3, i, number;
            Console.Write("Enter the number of elements: ");
            number = int.Parse(Console.ReadLine());
            Console.Write(n1 + " " + n2 + " ");     //printing 0 and 1  and it is base condition
            for (i = 2; i < number; i++)            //loop starts from 2 because 0 and 1 are already printed    
            {
                n3 = n1 + n2;
                Console.Write(n3 + " ");
                n1 = n2;
                n2 = n3;
            }
        }
    }
}
