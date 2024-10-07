/*     02 - Paramètres à l’envers - 02

Créez un programme qui affiche ses arguments reçus à l’envers.

Exemples d’utilisation :
$> python exo.py “Suis” “Je” “Drôle”
Drôle
Je
Suis
$> python exo.py ha ho
ho
ha
$> python exo.py “Bonjour 36”
Bonjour 36

Afficher error et quitter le programme en cas de problèmes d’arguments.
*/

class Eau02
{
    // METHODE RESOLUTION
    static void Main(string[] arguments)
    {
        if (Eau02.IsValidArguments(arguments))
        {
            Eau02.ReverseArguments(arguments);
        }
    }

    // METHODE UTILITAIRE
    public static void ReverseArguments(string[] arguments)
    {
        for (int i = arguments.Length - 1; i >= 0; i--)
        {
            Console.WriteLine(arguments[i]);
        }
    }

    // GESTION ERREUR
    public static bool IsValidArguments(string[] arguments)
    {
        if (arguments.Length > 1)
        {
            return true;
        }
        else
        {
            Console.WriteLine("error");
            return false;
        }
    }
}



/*
class Eau02
{
    static void Main(string[] args)
    {
        Console.WriteLine("==========-==========-==========-==========-==========");
        Console.WriteLine("Epreuve de l'Eau02 !");
        Console.WriteLine("==========-==========-==========-==========-==========");

        if (args.Length <= 0) // (args.Length < 2) 
        {
            Console.WriteLine("error");
        }
        else
        {
            for (int i = args.Length - 1; i >= 0; i--)
            {
                Console.WriteLine(args[i]);
            }
        }
    }
}
 */