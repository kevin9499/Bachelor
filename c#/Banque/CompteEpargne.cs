using System;

namespace Banque
{
    class CompteEpargne : Compte
    {
        private double tauxInteret { get; set; }
        public CompteEpargne(String nom) : base(nom)
        {
            this.tauxInteret = 10;
        }

        public CompteEpargne(String nom, double somme) : base(nom, somme)
        {
            this.tauxInteret = 10;
        }

        public override void depot(double somme)
        {
            double interet = somme * this.tauxInteret / 100;
            solde = somme + interet;
        }
        public override void retrait(double somme)
        {
            if (solde - somme < 0)
            {
                throw new DecouvertException();
            }
            solde -= somme;
        }

    }
}