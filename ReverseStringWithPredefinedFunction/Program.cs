namespace ReverseStringWithPredefinedFunction
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter the string input: ");
            string input = Console.ReadLine();
            string reverse = string.Empty;

            int length = input.Length - 1;

            while (length>=0)
            {
                reverse = reverse + input[length];
                length--;
            }
            Console.WriteLine(reverse);
        }
    }
}