using System;
using System.Collections.Generic;

namespace Banque
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Compte> comptes = new List<Compte>();
            try
            {
                ComptePrenium c1 = new ComptePrenium("joe");
                comptes.Add(c1);
                c1.depot(20);
                c1.retrait(10);
                CompteJeune c2 = new CompteJeune("ali", 200);
                comptes.Add(c2);
                c2.retrait(200);
                CompteEpargne c3 = new CompteEpargne("bathazar");
                comptes.Add(c3);
                c3.depot(300);

            }
            catch (DecouvertException de)
            {
                de.DisplayError();
            }
            finally
            {
                foreach (Compte c in comptes)
                {
                    Console.WriteLine($"{c.Titulaire} -> solde : { c.Solde}");
                }
            }
            Console.ReadKey(true);
        }
    }
}
