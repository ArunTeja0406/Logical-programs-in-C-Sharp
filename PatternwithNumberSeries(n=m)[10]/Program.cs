namespace PatternwithNumberSeries_n_m__10_
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Kindly enter the No of rows: ");
            int input = int.Parse(Console.ReadLine());

            for (int row = 1; row <= input; row++)
            {
                for (int column = input; column >= row; column--)
                {
                    Console.Write(row + " ");
                }
                Console.WriteLine(" ");
            }
        }
    }
}
/* Pattern:
1 1 1 1 1 1
2 2 2 2 2
3 3 3 3
4 4 4
5 5
6
*/