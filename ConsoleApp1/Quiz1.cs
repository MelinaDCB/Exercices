using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuizCapitales
{
    internal class Quiz1
    {
        public static void Jouer()
        {
            /*Console.WriteLine("Quelle est la capitale de l'Albanie ?");
            string answer = Console.ReadLine();
            if (answer == "Tirana")
            {
                Console.WriteLine("Bravo !");
            }
            else
            {
                Console.WriteLine("Mauvaise réponse.");
            }

            Console.WriteLine("Quelle est la capitale de l'Allemagne ?");
            string gerCapital = Console.ReadLine();
            if (gerCapital == "Berlin")
            {
                Console.WriteLine("Bravo !");
            }
            else
            {
                Console.WriteLine("Mauvaise réponse.");
            }

            Console.WriteLine("\nQuelle est la capitale de l'Autriche ?");
            string autCapital = Console.ReadLine();
            if (autCapital == "Vienne")
            {
                Console.WriteLine("Bravo !");
            }
            else
            {
                Console.WriteLine("Mauvaise réponse.");
            }*/

            string[] countries = { "Albanie", "Allemagne", "Andorre", "Autriche", "Belgique", "Biélorussie", "Bosnie-Herzégovine", "Bulgarie", "Chypre", "Croatie" };
            string[] capitals = { "Tirana", "Berlin", "Andorre-la-Vieille", "Vienne", "Bruxelles", "Minsk", "Sarajevo", "Sofia", "Nicosie", "Zagreb" };
            int counter = 0;

           for (int i = 0; i < countries.Length; i++)
                // Pour ne poser qu'une question sur 2 il faut simplement modifier le "i++" en "i+=2"
                // Pour inverser l'ordre des questions "for (int i = countries.Length - 1; i <= 0; i--)"
                {
                Console.WriteLine($"Quelle est la capitale de {countries[i]} ?");
                string answer = Console.ReadLine();
                if (answer == capitals[i])
                {
                    Console.WriteLine("Bravo !");
                    counter++;
                }
                else
                {
                    Console.WriteLine($"Mauvaise réponse. La réponse était {capitals[i]}");
                }
            }
            Console.WriteLine($"Votre score final est de {counter}.");

        }
    }
}
