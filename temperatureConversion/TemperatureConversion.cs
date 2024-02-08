using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace temperatureConversion
{
    internal class TemperatureConversion
    {
        public double CelsiusToFahrenheit(string CelTemp)
        {
            double celsius = double.Parse(CelTemp);
            double fahrenheit = (celsius * 9 / 5) + 32;
            return fahrenheit;
        }

        public double FahrenheitToCelsius(string FahrenheitTemp)
        {
            double fahrenheit = double.Parse (FahrenheitTemp);
            double celsius = (fahrenheit - 32) * 5 / 9;
            return celsius;
        }
    }
}
