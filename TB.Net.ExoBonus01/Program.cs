/*
1. Connaitre le text à ecrire
2. Subdiviser le text en caractères
3. Pour chaque caractère:
     a. change de couleur
     b. j'écris le caractère avec la couleur*/

using System;

namespace TB.Net.ExoBonus01
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");

            AdvanceConsole ac;
            ac.WriteLine("Salut les dev.net, nous nous éclatons tout en couleur!");
            //ac.WriteLineSam("Salut les dev.net, nous nous éclatons tout en couleur!");
        }
    }

    public struct AdvanceConsole
    {
        public void WriteLine(string message)
        {
            int i = 1;
            foreach (char c in message)
            {
                Console.ForegroundColor = (ConsoleColor)i;
                Console.Write(c);
                i++;
                if (i == 15)
                {
                    i = 1;
                }
            }
            Console.ResetColor();
            Console.WriteLine();
        }

        public void WriteLineSam(string message)
        {
            for (int i = 0; i < message.Length; i++)
            {
                Console.ForegroundColor = (ConsoleColor)((i%6)+1);
                Console.Write(message[i]);
            }
            Console.ResetColor();
            Console.WriteLine();
        }
    }
}
