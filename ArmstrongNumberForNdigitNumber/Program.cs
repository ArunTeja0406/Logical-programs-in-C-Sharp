using System;

namespace ArmstrongNumberForNdigitNumber
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Kindly enter the input value: ");
            int input = int.Parse(Console.ReadLine());

            int numDigits = CalculatePowerNumber(input);
            int result = ComputeArmstrongNumber(input, numDigits);

            if (IsArmstrongNumber(input, result)) // Condition evaluates to true 
            {
                Console.WriteLine("Given input is an Armstrong number.");
            }
            else
            {
                Console.WriteLine("Given input is not an Armstrong number.");
            }
        }

        // Method to calculate the digits of number
        static int CalculatePowerNumber(int input)
        {
            int numDigits = 0;
            for (int quotient = input; quotient != 0; numDigits++) 
            {
                quotient = quotient / 10;
            }
            return numDigits;
        }

        // Method to compute the Armstrong number
        static int ComputeArmstrongNumber(int input, int numDigits)
        {
            int result = 0;
            for (int quotient = input; quotient != 0; quotient = quotient / 10) 
            {
                int remainder = quotient % 10;
                result += (int)Math.Pow(remainder, numDigits);
            }
            return result;
        }

        // Method to check if a number is an Armstrong number
        static bool IsArmstrongNumber(int input, int result)
        {
            return input == result;
        }
    }
}
