using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuizCapitales
{
    internal class Quiz2
    {
        static string[] countries = { "Albanie", "Allemagne", "Andorre", "Autriche", "Belgique", "Biélorussie", "Bosnie-Herzégovine", "Bulgarie", "Chypre", "Croatie" };
        static string[] capitals = { "Tirana", "Berlin", "Andorre-la-Vieille", "Vienne", "Bruxelles", "Minsk", "Sarajevo", "Sofia", "Nicosie", "Zagreb" };
        static int counter = 0;
        public static void Jouer()
        {
            for (int index = 0; index < countries.Length; index++)
            {
                PoserQuestion(index);
            }
            Console.WriteLine($"Votre score final est de {counter} bonnes réponses");
           if (DemanderSiRejouer())
            {
                Jouer();
            }
        }

        public static bool PoserQuestion(int index)
        {
            Console.WriteLine($"Quelle est la capitale de {countries[index]} ?");
            string userAnswer = Console.ReadLine();
            if (userAnswer == capitals[index])
            {
                Console.WriteLine("Bravo !");
                counter++;
                return true;
            }
            else
            {
                Console.WriteLine($"Mauvaise réponse. Celle ci était {capitals[index]}");
                return false;
            }
        }

        public static bool DemanderSiRejouer()
        {
            Console.WriteLine("Voulez vous rejouer ?");
            string isReplay = Console.ReadLine();
            if (isReplay == "o" || isReplay == "O")
            {
                Console.Clear();
                counter = 0;
                return true; 
            }
            else
            {
                Console.WriteLine("Merci d'avoir joué !");
                return false;
            }
        }
    }
}
