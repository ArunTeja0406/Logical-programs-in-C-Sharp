namespace PrimeNumbersWithinRange_Boolean_02_
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Kindly enter the input range value: ");
            int input = int.Parse(Console.ReadLine());

            Console.Write("Prime numbers up to " + input + ": ");

            for (int num = 2; num <= input; num++)
            {
                int flag = 0;
                for (int i = 2; i < num; i++)
                {
                    if (num % i == 0)
                    {
                        flag = 1;
                        break;
                    }
                }

                if (flag == 0)
                {
                    Console.Write(num + " ");
                }
            }
        }
    }
}