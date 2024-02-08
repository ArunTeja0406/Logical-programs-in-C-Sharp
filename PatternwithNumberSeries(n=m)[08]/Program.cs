namespace PatternwithNumberSeries_n_m__08_
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Kindly enter the No. of rows");
            int input = int.Parse(Console.ReadLine());

            for (int row = input; row >= 1; row--)
            {
                for (int column = row; column >= 1; column--)
                {
                    Console.Write(row + " ");
                }
                Console.WriteLine(" ");
            }
        }
    }
}
/* Pattern:
6 6 6 6 6 6
5 5 5 5 5
4 4 4 4
3 3 3
2 2
1
*/