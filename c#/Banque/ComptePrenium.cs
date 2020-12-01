using System;

namespace Banque
{
    class ComptePrenium : Compte
    {
        private double decouverteAutorise { get; set; }

        public ComptePrenium(String nom) : base(nom)
        {

            this.decouverteAutorise = 500;
        }

        public ComptePrenium(String nom, double somme) : base(nom, somme)
        {
            this.decouverteAutorise = 500;

        }

        public override void retrait(double somme)
        {
            if (solde - somme < this.decouverteAutorise * -1)
            {
                throw new DecouvertException();
            }
            solde -= somme;
        }

    }

}