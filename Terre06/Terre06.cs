/* 06 - INVERSER UNE CHAINE - 06 

Créez un programme qui affiche l’inverse de la chaîne de caractères donnée en argument.
Exemples d’utilisation :
    $> node exo.js “Hello world!”
    !dlrow olleH
    $> node exo.js “lehciM”
    Michel
Attention : je compte sur vous pour gérer les potentielles erreurs d’arguments.

Fonctions interdites: 
-La fonction reverse
*/


class Terre06
{
    static void Main()
    {
        Console.WriteLine("==========-==========-==========-==========-==========");
        Console.WriteLine("Bonjour ! \nBienvenue dans ce programme.");
        Console.WriteLine("Cette console inverse une chaîne de caractère. \nAutrement dit, le mot ou la phrase est à l'envers.");
        Console.WriteLine("==========-==========-==========-==========-==========");

        do
        {
            Console.WriteLine("Ecris un mot ou une phrase (ou 'exit' pour quitter) :");
            string userInput = Console.ReadLine();
            string chaine = userInput;

            if (chaine == "exit")
                break;

            if (chaine != "")
            {
                Console.WriteLine(Inverser(chaine));
            }
            else
            {
                Console.WriteLine("Attention, ce n'est pas valide. Pour fermer ce programme écris : exit");
            }
            Console.WriteLine("----------=----------=----------=----------=----------");
            Console.WriteLine("----------=----------=----------=----------=----------");
        } while (true);
    }

    // Méthodes :
    static string Inverser(string chaine)
    {
        string inverse = "";
        for (int i = chaine.Length - 1; i >= 0; i--)
        {
            // écrire les char un à un dans inverse
            inverse += chaine[i];
        }
        return inverse;
    }
}