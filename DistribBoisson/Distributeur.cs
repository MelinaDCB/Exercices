using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DistribBoisson
{
    public class Distributeur
    {
        private double _solde;

        public double Solde
        {
            get { return _solde; }
            set { _solde = value; }
        }
        public Distributeur(double solde)
        {
            Solde = solde;
        }

        public string ServirBoisson(int customerChoice, int Sucre)
        {
            if (Sucre > 10)
                Sucre = 10;
                if (Solde >= 0.80 && customerChoice == 1)
                {
                    Solde -= 0.80;
                    return $"Café avec {Sucre}g de sucre.";
                }
                else if (Solde >= 0.75 && customerChoice == 2)
                {
                    Solde -= 0.75;
                    return $"Chocolat avec {Sucre}g de sucre.";
                }
                else if (Solde >= 1.00 && customerChoice == 3)
                {
                    Sucre = 0;
                    Solde -= 1.00;
                    return $"Soupe avec {Sucre}g de sucre.";
                }
                else
                {
                    return "Choix et/ou solde insuffisant.";
                }
        }
    }

}
