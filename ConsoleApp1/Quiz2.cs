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

        public static void Jouer()
        {
            PoserQuestion();
        }

        public static bool PoserQuestion()
        {
            bool isAnswerCorrect = false;
            for (int i = 0; i < countries.Length; i++)
            {
                Console.WriteLine($"Quelle est la capitale de {countries[i]} ?");
                string userAnswer = Console.ReadLine();
                if (userAnswer == capitals[i])
                {
                    Console.WriteLine("Bravo !");
                    isAnswerCorrect = true;
                }
                else
                {
                    Console.WriteLine($"Mauvaise réponse. Celle ci était {capitals[i]}");
                    isAnswerCorrect = false;
                }
            
            }
            return true;
        }

        public static DemanderSiRejouer()
        {
            Console.WriteLine("Voulez vous rejouer ?");
            

        }
    }
}
