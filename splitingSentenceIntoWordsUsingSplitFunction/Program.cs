using System;

namespace SplittingSentenceIntoWordsUsingSplitFunction
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string input = GetInputString();

            string[] words = SplitSentence(input);

            DisplayWords(words);

            DisplayWordCount(words.Length);
        }

        static string GetInputString()
        {
            Console.WriteLine("Kindly enter the input string: ");
            return Console.ReadLine();
        }

        static string[] SplitSentence(string input)
        {
            return input.Split(',', ' ', '.');
        }

        static void DisplayWords(string[] words)
        {
            Console.WriteLine("Separated words:");
            foreach (var word in words)
            {
                Console.WriteLine(word);
            }
        }

        static void DisplayWordCount(int wordCount)
        {
            Console.WriteLine("\nNumber of words: " + wordCount);
        }
    }
}
