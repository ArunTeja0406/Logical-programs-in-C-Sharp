namespace SumOfNaturalNumber
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter the count: ");
            int input = int.Parse(Console.ReadLine());

            int sum = 0;

            for (int i = 1; i <= input; i++)
            {
                sum += i;     //for even natural number add condition: if(i%2==0){ }
            }
            Console.WriteLine($"The resultant value is : {sum}");
        }
    }
}