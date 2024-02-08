namespace PrimeNumbersWithinRange
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Kindly enter the input range value: ");
            int input = int.Parse(Console.ReadLine());

            for (int i = 0; i <= input; i++)
            {
                List<int> list = findFactors(i);

                if (list.Count==2)
                {
                    Console.WriteLine($"{i} is a prime number");
                }
                else
                {
                    Console.WriteLine($"{i} is not a prime number");
                }
            }
        }

        static List<int> findFactors(int inputValue)
        {
            List<int> result = new List<int>();
            for (int i = 1; i <= inputValue; i++)
            {
                if (inputValue%i==0)
                {
                    result.Add(i);
                }
            }
            return result;
        }
    }
}