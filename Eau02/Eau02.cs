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
    static void Main(string[] args)
    {
        Console.WriteLine("==========-==========-==========-==========-==========");
        Console.WriteLine("Epreuve de l'Eau02 !");
        Console.WriteLine("==========-==========-==========-==========-==========");

        if (args.Length <= 0)
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