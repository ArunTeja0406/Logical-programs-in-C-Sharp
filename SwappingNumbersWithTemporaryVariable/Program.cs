namespace SwappingNumbersWithTemporaryVariable
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int a = 5, b = 25, temp;
            Console.WriteLine($"The values before swappping a: {a} and b: {b}");

            //temp = a;
            //a = b;
            //b = temp;

            //Now, without temporary value using addition method
            //a = a + b;
            //b = a - b;
            //a = a - b;


            //Now, without temporary value using multiple method
            a = a * b; 
            b = a / b;
            a = a / b;
            Console.WriteLine($"The values after swappping a: {a} and b: {b}");
        }
    }
}