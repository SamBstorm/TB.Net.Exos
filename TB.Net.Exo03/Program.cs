using System;

namespace TB.Net.Exo03
{
    class Program
    {
        static void Main(string[] args)
        {
            #region Exo1 - Division
            ////int x = 5, y = 2;

            //Console.WriteLine("Veuillez indiquer un premier nombre :");
            //if (int.TryParse(Console.ReadLine(), out int nb1))
            //{
            //    Console.WriteLine("Veuillez indiquer un second nombre :");
            //    if (int.TryParse(Console.ReadLine(), out int nb2))
            //    {

            //        Console.WriteLine($"La division entière de {nb1} par {nb2} donne {nb1 / nb2}." +
            //            $"\nLa division de {nb1} par {nb2} donne {(double)nb1 / nb2}." +
            //            $"\nLe reste de la division entière de {nb1} par {nb2} donne {nb1 % nb2}.");

            //        /*
            //        int result = nb1 / nb2;
            //        int mod = nb1 % nb2;
            //        double div = (double)nb1 / nb2;
            //        Console.WriteLine($"La division entière de {nb1} par {nb2} donne {result}.");
            //        Console.WriteLine($"La division de {nb1} par {nb2} donne {div}.");
            //        Console.WriteLine($"Le reste de la division entière de {nb1} par {nb2} donne {mod}.");
            //        */
            //    }
            //    else Console.WriteLine("Ceci n'est pas un nombre.");
            //}
            //else Console.WriteLine("Ceci n'est pas un nombre.");
            #endregion

            #region Exo2 - BBAN
            //Récupérer les 2 parties du BBAN sans substring()
            //long l = 123456789012;
            //long tenfirst = l / 100;
            //ushort twolast =(ushort) (l % 100);

            //Console.WriteLine("Veuillez introduire votre BBAN (12 chiffres):");
            //string bban = Console.ReadLine();
            //string bban_ten = bban.Substring(0, 10);
            //bool bban_ten_check = ulong.TryParse(bban_ten, out ulong ten_first);
            //string bban_two = bban.Substring(10);
            //bool bban_two_check = ushort.TryParse(bban_two, out ushort two_last);

            //ushort rest = (ushort)(ten_first % 97);

            //if (rest == two_last && rest != 0) Console.WriteLine("OK");
            //else if (rest == 0 && two_last == 97) Console.WriteLine("OK");
            //else Console.WriteLine("KO");
            #endregion

            #region Exo3 - IBAN

            Console.WriteLine("Veuillez introduire votre BBAN (12 chiffres):");
            string bban = Console.ReadLine();
            string bban_ten = bban.Substring(0, 10);
            bool bban_ten_check = ulong.TryParse(bban_ten, out ulong ten_first);
            string bban_two = bban.Substring(10);
            bool bban_two_check = ushort.TryParse(bban_two, out ushort two_last);

            ushort rest = (ushort)(ten_first % 97);

            if ((rest == two_last && rest != 0) || (rest == 0 && two_last == 97)) {
                //char[] chars = ['0', '1', '2', '3', '4', '5', '6', '7', '8', '9', 'A', 'B', 'C', 'D', 'E', 'Z'];
                ulong Be0 = ulong.Parse($"{two_last}{two_last}111400");
                ushort two_missing = (ushort)(98 - (Be0 % 97));
                Console.WriteLine($"L'IBAN de votre compte {bban} correspond à BE{two_missing} {bban}");
            }
            else Console.WriteLine("KO");

            #endregion
        }
    }
}
