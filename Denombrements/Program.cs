using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Denombrements
{
    /// <summary>
    /// Interface de calculs de dénombrements 
    /// Permutations, arrangements et combinaisons
    /// </summary>
    class Program
    {
        /// <summary>
        /// Calcul du produit de tous les entiers compris entre valeurDepart et valeurArrivee
        /// </summary>
        /// <param name="valeurDepart"></param>
        /// <param name="valeurArrivee"></param>
        /// <returns>résultat ou 0 si impossible</returns>
        static long Calcul(int valeurDepart, int valeurArrivee)
        {
            long produit = 1;
            for (int k = valeurDepart; k <= valeurArrivee; k++)
            {
                produit *= k;
            }
            return produit;
        }



        /// <summary>
        /// Menu pour faire plusieurs fois des calculs de permutations, arrangements et combinaisons
        /// </summary>
        /// <param name="args"></param>
        static void Main(string[] args)
        {
            string choix = "1";
            while (choix != "0")
            {
                Console.WriteLine("Permutation ...................... 1");
                Console.WriteLine("Arrangement ...................... 2");
                Console.WriteLine("Combinaison ...................... 3");
                Console.WriteLine("Quitter .......................... 0");
                Console.Write("Choix :                            ");
                choix = Console.ReadLine();
                // Choix sans quitter
                if (choix == "1" || choix == "2" || choix == "3")
                {
                    try
                    {
                        Console.Write("Nombre total d'éléments à gérer = ");
                        int nbTotal = int.Parse(Console.ReadLine());
                        // Permutation
                        if (choix == "1")
                        {
                            long permutation = Calcul(1, nbTotal);
                            Console.WriteLine(nbTotal + "! = " + permutation);
                        }
                        else
                        {
                            Console.Write("Nombre d'éléments dans le sous ensemble = ");
                            int nbSousEnsemble = int.Parse(Console.ReadLine());
                            //Calcul de l'arrangement qui sert aussi de combinaison
                            long arrangement = Calcul(nbTotal - nbSousEnsemble + 1, nbTotal);
                            //Arrangement
                            if (choix == "2")
                            {
                                Console.WriteLine("A(" + nbTotal + "/" + nbSousEnsemble + ") = " + arrangement);
                            }
                            //Combinaison
                            else
                            {
                                long combinaison = arrangement / Calcul(1, nbSousEnsemble);
                                Console.WriteLine("C(" + nbTotal + "/" + nbSousEnsemble + ") = " + combinaison);
                            }
                        }
                    }
                    catch
                    {
                        Console.WriteLine("Calcul impossible : valeur(s) incorrectes ou trop grand(e)s.");
                    }
                }
            }
        }
    }
}