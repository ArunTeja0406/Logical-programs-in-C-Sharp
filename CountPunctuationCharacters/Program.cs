using System;

namespace CountPunctuationCharacters
{
    class Program
    {
        static void Main()
        {
            string input = "This is a string with some punctuation marks, like commas, periods, and question marks!";

            int punctuationCount = CountPunctuation(input);

            Console.WriteLine($"Punctuation Count: {punctuationCount}");
        }

        static int CountPunctuation(string str)
        {
            int count = 0;
            
            foreach (char c in str)
            {
                if (char.IsPunctuation(c))
                {
                    count++;
                }
            }
            return count;
        }
    }
}