/* 08 - PUISSANCE D'UN NOMBRE - 08

Créez un programme qui affiche le résultat d’une puissance.
L’exposant ne pourra pas être négatif.
Exemples d’utilisation :
    $> node exo.js 2 3
    8
Attention : je compte sur vous pour gérer les potentielles erreurs d’arguments.
Fonctions interdites: 
-La fonction pow
 */

using System;

class Terre08
{
    static void Main()
    {
        Console.WriteLine("==========-==========-==========-==========-==========");
        Console.WriteLine("Bonjour ! \nBienvenue dans ce programme.");
        Console.WriteLine("Cette console affiche le résultat d’une puissance entre deux nombres.");
        Console.WriteLine("==========-==========-==========-==========-==========");

        do
        {
            Console.WriteLine("Veuillez entrer un nombre : (ou 'exit' pour quitter)");
            string baseNumberInput = Console.ReadLine();

            if (baseNumberInput.ToLower() == "exit")
                break;

            if (double.TryParse(baseNumberInput, out double baseNumber))
            {
                Console.WriteLine("Veuillez entrer un exposant : (ou 'exit' pour quitter)");
                string exponentInput = Console.ReadLine();

                if (exponentInput.ToLower() == "exit")
                    break;

                if (int.TryParse(exponentInput, out int exponent))
                {
                    Console.WriteLine("Le résultat du calcul est : " + Puissance(baseNumber, exponent));
                }
                else
                {
                    Console.WriteLine("Attention ! Veuillez entrer un exposant valide svp.");
                }
            }
            else
            {
                Console.WriteLine("Attention ! Veuillez entrer un nombre svp.");
            }

            Console.WriteLine("----------=----------=----------=----------=----------");
        } while (true);
    }

    // Méthodes :
    static double Puissance(double baseNumber, int exponent)
    {
        double result = 1;
        for (int i = 0; i < exponent; i++)
        {
            result *= baseNumber;
        }
        return result;
    }
}



//class Terre08
//{
//    static void Main()
//    {
//        Console.WriteLine("==========-==========-==========-==========-==========");
//        Console.WriteLine("Bonjour ! \nBienvenue dans ce programme.");
//        Console.WriteLine("Cette console affiche le résultat d’une puissance entre deux nombres.");
//        Console.WriteLine("==========-==========-==========-==========-==========");
//        // 2 ^ 3 = 2 * 2 * 2  = 8

//        do
//        {
//            Console.WriteLine("Veuillez entrer un nombre : (ou 'exit' pour quitter)");
//            string baseNumber = Console.ReadLine();
//            int x;
//            if (int.TryParse(baseNumber, out x))
//            {
//                Console.WriteLine("Veuillez entrer un exposant : (ou 'exit' pour quitter)");
//                string exponent = Console.ReadLine();
//                int y;
//                if (int.TryParse(exponent, out y))
//                {
//                    Console.WriteLine("Le résultat du calcul est : " + Puissance(baseNumber, exponent));
//                }
//            }
//            else
//            {
//                Console.WriteLine("Attention ! Veuillez entrer un nombre svp.");
//            }
//            Console.WriteLine("----------=----------=----------=----------=----------");
//        } while (true);
//    }

//    // Méthodes :
//    static double Puissance(double baseNumber, int exponent)
//    {
//        double result = 1;
//        for (int i = 0; i < exponent; i++)
//        {
//            result *= baseNumber;
//        }
//        return result;
//    }
//}