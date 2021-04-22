using System;

namespace TB.Net.Exo08
{
    public enum Couleurs
    { 
        Coeur,
        Trefle,
        Pique,
        Carreau
    }
    public enum Valeurs
    {
        @as = 14,
        deux = 2,
        trois = 3,
        quatre = 4,
        cinq = 5,
        six = 6,
        sept = 7,
        huit = 8,
        neuf = 9,
        dix = 10,
        valet = 11,
        reine = 12,
        roi = 13
    }

    class Program
    {
        static void Main(string[] args)
        {
            Carte[] tableau = new Carte[52];

            int i = 0;

            foreach (string col in Enum.GetNames(typeof(Couleurs)))
            {
                foreach (string val in Enum.GetNames(typeof(Valeurs)))
                {
                    //tableau[i].Couleur = (Couleurs)Enum.Parse(typeof(Couleurs),col);
                    tableau[i].Couleur = Enum.Parse<Couleurs>(col);
                    tableau[i].Valeur = (Valeurs)Enum.Parse(typeof(Valeurs), val);
                    i++;
                }
            }

            
            foreach (Carte carte in tableau)
            {
                Console.WriteLine($"{carte.Couleur}|{carte.Valeur}");
            }
        }
    }

    public struct Carte
    {
        public Couleurs Couleur;
        public Valeurs Valeur;
    }
}
