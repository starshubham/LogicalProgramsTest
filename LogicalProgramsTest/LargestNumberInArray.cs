using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LogicalProgramsTest
{
    /// <summary>
    /// Problem No 7: Find Lagest number in the array.
    /// </summary>
    public class LargestNumberInArray
    {
        // Method to find maximum in arr[]
        public int Largest()
        {
            int[] arr = { 10, 324, 45, 90, 98 };
            int i;

            // Initialize maximum element
            int max = arr[0];

            // Traverse array elements from second and
            // compare every element with current max 
            for (i = 1; i < arr.Length; i++)
                if (arr[i] > max)
                    max = arr[i];

            return max;
        }
    }
}
