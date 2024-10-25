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


// METHODE RESOLUTION 
// METHODE UTILITAIRE 
// GESTION ERREUR 

class Eau05
{
    // METHODE RESOLUTION
    static void Main(string[] arguments)
    {
        // GESTION ERREUR
        if (arguments.Length != 2)
        {
            Console.WriteLine("Veuillez fournir 2 argument :");
            return;
        }

        foreach (string argument in arguments)
        {
            bool isNumeric = true;

            foreach (char character in argument)
            {
                if (!char.IsDigit(character))
                {
                    isNumeric = false;
                    break;
                }
            }
            if (isNumeric)
            {
                Console.WriteLine("error");
                return;
            }
        }

        string chaine1 = arguments[0];
        string chaine2 = arguments[1];

        bool trouve = TrouverSousChaine(chaine1, chaine2);
        Console.WriteLine(trouve);
    }

    // METHODE UTILITAIRE
    static bool TrouverSousChaine(string chaine, string sousChaine)
    {
        return chaine.Contains(sousChaine); // Ne pas utiliser .Contains() => boucle for ... + Considérer les casse !!!
    }
}