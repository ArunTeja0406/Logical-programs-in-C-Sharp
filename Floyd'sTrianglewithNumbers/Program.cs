namespace Floyd_sTrianglewithNumbers
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Kindly enter the No. rows input: ");
            int NoOfRow = int.Parse(Console.ReadLine());

            int counter = 1;

            for (int row = 1; row <= NoOfRow; row++)
            {
                for (int column = 1; column <= row; column++)
                {
                    Console.Write(counter + " ");
                    counter++;
                }
                Console.WriteLine();
            }
        }
    }
}