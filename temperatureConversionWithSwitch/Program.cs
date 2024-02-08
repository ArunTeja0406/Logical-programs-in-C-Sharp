namespace temperatureConversionWithSwitch
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter C for celsicusConversion, F for fahrenheitConversion and E for Exit");
            string selection = string.Empty;

            while (selection != "E" && selection != "e")
            {
                selection = Console.ReadLine();

                temperatureConversion temp = new temperatureConversion();
                switch (selection)
                {
                    case "C":
                    case "c":
                        Console.WriteLine("Now, enter the celsius value: ");
                        double fahrenheit = temp.celsiusToFahrenheit(Console.ReadLine());
                        Console.WriteLine($"Fahrenheit result value: {fahrenheit}");
                        break;
                    case "F":
                    case "f":
                        Console.WriteLine("Now, enter the fahrenheit value: ");
                        double celsius = temp.fahrenheitToCelsius(Console.ReadLine());
                        Console.WriteLine($"Celisus result value: {celsius}");
                        break;
                    case "E":
                    case "e":
                        break;
                    default:
                        Console.WriteLine("Try again, if you've entered wrong input ");
                        break;
                }
            }
        }
    }
}