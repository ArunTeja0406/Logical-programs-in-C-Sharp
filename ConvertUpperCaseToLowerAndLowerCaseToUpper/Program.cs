namespace ConvertUpperCaseToLowerAndLowerCaseToUpper
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Kindly enter the input string: ");
            string input = Console.ReadLine();

            string result = string.Empty;

            for (int i = 0; i < input.Length; i++)
            {
                if (input[i] >= 'a' && input[i] <= 'z')
                {
                    result += (char)(input[i] - 32); // This logic converts Lower case to Upper case
                }
                else if (input[i] >= 'A' && input[i] <='Z')
                {
                    result += (char)(input[i] + 32); // This logic converts Upper case to Lower case
                }
                else
                {
                    result += (char)(input[i]); 
                }
            }
            Console.WriteLine(result);  
        }
    }
}