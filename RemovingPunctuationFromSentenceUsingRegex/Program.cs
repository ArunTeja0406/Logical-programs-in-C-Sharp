using System.Text.RegularExpressions;

namespace RemovingPunctuationFromSentenceUsingRegex
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string input = getInputString();
            string cleanedString = removePunctuations(input);
            Console.WriteLine(cleanedString);
        }

        static string getInputString()
        {
            Console.WriteLine("Kindly enter the input string");
            return Console.ReadLine();
        }
        static string removePunctuations(string input)
        {
            return Regex.Replace(input, @"[\p{P}-[.]]", "");
        }
    }
}