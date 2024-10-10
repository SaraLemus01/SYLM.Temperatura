using Microsoft.VisualStudio.TestTools.UnitTesting;
using SYLM.Temperatura;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SYLM.Temperatura.Tests
{
    [TestClass()]
    public class TemperatureConverterTests
    {
        
            [TestMethod()]
            public void CelsiusToFahrenheitTest()
            {
                TemperatureConverter converter = new TemperatureConverter();
                double result = converter.CelsiusToFahrenheit(0);
                Assert.AreEqual(32, result);

                result = converter.CelsiusToFahrenheit(100);
                Assert.AreEqual(212, result);

                result = converter.CelsiusToFahrenheit(-40);
                Assert.AreEqual(-40, result);
            }

            [TestMethod()]
            public void FahrenheitToCelsiusTest()
            {
                TemperatureConverter converter = new TemperatureConverter();
                double result = converter.FahrenheitToCelsius(32);
                Assert.AreEqual(0, result);

                result = converter.FahrenheitToCelsius(212);
                Assert.AreEqual(100, result);

                result = converter.FahrenheitToCelsius(-40);
                Assert.AreEqual(-40, result);
            }
        
    }
}