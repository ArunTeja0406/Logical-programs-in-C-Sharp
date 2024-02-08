namespace FindLeapYearOrNot
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Kindly enter the Year to check if it's Leap year: ");
            int input = int.Parse(Console.ReadLine());

            if ((input % 4 == 0 && input % 100 != 0 || input % 400 == 0))
            {
                Console.WriteLine("Yes, input is Leap year");
            }
            else
            {
                Console.WriteLine("No, try again. Thank you!");
            }
        }
    }
}