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

        /* NOMBRE PREMIER
           Nombre naturel qui est supérieur à 1 et qui a exactement deux diviseurs distincts, soit 1 et lui-même.
           Il existe une infinité de nombres premiers.

           EXEMPLE
           Le nombre 13 est un nombre premier car il n’est divisible que par 1 et 13.
           Voici la liste des 15 nombres premiers inférieurs à  50 : 2, 3, 5, 7, 11, 13, 17, 19, 23, 29, 31, 37, 41, 43, 47.
           Le nombre 15 n’est pas un nombre premier, car il a plus de deux diviseurs : div (15) = {1, 3, 5, 15}.
           Le nombre 9 n’est pas un nombre premier, car il a plus de deux diviseurs : div (9) = {1, 3, 9}.    */

        do
        {
            Console.WriteLine("Veuillez entrer un nombre entier positif (ou 'exit' pour quitter) :");
            string input = Console.ReadLine();

            if (input.ToLower() == "exit")
                break;

            if (int.TryParse(input, out int number) && number > 0)
            {
                bool isPrime = EstNombrePremier(number);

                if (isPrime)
                {
                    Console.WriteLine($"Oui, {number} est un nombre premier.");
                }
                else
                {
                    Console.WriteLine($"Non, {number} n'est pas un nombre premier.");
                }
            }
            else
            {
                Console.WriteLine("Veuillez entrer un nombre entier positif.");
            }
            Console.WriteLine("----------=----------=----------=----------=----------");
        } while (true);
    }

    static bool EstNombrePremier(int n)
    {
        if (n <= 1)
        {
            // 0 et 1 ne sont pas des nombres premiers
            return false;
        }
        // Vérifier si n est divisible par un nombre de 2 à la racine carrée de n
        for (int i = 2; i <= Math.Sqrt(n); i++)
        {
            if (n % i == 0)
            {
                // n est divisible par i, donc ce n'est pas un nombre premier
                return false;
            }
        }
        // Si aucun diviseur n'est trouvé, n est un nombre premier
        return true;
    }
}