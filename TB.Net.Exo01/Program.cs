using System;

namespace TB.Net.Exo01
{
    class Program
    {
        static void Main(string[] args)
        {
            #region int.Parse()

            //Console.Clear();
            //Console.Write("Bonjour veuillez indiquer un premier nombre à additionner : ");
            //string nb1_str = Console.ReadLine();
            //int nb1 = int.Parse(nb1_str);
            //Console.Clear();
            //Console.Write("Maintenant veuillez indiquer un second nombre à additionner : ");
            //int nb2 = int.Parse(Console.ReadLine());
            //Console.Clear();

            //int result = nb1 + nb2;
            //Console.WriteLine($"Le calcul de {nb1_str} + {nb2} = {result} ou {nb1 + nb2}");

            //Console.WriteLine("\nAppuyez sur une touche pour continuer...");
            //Console.Read();
            #endregion

            #region int.TryParse()

            //Console.Clear();
            //Console.Write("Bonjour veuillez indiquer un premier nombre à additionner : ");
            //string nb1_str = Console.ReadLine();
            //bool nb1_check = int.TryParse(nb1_str, out int nb1);
            //Console.Clear();
            //Console.Write("Maintenant veuillez indiquer un second nombre à additionner : ");
            //int.TryParse(Console.ReadLine(), out int nb2);
            //Console.Clear();

            //int result = nb1 + nb2;
            //Console.WriteLine($"Le calcul de {nb1_str} + {nb2} = {result} ou {nb1 + nb2}");

            //Console.WriteLine("\nAppuyez sur une touche pour continuer...");
            //Console.Read();

            #endregion

            #region Get ASCII code

            //Console.Clear();
            //Console.Write("Veuillez introduire un caractère :");
            //string string_code = Console.ReadLine();
            //int i = Console.Read();
            ////Avec class Convert
            //char caractere = Convert.ToChar(string_code);

            ////Avec Parse()
            //caractere = char.Parse(string_code);

            ////Avec TryParse()
            //char.TryParse(string_code, out caractere);

            ////Avec l'index des tableau (voir plus tard)
            //caractere = string_code[0];

            //ushort code_ascii = caractere; // conversion implicite

            //Console.Clear();
            //Console.WriteLine($"Le caractère {caractere} a pour code : {code_ascii} ou {i}");

            //Console.WriteLine("\nAppuyez sur une touche pour continuer...");
            //Console.Read();

            #endregion

            #region Division entière + modulo sans modulo

            Console.Clear();
            Console.Write("Bonjour veuillez indiquer un nombre à diviser : ");
            int nb1;
            int.TryParse(Console.ReadLine(), out nb1);
            Console.Clear();
            Console.Write("Maintenant veuillez indiquer le diviseur : ");
            int nb2;
            int.TryParse(Console.ReadLine(), out nb2);
            Console.Clear();

            int division = nb1 / nb2;
            int reste = nb1 - (division * nb2);

            Console.WriteLine($"La division de {nb1} par {nb2} donne {division} reste {reste}.");


            Console.WriteLine("\nAppuyez sur une touche pour continuer...");
            Console.Read();

            #endregion
        }
    }
}
