/* 09 - RACINE CARRE D'UN NOMBRE - 09

Créez un programme qui affiche la racine carrée d’un entier positif.
Exemples d’utilisation :
    $> node exo.js 9
    3
Attention : je compte sur vous pour gérer les potentielles erreurs d’arguments.
Fonctions interdites: 
-La fonction sqrt
 */

class Terre09
{
    static void Main()
    {
        Console.WriteLine("==========-==========-==========-==========-==========");
        Console.WriteLine("Bonjour ! \nBienvenue dans ce programme.");
        Console.WriteLine("Cette console affiche la Racine Carré d'un nombre, entier et positif :");
        Console.WriteLine("==========-==========-==========-==========-==========");

        // Qu'est ce qu'une racine carré mathématiquement parlant : 
        // Décomposer les étapes : 
        // Par exemple : Racine de 4 est 2. Car 2 au carré = 4
        // Autre exemple : Racine de 16 = 4. Car 4 x 4 = 16
        // Autre exemple : Racine de 100 = 10. Car 10 x 10 = 100
        // 
        // Déjà il faut vérifier que le nombre donné est un entier positif.

        do
        {
            Console.WriteLine("Veuillez entrer un nombre : (ou 'exit' pour quitter)");
            string baseNumberInput = Console.ReadLine();

            if (baseNumberInput.ToLower() == "exit")
                break;

            if (double.TryParse(baseNumberInput, out double baseNumber) && baseNumber > 0)
            {
                RacineCarre((int)baseNumber);
                // Console.WriteLine(RacineCarre(Convert.ToInt32(baseNumber)).ToString("F2"));
                // Console.WriteLine("Le résultat du calcul de la Racine Carré est : " + RacineCarre((int)baseNumber));
                // Console.WriteLine("Le résultat du calcul de la Racine Carré est : " + RacineCarre(baseNumber).ToString("F2"));
            }
            else
            {
                Console.WriteLine("- /!\\ /!\\ /!\\ /!\\ /!\\ /!\\ /!\\ /!\\ /!\\ /!\\ /!\\ /!\\ /!\\ /!\\ /!\\ -");
                Console.WriteLine("- Attention ! Veuillez entrer un nombre ENTIER et POSITIF svp -");
                Console.WriteLine("- /!\\ /!\\ /!\\ /!\\ /!\\ /!\\ /!\\ /!\\ /!\\ /!\\ /!\\ /!\\ /!\\ /!\\ /!\\ -");
            }
            Console.WriteLine("----------=----------=----------=----------=----------");

        } while (true);
    }

    // Méthodes :
    static double RacineCarre(int baseNumber)
    {
        double result = Math.Pow(baseNumber, 0.5); // 0.5 et non pas 0,5 !

        if (result % 1 == 0)
        {
            Console.WriteLine("Le résultat du calcul de la Racine Carré est : " + result.ToString("F0")); // pour afficher le résultat sans décimal
        }
        else
        {
            Console.WriteLine("Le résultat du calcul de la Racine Carré est : " + result.ToString("F2")); // pour afficher le résultat avec 2 décimals
        }
        return result;
        // return (int)result;
    }
}


//class Program
//{
//    static void Main()
//    {
//        // Exemple d'utilisation de la méthode
//        double resultat = CalculerPuissance(3, 3);
//        Console.WriteLine(resultat);  // Cela affichera 27 car 3^3 = 27

//        double resultatDecimal = CalculerPuissance(4, 0.5);
//        Console.WriteLine(resultatDecimal);  // Cela affichera 2 car 4^0.5 = 2
//    }

//    // Méthode pour calculer la puissance d'un nombre
//    static double CalculerPuissance(double baseNombre, double exposant)
//    {
//        return Math.Pow(baseNombre, exposant);
//    }
//}