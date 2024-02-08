namespace Palindrome
{
    internal class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine("The enter the input value to check if it's palindrome: ");
            int input = int.Parse(Console.ReadLine());
            int backUp = input;

            int reverse = 0, remainder;

            while (input > 0)
            {
                remainder = input % 10; //using modulus to get remainder
                reverse = reverse * 10 + remainder;
                input = input / 10; //using divide to get quotient
            }

            if (backUp==reverse)
            {
                Console.WriteLine("Yes, given number is a palindrome. Great!");
            }
            else
            {
                Console.WriteLine("No, given number is not a palindrome");
            }
        }
    }
}