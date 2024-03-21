using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RemoveWhitespace
{
    public class RemoveWhitespaceInStringPrograms
    {
        //Method 1
        public static void RemoveWhitespaceWithoutFunction()
        {
            string str = "Hey, you are doing well";
            char[] chars = str.ToCharArray();

            string result = string.Empty;

            for (int i = 0; i < str.Length; i++) //We can also use ForEach loop
            {
                if (chars[i] != ' ')
                {
                    result = result + chars[i];
                }
            }
            Console.WriteLine(result);
        }

        //Method 2
        public static void RemoveWhitespaceWithFunction()
        {
            string str = "Hey, you are doing well";

            string result = str.Replace(" ", string.Empty);

            Console.WriteLine(result);
        }

        public static void RemoveWhitespaceWithLINQ()
        {
            string str = "Hey, you are doing well";

            var result = new string(str.Where(c => !char.IsWhiteSpace(c)).ToArray());

            Console.WriteLine(result);
        }
    }
}
