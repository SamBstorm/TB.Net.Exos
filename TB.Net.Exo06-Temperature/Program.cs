using System;

namespace TB.Net.Exo06_Temperature
{
    class Program
    {
        static void Main(string[] args)
        {
            Celsius c;
            c.Temperature = 18.5;

            Fahrenheit f;
            f.Temperature = 33.2;

            Console.WriteLine($"En Celsius {c.Temperature} , En Fahrenheit : {f.Temperature}");
        }
    }
}
