using System;

namespace TB.Net.Exo06
{
    class Program
    {
        static void Main(string[] args)
        {
            int taille = 5;
            Point?[,] tabs = new Point?[taille, taille];

            Point p;
            for (int i = 0; i < taille; i++)
            {
                p.X = p.Y = i + 1;
                tabs[i, i] = p;
            }

            //for (int i = 0; i < taille; i++)
            //{
            //    tabs[i, i] = new Point() { X = i+1, Y = i+1 };
            //}

            for (int i = 0; i < taille; i++)
            {
                for (int j = 0; j < taille; j++)
                {
                    if (tabs[i, j] is null) Console.Write("\t\t");
                    else Console.Write($"X: {((Point)tabs[i,j]).X}- Y: {((Point)tabs[i, j]).Y}");
                }
                Console.WriteLine();
            }
        }
    }
}
