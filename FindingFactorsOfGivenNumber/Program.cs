namespace FindingFactorsOfGivenNumber
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter the number to find the factors: ");
            int input = int.Parse(Console.ReadLine());

            Console.WriteLine($"Your input value: {input}");

            int sum = 0;

            for (int i = 1; i <= input; i++)
            {
                if (input % i == 0)
                {
                    Console.WriteLine($"{i}");
                    sum += i; //to get sum of factors
                }
            }
            Console.WriteLine($"The sum value of factors is : {sum}");
        }
    }
}