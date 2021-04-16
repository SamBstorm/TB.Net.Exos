using System;
using System.Collections.Generic;
using System.Text;

namespace TB.Net.Exo06_Temperature
{
    public struct Celsius
    {
        public double Temperature;

        public Fahrenheit ToFahrenheit()
        {
            Fahrenheit f;
            f.Temperature = (Temperature * 1.8) + 32;
            return f;
        }
    }

    public struct Fahrenheit
    {
        public double Temperature;

        public Celsius ToCelsius()
        {
            Celsius c;
            c.Temperature = (Temperature - 32) * (5D / 9);
            return c;
        }
    }
}
