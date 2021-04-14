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

            #region Nombres premier

            //uint nb, cpt_clc = 0;
            //do Console.WriteLine("Veuillez indiquer combien vous fait-il de nombres premier :");
            //while (!uint.TryParse(Console.ReadLine(), out nb));

            //for (int nb_analyse = 1, count = 0; count < nb; nb_analyse++)
            //{
            //    ushort nb_diviseur = 0;
            //    for (int diviseur = 1; diviseur <= nb_analyse; diviseur++)
            //    {
            //        if (nb_analyse % diviseur == 0) nb_diviseur++;
            //        cpt_clc++;
            //    }
            //    if (nb_diviseur == 2)
            //    {
            //        Console.WriteLine(nb_analyse);
            //        count++;
            //    }
            //}
            //Console.WriteLine(cpt_clc);

            //uint nb, cpt_clc = 0;
            //do Console.WriteLine("Veuillez indiquer combien vous fait-il de nombres premier :");
            //while (!uint.TryParse(Console.ReadLine(), out nb));

            //for (int nb_analyse = 2, count = 0; count < nb; nb_analyse++)
            //{
            //    bool isPrime = true;
            //    for (int diviseur = 2; diviseur <= nb_analyse / 2 && isPrime; diviseur++)
            //    {
            //        if (nb_analyse % diviseur == 0) isPrime = false;
            //        cpt_clc++;
            //    }
            //    if (isPrime)
            //    {
            //        Console.WriteLine(nb_analyse);
            //        count++;
            //    }
            //}
            //Console.WriteLine(cpt_clc);
            #endregion

            #region Boucle de double
            //for (double i = 0.0; i <= 20.0; i+=0.1) Console.WriteLine(i);
            //Calcul faussé du aux type utilisé, le double et le float sont des types dit d'approximation...
            //0.1  => 0.10000000000000000...234587

            //for (int i = 0; i <= 200; i++) Console.WriteLine(i/10D);
            //for (decimal i = 0.0M; i <= 20.0M; i += 0.1M) Console.WriteLine(i);
            #endregion

        }
    }
}
