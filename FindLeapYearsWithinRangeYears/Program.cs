namespace FindLeapYearsWithinRangeYears
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Kindly enter the minimun value: ");
            int minValue = int.Parse(Console.ReadLine());

            Console.WriteLine("Kindly enter the maximum value: ");
            int maxValue = int.Parse(Console.ReadLine());

            for (int i = minValue; i <= maxValue; i++)
            {
                if ((i%4==0 && i%100!=0) || i%400==0)
                {
                Console.WriteLine($"Leap year: {i}");
                }
            }
        }
    }
}