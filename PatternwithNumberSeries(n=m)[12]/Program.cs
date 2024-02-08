namespace PatternwithNumberSeries_n_m__12_
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Kindly enter the No of rows: ");
            int input = int.Parse(Console.ReadLine());

            for (int row = 1; row <= input; row++)
            {
                for (int column = row; column <= input; column++)
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
2 3 4 5 6
3 4 5 6
4 5 6
5 6
6
*/