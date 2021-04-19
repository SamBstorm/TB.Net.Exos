using System;
using TB.Net.Exo07___Structs;

namespace TB.Net.Exo07___Client
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Résolution équation second degré");
            EquationSecondDegre eq;
            eq.A = 1;
            eq.B = 3;
            eq.C = 2;
            Console.WriteLine($"L'équation enregistrée est {eq.A}X² + {eq.B}X + {eq.C}");
            double? solution1, solution2;
            if(eq.ResoudreV1(out solution1, out solution2))
            {
                Console.WriteLine("Solution possible :");
                Console.WriteLine($"X1 vaut {solution1}");
                if (!(solution2 is null)) Console.WriteLine($"X2 vaut {solution2}");
            }
            else Console.WriteLine("Aucune solution à l'équation");
        }
    }
}
