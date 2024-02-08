namespace PatternwithNumberSeries_n_m__11_
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Kindly enter the No of rows: ");
            int input = int.Parse(Console.ReadLine());

            for (int row = input; row >= 1; row--)
            {
                for (int column = 1; column <= row; column++)
                {
                    Console.Write(column + " ");
                }
                Console.WriteLine(" ");
            }
        }
    }
}
/* Pattern:
1 2 3 4 5 6
1 2 3 4 5
1 2 3 4
1 2 3
1 2
1
*/