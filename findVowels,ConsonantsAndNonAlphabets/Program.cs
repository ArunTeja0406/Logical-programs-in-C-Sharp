namespace findVowels_ConsonantsAndNonAlphabets
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Kindly enter the input string!");
            string input = Console.ReadLine();

            string lowerCase = input.ToLower(); // Convert input string to lower case for ease and short code

            int vowelsCount = 0; // To count the number of vowels 
            int consonantCount = 0; // To count the number of consonants 
            int nonAlphabetsCount = 0; // To count the number of non-alphabets 

            for (int i = 0; i < lowerCase.Length; i++)
            {
                if (lowerCase[i] >= 'a' && lowerCase[i] <= 'z') 
                {
                    if (lowerCase[i] == 'a' || lowerCase[i] == 'e' || lowerCase[i] == 'i' || lowerCase[i] == 'o' || lowerCase[i] == 'u')
                    {
                        Console.WriteLine($"{lowerCase[i]} is vowel");
                        vowelsCount++;
                    }
                    else
                    {
                        Console.WriteLine($"{lowerCase[i]} is consonant");
                        consonantCount++;
                    }
                }
                else
                {
                    Console.WriteLine($"{lowerCase[i]} is non-alphabet"); 
                    nonAlphabetsCount++;
                }
            }
            Console.WriteLine("Vowels Count: {0}, Consonants Count: {1}, Non-Alphabets Count: {2}", vowelsCount, consonantCount, nonAlphabetsCount);

        }
    }
}