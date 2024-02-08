using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace temperatureConversionWithSwitch
{
    internal class temperatureConversion
    {
        public double celsiusToFahrenheit(string celTemp)
        {
            double celsius = double.Parse(celTemp);
            double fahrenheit = (celsius*9/5) + celsius;
            return fahrenheit;
        }

        public double fahrenheitToCelsius(string fahrenheitTemp)
        {
            double fahrenheit = double.Parse(fahrenheitTemp);
            double celsius = (fahrenheit - 32) * 5 / 9;
            return celsius;
        }
    }
}
