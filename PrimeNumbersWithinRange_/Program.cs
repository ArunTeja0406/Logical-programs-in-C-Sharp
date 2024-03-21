namespace PrimeNumbersWithinRange_
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Kindly enter the input range value: ");
            int input = int.Parse(Console.ReadLine());

            PrintPrimeNumbers(input);
        }
        // Method to check if a number is prime
        static bool IsPrime(int num)
        {
            if (num < 2)
            {
                return false;
            }

            for (int i = 2; i < num; i++)
            {
                if (num % i == 0)
                {
                    return false;
                }
            }
            return true;
        }

        // Method to print prime numbers up to a given input
        static void PrintPrimeNumbers(int maxRange)
        {
            Console.Write("Prime numbers up to " + maxRange + ": ");

            for (int num = 2; num <= maxRange; num++)
            {
                if (IsPrime(num))
                {
                    Console.Write(num + " ");
                }
            }
        }
    }
}