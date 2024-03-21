namespace ReverseNumber
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("The enter the input value to reverse: ");
            int input = int.Parse(Console.ReadLine());

            int reverse = 0, remainder;

            while (input > 0)
            {
                remainder = input % 10; //using modulus to get remainder, i.e., to get last digit from number
                reverse = reverse * 10 + remainder;
                input = input / 10; //using divide to get quotient
            }
            Console.WriteLine($"Reverse value: {reverse}");
        }
    }
}