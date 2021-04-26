using System;

namespace TB.Net.ExoBonus04
{
    class Program
    {
        static void Main(string[] args)
        {
            MenuOptions mo;
            mo.Titre = "Début de l'aventure, quel est votre classe?";
            mo.Options = new System.Collections.Generic.List<string>() { "Développeur", "Designer", "Chef de projet", "Technicien réseau" };

            MenuConsole mc;
            switch (mc.AfficherMenu(mo))
            {
                case 0:
                case 1:
                case 2:
                    mo.Titre = "Ok, vous êtes donc familer avec le code, choisissez votre langage :";
                    mo.Options = new System.Collections.Generic.List<string>() { "C#", "HTML"};
                    break;
                case 3:
                    mo.Titre = "Ok, votre truc c'est les mains dans les cables, du coups votre arme sera :";
                    mo.Options = new System.Collections.Generic.List<string>() { "un cable RJ45" };
                    break;
            }
            switch (mc.AfficherMenu(mo))
            {
                case 0:
                case 1:
                case 2:
                    mo.Titre = "Ok, vous êtes donc familer avec le code, choisissez votre langage :";
                    mo.Options = new System.Collections.Generic.List<string>() { "C#", "HTML" };
                    break;
                case 3:
                    mo.Titre = "Ok, votre truc c'est les mains dans les cables, du coups votre arme sera :";
                    mo.Options = new System.Collections.Generic.List<string>() { "un cable RJ45" };
                    break;
                default:
                    Console.WriteLine("Fin du jeu");
                    break;
            }
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
