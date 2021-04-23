using System;

namespace TB.Net.ExoBonus02
{
    class Program
    {
        static void Main(string[] args)
        {
            #region Essais avec élèves
            //Console.ResetColor();
            //int white = 15;
            //ConsoleColor blue = ConsoleColor.Blue;
            //int taille = 8;
            //string message = " ";
            ////string[] tab1 = new string[taille];
            //for (int j = 0; j < taille; j++)
            //{
            //    if(j%2 != 0)
            //    {
            //        int i = 0;
            //        while (i < taille)
            //        {
            //            //tab1[i] = message;
            //            if (i % 2 == 0)
            //            {
            //                Console.BackgroundColor = (ConsoleColor)white;
            //            }
            //            else
            //            {
            //                Console.BackgroundColor = blue;
            //            }
            //            //Console.BackgroundColor = (i % 2 == 0) ? (ConsoleColor)white : blue;
            //            Console.Write(message);
            //            i++;
            //        }
            //        Console.WriteLine();
            //    }
            //    else
            //    {
            //        int i = 0;
            //        while (i < taille)
            //        {
            //            //tab1[i] = message;
            //            if (i % 2 != 0)
            //            {
            //                Console.BackgroundColor = (ConsoleColor)white;
            //            }
            //            else
            //            {
            //                Console.BackgroundColor = blue;
            //            }
            //            //Console.BackgroundColor = (i % 2 == 0) ? (ConsoleColor)white : blue;
            //            Console.Write(message);
            //            i++;
            //        }
            //        Console.WriteLine();
            //    }

            //} 
            #endregion
            ushort taille;
            do Console.WriteLine("Veuillez introduire la taille du tableau :");
            while (!ushort.TryParse(Console.ReadLine(), out taille));
            Damier d;
            d.Taille = taille;
            d.Couleurs = new ConsoleColor[2];
            d.Couleurs[0] = ConsoleColor.White;
            d.Couleurs[1] = ConsoleColor.Blue;

            string damier = d.ToString();

        }
    }
}
