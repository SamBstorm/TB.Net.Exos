using System;
using System.Collections.Generic;
using System.Text;

namespace TB.Net.ExoBonus02
{
    public struct Damier
    {
        public ushort Taille;
        public ConsoleColor[] Couleurs;

        public void AfficherDamier()
        {
            Console.ResetColor();
            string message = "  ";
            for (int j = 0; j < Taille; j++)
            {
                for (int i = 0; i < Taille; i++)
                {
                    Console.BackgroundColor = ((i + j) % 2 == 0) ? Couleurs[0] : Couleurs[1];
                    Console.Write(message);
                }
                Console.ResetColor();
                Console.WriteLine();
            }
            Console.ResetColor();
        }

        public override string ToString()
        {
            return $"Damier : de taille {Taille}, et de couleurs {Enum.GetName(typeof(ConsoleColor), Couleurs[0])} & {Enum.GetName(typeof(ConsoleColor), Couleurs[1])} .";
        }
    }
}
