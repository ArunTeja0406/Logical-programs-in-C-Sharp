using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RemoveDuplicateElementsInArray
{

    class Program
    {
        static void Main(string[] args)
        {
            int[] arrayWithDuplicates = { 1, 3, 1, 2, 4, 2, 3, 4, 4, 6, 5, 6 };

            Array.Sort(arrayWithDuplicates);
           
            // Array to hold unique elements
            int[] uniqueArray = new int[arrayWithDuplicates.Length];
            int j = 0;

            // Traverse the sorted array and copy unique elements to uniqueArray
            for (int i = 0; i < arrayWithDuplicates.Length-1; i++)
            {
                if (arrayWithDuplicates[i] != arrayWithDuplicates[i + 1])
                {
                    uniqueArray[j++] = arrayWithDuplicates[i];
                }
            }

            // Add the last element
            uniqueArray[j++] = arrayWithDuplicates[arrayWithDuplicates.Length - 1];

            // Trim uniqueArray to remove extra zeros (if any)
            Array.Resize(ref uniqueArray, j);

            // Displaying the unique elements
            Console.WriteLine("Array after removing duplicates:");
            foreach (int element in uniqueArray)
            {
                Console.Write(element + " ");
            }
        }
    }
}
