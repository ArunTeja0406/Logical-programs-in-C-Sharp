namespace MultiplicationTablesWithinRangeGiven
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter the input range: ");
            int input = int.Parse(Console.ReadLine());

            for (int i = 2; i <= input; i++)
            {
                for (int j = 1; j <= 10; j++)
                {
                    Console.WriteLine($"{i} * {j} = {i * j}" + "\t");
                }
                Console.WriteLine();
            }
        }
    }
}