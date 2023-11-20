using System;

namespace Calculatrice
{
    internal class Program
    {
        static int PlusMethodInt(int x, int z)                                                  // méthode pour faire l'addition
        {
            return x + z;
        }

        static int MoinsMethodInt(int x, int z)                                                 // méthode pour faire la soustraction
        {
            return x - z;
        }

        static int FoisMethodInt(int x, int z)                                                  // méthode pour faire la multiplication
        {
            return x * z;
        }

        static double DivisionMethoddouble(double x, double z)                                  // méthode pour faire la division
        {
            return x / z;
        }

        static double PourcentageMethoddouble(double x, double c)                               // méthode pour faire le pourcentage
        {
            return x / c;
        }

        static void Main(string[] args)
        {
            int c = 100;
            string s;                                                                           // dire que s est en string
            bool t = true;                                                                      // dire que t est positif
            Console.WriteLine("Bienvenue dans la meilleure calculatrice");                      // phrase d'introduction
            Console.WriteLine(" + plus | - moins | * fois | / division | % pourcentage  ");

            do
            {
                int x = Convert.ToInt32(Console.ReadLine());                                    // installation des variables
                string y = Console.ReadLine();
                int z = Convert.ToInt32(Console.ReadLine());

                if (y == "%")                                                                   // boucle if pour la méthode pourcentage
                {
                    double myNum = PourcentageMethoddouble(x, c);
                    Console.WriteLine("=");
                    Console.WriteLine(myNum + " %");
                }
                else if (y == "+")                                                              // boucle if pour la méthode addition
                {
                    int myNum = PlusMethodInt(x, z);
                    Console.WriteLine("=");
                    Console.WriteLine(myNum);
                }
                else if (y == "-")                                                              // boucle if pour la méthode soustraction
                {
                    int myNum = MoinsMethodInt(x, z);
                    Console.WriteLine("=");
                    Console.WriteLine(myNum);
                }
                else if (y == "*")                                                              // boucle if pour la méthode multiplication
                {
                    int myNum = FoisMethodInt(x, z);
                    Console.WriteLine("=");
                    Console.WriteLine(myNum);
                }
                else if (y == "/")                                                              // boucle if pour la méthode division
                {
                    double myNum = DivisionMethoddouble(x, z);
                    Console.WriteLine("=");
                    Console.WriteLine(myNum);
                }

                Console.WriteLine("Veux-tu continuer oui/non:");
                s = Console.ReadLine();

                if (s == "non")
                {
                    t = false;
                }

            } while (t);
        }
    }
}