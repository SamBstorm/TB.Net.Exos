using System;
using TB.Net.Exo07___Structs;

namespace TB.Net.Exo07___SecondClient
{
    class Program
    {
        static void Main(string[] args)
        {
            EquationSecondDegre eq;

            Console.WriteLine("Please enter value for the equation,");

            do Console.WriteLine("Value A:");
            while (!double.TryParse(Console.ReadLine(), out eq.A));
            do Console.WriteLine("Value B:");
            while (!double.TryParse(Console.ReadLine(), out eq.B));
            do Console.WriteLine("Value C:");
            while (!double.TryParse(Console.ReadLine(), out eq.C));

            Console.WriteLine("The solution is :");
            if (!eq.ResoudreV3(out _, out _)) Console.WriteLine("No solution");
            if (eq.ResoudreV3(out double? x1, out double? x2)) if (x2 is null) Console.WriteLine($"Only {x1} is possible."); else Console.WriteLine($"Two solutions was found : {x1} & {x2}");
        }
    }
}
