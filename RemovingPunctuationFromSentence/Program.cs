using System;
using System.Text;

namespace RemovingPunctuationFromSentence
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string input = getInputSting();
            string cleanedString = RemovePunctuation(input);
            Console.WriteLine(cleanedString);
        }
        static string getInputSting()
        {
            Console.WriteLine("Kindly enter the input string");
            return Console.ReadLine();
        }

        static string RemovePunctuation(string input)
        {
            StringBuilder result= new StringBuilder();
            foreach (char item in input)
            {
                if (!char.IsPunctuation(item))
                {
                    result.Append(item);
                }
            }
            return result.ToString();
        }
    }
}