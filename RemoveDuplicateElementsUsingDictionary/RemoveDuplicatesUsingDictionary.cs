using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RemoveDuplicateElementsInArray
{
    public class RemoveDuplicateElementsUsingDictionary
    {
        static void Main(string[] args)
        {
            int[] arrayWithDuplicates = { 1, 3, 1, 2, 4, 2, 3, 4, 4, 6, 5, 6 };

            var dictionary = new Dictionary<int, int>();

            for (int i = 0; i < arrayWithDuplicates.Length; i++)
            {
                if (dictionary.ContainsKey(arrayWithDuplicates[i]))
                {
                    dictionary.Remove(arrayWithDuplicates[i]);
                }
                dictionary.Add(arrayWithDuplicates[i], i);
            }

            var keys = dictionary.Keys;

            foreach (var k in keys)
            {
                Console.Write(k);
            }
        }
    }
}
