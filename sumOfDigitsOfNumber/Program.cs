using System;

namespace LogicalProgram
{
    class sumOfDigits
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter the number: ");
            int Number = Int32.Parse(Console.ReadLine());
            
            int sum = 0, remainder = 0;

            while(Number != 0)
            {
                remainder = Number % 10; // Will return remainder i.e., Will take the last digit out of number
                sum += remainder;
                Number /= 10; // will return quotient 
            }
            Console.WriteLine(sum);
        }
    }
}