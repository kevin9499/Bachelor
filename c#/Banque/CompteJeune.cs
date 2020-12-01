using System;

namespace Banque
{
    class CompteJeune : Compte
    {
        public CompteJeune(String nom) : base(nom)
        {

        }

        public CompteJeune(String nom, double somme) : base(nom)
        {
            solde = somme;
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

    class DecouvertException : Exception
    {

        public DecouvertException() : base("Decouvert non autorisé")
        {

        }

        public void DisplayError()
        {
            Console.WriteLine(base.Message);
        }
    }
}