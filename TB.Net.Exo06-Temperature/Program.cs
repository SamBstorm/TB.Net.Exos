using System;

namespace TB.Net.Exo06_Temperature
{
    class Program
    {
        static void Main(string[] args)
        {
            Celsius c;
            c.Temperature = 18.5;

            Fahrenheit c_converti = c.ToFahrenheit();
            Console.WriteLine($"En Celsius {c.Temperature}°C , En Fahrenheit : {c_converti.Temperature}°F");
            Console.WriteLine($"En Celsius {c.Temperature}°C , En Fahrenheit : {c.ToFahrenheit().Temperature}°F");

            Fahrenheit f;
            f.Temperature = 33.2;

            Console.WriteLine($"En Celsius {f.ToCelsius().Temperature}°C , En Fahrenheit : {f.Temperature}°F");
        }
    }
}
