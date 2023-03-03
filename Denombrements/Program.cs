using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Denombrements
{
    class Program
    {
        static void Main(string[] args)
        {
            string choix;
            int nbreAGerer, nbreSousEnsemble;
            bool correct;

            choix = "1";
            while (choix != "0")
            {
                Console.WriteLine("Permutation ...................... 1");
                Console.WriteLine("Arrangement ...................... 2");
                Console.WriteLine("Combinaison ...................... 3");
                Console.WriteLine("Quitter .......................... 0");
                Console.Write("Choix :                            ");
                choix = Console.ReadLine();

                switch(choix)
                {
                    case "1": // permutation
                        correct = false;
                        while (!correct)
                        {
                            try
                            {
                                Console.Write("nombre total d'éléments à gérer = "); // le nombre d'éléments à gérer
                                nbreAGerer = int.Parse(Console.ReadLine()); // saisir le nombre
                                correct = true;
                            }

                            catch
                            {
                                Console.WriteLine("Saisissez un entier");
                            }
                        }
                        long r = 1;
                        for (int k = 1; k <= nbreAGerer; k++)
                            r *= k;
                        Console.WriteLine(nbreAGerer + "! = " + r);
                        break;
                    case "2": //Arrangement
                        correct = false;
                        while (!correct)
                        {
                            try
                            {
                                Console.Write("nombre total d'éléments à gérer = "); // le nombre d'éléments à gérer
                                nbreAGerer = int.Parse(Console.ReadLine()); // saisir le nombre
                                Console.Write("nombre d'éléments dans le sous ensemble = "); // le sous ensemble
                                nbreSousEnsemble = int.Parse(Console.ReadLine()); // saisir le nombre
                                correct = true;
                            }

                            catch
                            {
                                Console.WriteLine("Saisissez un entier");
                            }
                        }
                        long a = 1;
                        for (int k = nbreAGerer - nbreSousEnsemble + 1; k <= nbreAGerer; k++)
                            a *= k;
                        //Console.WriteLine("résultat = " + (r1 / r2));
                        Console.WriteLine("A(" + nbreAGerer + "/" + nbreSousEnsemble + ") = " + a);
                        break;
                    case "3": // Combinaison
                        correct = false;
                        while (!correct)
                        {
                            try
                            {
                                Console.Write("nombre total d'éléments à gérer = "); // le nombre d'éléments à gérer
                                nbreAGerer = int.Parse(Console.ReadLine()); // saisir le nombre
                                Console.Write("nombre d'éléments dans le sous ensemble = "); // le sous ensemble
                                nbreSousEnsemble = int.Parse(Console.ReadLine()); // saisir le nombre
                                correct = true;
                            }

                            catch
                            {
                                Console.WriteLine("Saisissez un entier");
                            }
                        }
                        // calcul de r1
                        int r1 = 1;
                        for (int k = nbreAGerer - nbreSousEnsemble + 1; k <= nbreAGerer; k++)
                        {
                            r1 *= k;
                        }
                        // calcul de r2
                        int r2 = 1;
                        for (int k = 1; k <= nbreSousEnsemble; k++)
                        {
                            r2 *= k;
                        }
                        // calcul de r3
                        //Console.WriteLine("résultat = " + (r1 / r2));
                        Console.WriteLine("C(" + nbreAGerer + "/" + nbreSousEnsemble + ") = " + (r1 / r2));
                        break;
                    case "0": // quitter l'application
                        Environment.Exit(0);
                        break;
                    default: // autre valeur donc erreur de saisie
                        Console.WriteLine("Erreur de saisie");
                        break;
                }
            }
            Console.ReadLine();
        }
    }
}
