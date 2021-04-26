using System;
using System.Collections.Generic;

namespace TB.Net.ExoBonus04
{
    public struct KeyMapping
    {
        public Dictionary<ConsoleKey, Action> GetKeys()
        {
            Dictionary<ConsoleKey, Action> keys = new Dictionary<ConsoleKey, Action>();
            keys.Add(ConsoleKey.UpArrow, Action.Haut);
            keys.Add(ConsoleKey.Z, Action.Haut);
            keys.Add(ConsoleKey.NumPad8, Action.Haut);
            keys.Add(ConsoleKey.DownArrow, Action.Bas);
            keys.Add(ConsoleKey.S, Action.Bas);
            keys.Add(ConsoleKey.NumPad2, Action.Bas);
            keys.Add(ConsoleKey.RightArrow, Action.Droite);
            keys.Add(ConsoleKey.NumPad6, Action.Droite);
            keys.Add(ConsoleKey.D, Action.Droite);
            keys.Add(ConsoleKey.LeftArrow, Action.Gauche);
            keys.Add(ConsoleKey.NumPad4, Action.Gauche);
            keys.Add(ConsoleKey.Q, Action.Gauche);
            keys.Add(ConsoleKey.Enter, Action.Valider);
            keys.Add(ConsoleKey.Escape, Action.Quitter);

            return keys;
        }

        public Action GetAction(ConsoleKey userKey)
        {
            if (GetKeys().ContainsKey(userKey)) return GetKeys()[userKey];
            return Action.NotAssigned;
        }
    }

    public struct MenuOptions
    {
        public string Titre;
        public List<string> Options;
    }

    public struct MenuConsole
    {
        public ushort AfficherMenu(MenuOptions param)
        {
            KeyMapping km;
            ushort curseur = 0;
            Action choice;
            do
            {
                Console.Clear();
                Console.WriteLine(param.Titre);
                for (ushort i = 0; i < param.Options.Count; i++)
                {
                    if (i == curseur) Console.WriteLine($">{param.Options[i]}<");
                    else Console.WriteLine($" {param.Options[i]} ");
                }
                do choice = km.GetAction(Console.ReadKey(true).Key);
                while (choice != Action.Valider && choice != Action.Haut && choice != Action.Bas);
                if (choice == Action.Haut && curseur > 0) curseur--;
                if (choice == Action.Bas && curseur < (param.Options.Count-1)) curseur++;
            } while (Action.Valider != choice);
            return curseur;
        }
    }
}
