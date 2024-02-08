using Microsoft.VisualBasic;
namespace PatternwithNumberSeries_n_m_05
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Kindly enter the No. of rows");
            int input = int.Parse(Console.ReadLine());

            for (int row = input; row >= 1; row--)
            {
                for (int column = row; column <= input; column++)
                {
                    Console.Write(row + " ");
                }
                Console.WriteLine();    
            }
        }
    }
}
/* Pattern:
6
5 5
4 4 4
3 3 3 3
2 2 2 2 2
1 1 1 1 1 1
*/