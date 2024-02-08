using System;

namespace LogicalProgram
{
    class sumOfDigits
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter ther number: ");
            int Number = Int32.Parse(Console.ReadLine());

            int sum = 0, remainder = 0;

            while(Number != 0)
            {
                remainder = Number % 10;
                sum += remainder;
                Number /= 10;
            }
            Console.WriteLine(sum);
        }
    }
}