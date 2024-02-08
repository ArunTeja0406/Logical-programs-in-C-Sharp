namespace OccurencesOfACharInString
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Kindly enter the string input: ");
            string input = Console.ReadLine();

           

            while (input.Length > 0) 
            {
                int count = 0;
                Console.Write($"Occurence of {input[0]} :");
                for (int i = 0; i < input.Length; i++)
                {
                    if (input[0] == input[i])
                    {
                        count++;
                    }
                }
                Console.WriteLine(count);

                input = input.Replace(input[0].ToString(), string.Empty); 
            }
        }
    }
}