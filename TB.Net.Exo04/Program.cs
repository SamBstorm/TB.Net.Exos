using System;

namespace TB.Net.Exo04
{
    class Program
    {
        static void Main(string[] args)
        {
            #region Table de multiplication
            //for (int i = 1; i <= 5; i++)
            //{
            //    for (int j = 1; j <= 20; j++)
            //    {
            //        Console.Write($"{j} X {i} = {i * j} ; ");
            //    }
            //    Console.WriteLine();
            //}

            //string message = default;
            //for (int i = 0; i < 5; i++)
            //{
            //    for (int j = 0; j < 20; j++)
            //    {
            //        message += $"{i + 1} X {j + 1} = {(i + 1) * (j + 1)} ; "; 
            //    }
            //    message += "\n";
            //}
            //Console.WriteLine(message);
            #endregion

            #region Fibonacci

            //int nb1 = 0, nb2 = 1, nb_f = nb1 + nb2, i = 3;
            //Console.WriteLine($"F0 -> {nb1}");
            //Console.WriteLine($"F1 -> {nb2}");
            //Console.WriteLine($"F2 -> {nb_f}");
            //while (i < 25) 
            //{
            //    nb1 = nb2;
            //    nb2 = nb_f;
            //    nb_f = nb1 + nb2;
            //    Console.WriteLine($"F{i} -> {nb_f}");
            //    i++;
            //}

            //int nb1 = 0, nb2 = 1, nb_f = nb1 + nb2, i = 3;
            //Console.WriteLine($"F0 -> {nb1}");
            //Console.WriteLine($"F1 -> {nb2}");
            //Console.WriteLine($"F2 -> {nb_f}");
            //do
            //{
            //    nb1 = nb2;
            //    nb2 = nb_f;
            //    nb_f = nb1 + nb2;
            //    Console.WriteLine($"F{i} -> {nb_f}");
            //    i++;
            //} while (i < 25);

            #endregion

            #region Factorielle

            #region test entrée numérique
            ////bool isDigit = false;
            ////int choice = 0;
            ////while (!isDigit)
            ////{
            ////    Console.WriteLine("Veuillez introduire un nombre");
            ////    string input = Console.ReadLine();
            ////    isDigit = int.TryParse(input, out choice);
            ////}

            ////bool check_int = default;
            ////uint nb = 0;
            ////while (check_int is false)
            ////{
            ////    Console.WriteLine("Veuillez introduire un nombre");
            ////    check_int = uint.TryParse(Console.ReadLine(), out nb);
            ////}

            ////uint nb;
            ////Console.WriteLine("Veuillez introduire un nombre");
            ////while (!uint.TryParse(Console.ReadLine(), out nb))
            ////{
            ////    Console.WriteLine("Ceci n'est pas un nombre, réessayer");
            ////} 
            #endregion

            //uint nb, fact = 1;
            //do Console.WriteLine("Veuillez introduire un nombre");
            //while (!uint.TryParse(Console.ReadLine(), out nb));

            //for (uint i = nb; i > 0; i--)
            //{
            //    fact *= i;
            //}

            //Console.WriteLine($"{nb}! = {fact}");

            #endregion
        }
    }
}
