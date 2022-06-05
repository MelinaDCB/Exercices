using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AnalyseMots
{
    internal class Analyseur
    {
        public static void CompterLettres(ref string chosenWord, out int nombreVoyelle, out int nombreConsonne)
        {
            nombreConsonne = 0;
            nombreVoyelle = 0;
            for (int index = 0; index < chosenWord.Length ; index++)
            {
                if (chosenWord[index] == 'a' || chosenWord[index] == 'e' || chosenWord[index] == 'i' || chosenWord[index] == 'o' || chosenWord[index] == 'u' || chosenWord[index] == 'y')
                {
                    nombreVoyelle++;
                }
                else
                {
                    nombreConsonne++;
                }
            }

        }
    }
}
