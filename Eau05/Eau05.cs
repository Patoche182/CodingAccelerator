/*     05 - String dans string - 05
 
Créez un programme qui détermine si une chaîne de caractère se trouve dans une autre.
Exemples d’utilisation :
$> python exo.py bonjour jour
true

$> python exo.py bonjour joure
false

$> python exo.py 42
error

Afficher error et quitter le programme en cas de problèmes d’arguments.
 */

class Eau05
{
    static void Main(string[] args)
    {
        Console.WriteLine("==========-==========-==========-==========-==========");
        Console.WriteLine("Epreuve de l'Eau05 !");
        Console.WriteLine("==========-==========-==========-==========-==========");

        if (args.Length < 2)
        {
            Console.WriteLine("Veuillez fournir deux chaînes de caractères en argument : ");
            string input = Console.ReadLine();
            string[] inputArray = input.Split(' ');
            if (inputArray.Length < 2)
            {
                Console.WriteLine("Veuillez fournir deux chaînes de caractères valides.");
                return;
            }
            args = inputArray;
        }

        string chaine1 = args[0];
        string chaine2 = args[1];

        bool trouve = TrouverSousChaine(chaine1, chaine2);
        Console.WriteLine(trouve);
    }

    static bool TrouverSousChaine(string chaine, string sousChaine)
    {
        // Utilisez la méthode Contains pour vérifier si la sous-chaîne est présente dans la chaîne.
        return chaine.Contains(sousChaine);
    }
}