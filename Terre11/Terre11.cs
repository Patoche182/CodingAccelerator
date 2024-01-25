/* 11 - 24 to 12 - 11

Créez un programme qui transforme une heure affichée en format 24h en une heure affichée en format 12h.

Exemples d’utilisation :
    $> ruby exo.rb 23:40
    11:40PM

Attention : midi et minuit.
*/


class Terre11
{
    static void Main()
    {
        Console.WriteLine("==========-==========-==========-==========-==========");
        Console.WriteLine("Bonjour ! \nBienvenue dans ce programme.");
        Console.WriteLine("Cette console transforme une heure affichée en format 24h en une heure affichée en format 12h.");
        Console.WriteLine("==========-==========-==========-==========-==========");

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