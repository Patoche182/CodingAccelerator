/* 10 - NOMBRE PREMIER - 10

Créez un programme qui affiche si un nombre est premier ou pas.
Exemples d’utilisation :
    $> node exo.js 5
    Oui, 5 est un nombre premier.
    $> node exo.js 6
    Non, 6 n’est pas un nombre premier.

Attention : 0 et 1 ne sont pas des nombres premiers. Gérez les erreurs d’arguments.
 */

class Terre10
{
    static void Main()
    {
        Console.WriteLine("==========-==========-==========-==========-==========");
        Console.WriteLine("Bonjour ! \nBienvenue dans ce programme.");
        Console.WriteLine("Cette console affiche si le nombres donné est en Nombre Premier.");
        Console.WriteLine("==========-==========-==========-==========-==========");

        /* 
            NOMBRE PREMIER
        Nombre naturel qui est supérieur à 1 et qui a exactement deux diviseurs distincts, soit 1 et lui-même.
        Il existe une infinité de nombres premiers.
        Par définition, les nombres 0 et 1 ne sont ni premiers, ni composés.
        Un nombre naturel supérieur à 1 qui n’est pas premier est un nombre composé et vice versa.
        Tout nombre composé peut être exprimé d’une façon unique sous la forme d’un produit de nombres premiers.

            EXEMPLE
        Le nombre 13 est un nombre premier car il n’est divisible que par 1 et 13.
        Voici la liste des 15 nombres premiers inférieurs à  50 : 2, 3, 5, 7, 11, 13, 17, 19, 23, 29, 31, 37, 41, 43, 47.
        Le nombre 15 n’est pas un nombre premier, car il a plus de deux diviseurs : div (15) = {1, 3, 5, 15}.
        Le nombre 9 n’est pas un nombre premier, car il a plus de deux diviseurs : div (9) = {1, 3, 9}. 
         */

        do
        {
            Console.WriteLine("Veuillez entrer un nombre : (ou 'exit' pour quitter).");
            int number = Convert.ToInt32(Console.ReadLine());

            bool isPrime = EstNombrePremier(number);

            if (isPrime)
            {
                Console.WriteLine($"{number} est un nombre premier.");
            }
            else
            {
                Console.WriteLine($"{number} n'est pas un nombre premier.");
            }
            //else
            //{
            //    Console.WriteLine("- /!\\ /!\\ /!\\ /!\\ /!\\ /!\\ /!\\ /!\\ /!\\ /!\\ /!\\ /!\\ /!\\ /!\\ /!\\ -");
            //    Console.WriteLine("- Attention ! Veuillez entrer un nombre ENTIER et POSITIF svp -");
            //    Console.WriteLine("- /!\\ /!\\ /!\\ /!\\ /!\\ /!\\ /!\\ /!\\ /!\\ /!\\ /!\\ /!\\ /!\\ /!\\ /!\\ -");
            //}
            Console.WriteLine("----------=----------=----------=----------=----------");

        } while (true);
    }

    // Méthodes :
    static bool EstNombrePremier(int n)
    {
        // TODO: Implémenter la logique pour déterminer si n est un nombre premier
        // N'oubliez pas de gérer les cas particuliers (0, 1, etc.)
        return false;  // Placeholder, changez cela avec votre propre logique
    }
}

/*
class Program
{
    static void Main()
    {
        Console.WriteLine("Veuillez entrer un nombre entier positif :");
        int number = Convert.ToInt32(Console.ReadLine());

        bool isPrime = EstNombrePremier(number);

        if (isPrime)
        {
            Console.WriteLine($"{number} est un nombre premier.");
        }
        else
        {
            Console.WriteLine($"{number} n'est pas un nombre premier.");
        }
    }

    static bool EstNombrePremier(int n)
    {
        // TODO: Implémenter la logique pour déterminer si n est un nombre premier
        // N'oubliez pas de gérer les cas particuliers (0, 1, etc.)
        return false;  // Placeholder, changez cela avec votre propre logique
    }
}
*/