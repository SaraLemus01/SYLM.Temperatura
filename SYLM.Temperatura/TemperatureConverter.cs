using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SYLM.Temperatura
{
    public class TemperatureConverter
    {

        public double CelsiusToFahrenheit(double celsius)
        {
            // La fórmula para convertir Celsius a Fahrenheit es: (Celsius * 9/5) + 32
            return (celsius * 9 / 5) + 32;
        }

        public double FahrenheitToCelsius(double fahrenheit)
        {
            // La fórmula para convertir Fahrenheit a Celsius es: (Fahrenheit - 32) * 5/9
            return (fahrenheit - 32) * 5 / 9;
        }
    }
}
