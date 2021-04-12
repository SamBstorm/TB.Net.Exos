using System;

namespace TB.Net.Exo02
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Clear();
            Console.WriteLine("Veuillez indiquez un nombre :");
            bool est_un_nombre = int.TryParse(Console.ReadLine(), out int nb);
            //if (est_un_nombre)
            //{
            //    int moitier = nb / 2;
            //    if (moitier * 2 == nb)
            //    {
            //        Console.WriteLine("Ce nombre est pair.");
            //    }
            //    else Console.WriteLine("Ce nombre est impair.");
            //}
            //else Console.WriteLine("Ceci n'est pas un nombre."); //Ceci n'est pas non-plus une pipe.

            //OU BIEN

            //if (est_un_nombre && (nb/2)*2 == nb)
            //{
            //    Console.WriteLine("Ce nombre est pair.");
            //}
            //else if (est_un_nombre && (nb/2)*2 != nb)
            //{
            //    Console.WriteLine("Ce nombre est impair.");
            //}
            //else
            //{
            //    Console.WriteLine("Ceci n'est pas un nombre."); //Ceci n'est pas non-plus une pipe.
            //}

            //OU BIEN

            if (!est_un_nombre) Console.WriteLine("Ceci n'est pas un nombre.");
            else if ((nb / 2) * 2 == nb) Console.WriteLine("Ce nombre est pair.");
            else Console.WriteLine("Ce nombre est impair.");
        }
    }
}
