using System; 

namespace ArmstrongNumberWithinRange
{
    public class ArmstrongNumbers
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Enter the range to find Armstrong numbers:");
            int start = int.Parse(Console.ReadLine());
            int end = int.Parse(Console.ReadLine());

            Console.WriteLine($"Armstrong numbers between {start} and {end}:");
            for (int num = start; num <= end; num++)
            {
                if (IsArmstrong(num))
                {
                    Console.WriteLine(num);
                }
            }
        }
        static bool IsArmstrong(int num) // Function to check if a number is an Armstrong number
        {
            int originalNum = num;
            int numDigits = NumDigits(num);
            int sum = 0;

            while (num > 0)
            {
                int digit = num % 10;
                sum += (int)Math.Pow(digit, numDigits);
                num /= 10;
            }

            return sum == originalNum;
        }
        static int NumDigits(int num) // Function to count the number of digits in a number
        {
            int count = 0;
            while (num > 0)
            {
                count++;
                num /= 10;
            }
            return count;
        }
    }

}