using System;
using System.Collections.Generic;

namespace TB.Net.ExoBonus03
{
    public enum Action { 
        NotAssigned,
        Haut,
        Bas,
        Gauche,
        Droite,
        Valider,
        Annuler,
        Inventaire,
        Quitter,
        Frapper,
        Sauter
    }
    class Program
    {
        static void Main(string[] args)
        {
            KeyMapping km;
            ConsoleKey key;
            Action action;
            do
            {
                key = Console.ReadKey(true).Key;
                action = km.GetAction(key);
                string message = "";
                switch (action)
                {
                    case Action.NotAssigned:
                        message = "Touche non-attribuée...";
                        break;
                    case Action.Haut:
                    case Action.Bas:
                        message = $"Je vais en {action}";
                        break;
                    case Action.Gauche:
                    case Action.Droite:
                        message = $"Je vais à {action}";
                        break;
                    case Action.Valider:
                        message = $"Je valide.";
                        break;
                    case Action.Annuler:
                        message = $"J'annule.";
                        break;
                    case Action.Inventaire:
                        message = $"J'ouvre l'inventaire.";
                        break;
                    case Action.Quitter:
                        message = $"Je quitte.";
                        break;
                    case Action.Frapper:
                        message = $"Je frappe.";
                        break;
                    case Action.Sauter:
                        message = $"Je saute.";
                        break;
                }
                Console.WriteLine(message);
            }
            while (action != Action.Quitter);
        }
    }

    public struct KeyMapping
    {
        public Dictionary<ConsoleKey, Action> GetKeys() {
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
            if(GetKeys().ContainsKey(userKey)) return GetKeys()[userKey];
            return Action.NotAssigned;
        }
    }
}

/*
 Créer une structure MenuOptions ayant 2 variables :
        -Titre
        -Options

Créer une seconde structure MenuConsole ayant pour méthode:
        AfficherMenu
        avec pour paramètre la structure MenuOptions
        Elle devra afficher les options du menu, et doit permettre de connaitre la sélection d'une des options
        
        Utilisation du KeyMapping fait ensemble


Dans le Main utiliser les menus pour choisir le genre
Ensuite choisir la couleur de peau
Enfin la coupe de cheveux

une fois les chois fait, une phrase s'affiche avec les information données
 */

/*
 MenuOptions
Le titre est une seule information et de type texte : string
Les options sont nombreuse et de type texte : string[] ou List<string>
 */

/*
 MenuConsole doit être un mélange de 2 comportements :
Rappellez-vous les distributeurs de boisson, pour effectuer un choix, on entre un numéro, faites-en de même, sorté le numéro de votre option sélectionnée.
Autre similitude avec l'exercice du pion P dans un tableau de 10 cases que l'on déplace, ce déplacement ici correspond au comportement du curseur de votre menu.
 */