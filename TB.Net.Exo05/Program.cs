using System;
using System.Collections;
using System.Collections.Generic;

namespace TB.Net.Exo05
{
    class Program
    {
        static void Main(string[] args)
        {
            #region Nombres premier inférieur à X

            //ArrayList list = new ArrayList();
            //uint nb, cpt_clc = 0;
            //do Console.WriteLine("Veuillez indiquer un nombre pour trouver les nombres premier en dessous de celui-ci :");
            //while (!uint.TryParse(Console.ReadLine(), out nb));
            //int nb_analyse = 2;
            //while ( nb_analyse < nb )
            //{
            //    bool isPrime = true;
            //    int diviseur = 2;
            //    while ( diviseur <= nb_analyse / 2 && isPrime )
            //    {
            //        if (nb_analyse % diviseur == 0) isPrime = false;
            //        cpt_clc++;
            //        diviseur++;
            //    }
            //    if (isPrime)
            //    {
            //        list.Add(nb_analyse);
            //    }
            //    nb_analyse++;
            //}
            //Console.WriteLine($"L'opération à demandé l'utilisation de {cpt_clc} boucles...");

            ////int i = 0;
            ////while (i < list.Count)
            ////{
            ////    int j = (int)list[i];
            ////    Console.WriteLine(j);
            ////    i++;
            ////}
            //if (list.Count > 0)
            //{
            //    foreach (int prime in list)
            //    {
            //        Console.WriteLine(prime);
            //    }
            //}
            //else Console.WriteLine($"Pas de nombres premier inférieur à {nb}");
            #endregion

            #region Nombres premier (Optimisé)

            //List<uint> list = new List<uint>();
            //uint nb, cpt_clc = 0;
            //do Console.WriteLine("Veuillez indiquer combien vous fait-il de nombres premier :");
            //while (!uint.TryParse(Console.ReadLine(), out nb));

            //for (uint nb_analyse = 2, count = 0; 
            //    count < nb; 
            //    nb_analyse = (nb_analyse % 2 == 0) ? nb_analyse + 1 : nb_analyse + 2)
            //{
            //    bool isPrime = true;
            //    for (int index = 0; list.Count > 0 && list[index] <= Math.Sqrt(nb_analyse) && isPrime; index++)
            //    {
            //        if (nb_analyse % list[index] == 0) isPrime = false;
            //        cpt_clc++;
            //    }
            //    if (isPrime)
            //    {
            //        list.Add(nb_analyse);
            //        count++;
            //    }
            //}
            //Console.WriteLine($"L'opération à demandé l'utilisation de {cpt_clc} boucles...");

            //foreach (uint nb_prime in list)
            //{
            //    Console.WriteLine(nb_prime);
            //}

            #endregion

            #region Exemple - ToCharArray()
            //char[] chars = "Salut".ToCharArray(); // donne ['S','a','l','u','t']
            //Console.WriteLine( chars.Length); 
            #endregion

            #region Addition par caractères

            string nb1, nb2;
            char[] c1, c2, c_result;
            do
            {
                Console.WriteLine("Veuillez introduire un nombre : ");
                nb1 = Console.ReadLine();
            } while (!uint.TryParse(nb1, out _));
            c1 = nb1.ToCharArray();
            do
            {
                Console.WriteLine("Veuillez introduire un nombre : ");
                nb2 = Console.ReadLine();
            } while (!uint.TryParse(nb2, out _));
            c2 = nb2.ToCharArray();
            int max_index = (c1.Length > c2.Length) ? c1.Length : c2.Length;
            c_result = new char[max_index+1];
            ushort report = 0; 
            for (int i = 0; i <= max_index; i++)
            {
                ushort ch_1 = (c1.Length - 1 - i < 0)
                                    ?(ushort)0
                                    :ushort.Parse(c1[c1.Length - 1 - i].ToString());
                
                //ushort ch_1 = (ushort)(c1[c1.Length - 1 - i]-48);
                ushort ch_2 = (c2.Length - 1 - i < 0)?(ushort)0:ushort.Parse(c2[c2.Length - 1 - i].ToString());
                ushort result = (ushort)(report + ch_1 + ch_2);


                report = (ushort)( result/ 10);
                c_result[c_result.Length - 1 - i] = (result%10).ToString()[0];
            }

            foreach (char c in c_result)
            {
                Console.Write(c);
            }
            #endregion
        }
    }
}
