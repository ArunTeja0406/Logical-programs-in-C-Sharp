using System;
using temperatureConversion;

namespace logicalPrograms
{
    class tempConversion
    {
        static void Main(string[] arg)
        {
            TemperatureConversion temp = new TemperatureConversion();

            Console.WriteLine("Enter the Celsius: ");
            string var1 = Console.ReadLine();
            double fahrenheit = temp.CelsiusToFahrenheit(var1);
            Console.WriteLine($"The value of Celsius {var1} is fahrenheit value {fahrenheit}");

            Console.WriteLine("Enter the Fahrenheit: ");
            string var2 = Console.ReadLine();
            double celsius = temp.FahrenheitToCelsius(var2);
            Console.WriteLine($"The value of celsius {var2} is celsius value {celsius}");
        }
    }
}