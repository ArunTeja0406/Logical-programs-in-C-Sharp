namespace PatternwithNumberSeries_n_m__06_
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Kindly enter the No. of rows");
            int input = int.Parse(Console.ReadLine());

            for (int row = input; row >=1; row--)
            {
                for (int column = input; column >=row ; column--)
                {
                    Console.Write(column + " ");
                }
                Console.WriteLine();
            }
        }
    }
}
/* Pattern:
6
6 5
6 5 4
6 5 4 3
6 5 4 3 2
6 5 4 3 2 1
*/