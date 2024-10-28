/*     05 - String dans string - 05
 
Créez un programme qui détermine si une chaîne de caractère se isFound dans une autre.
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
        if (IsValidArguments(arguments))
        {
            foreach (string argument in arguments)
            {
                if (!isValidString(argument))
                {
                    return;
                }
            }
            string mainString = arguments[0];
            string subString = arguments[1];

            bool isFound = ContainSubstring(mainString, subString);
            Console.WriteLine(isFound);
        }
    }

    // GESTION ERREUR
    public static bool IsValidArguments(string[] arguments)
    {
        if (arguments.Length == 2)
        {
            return true;
        }
        else
        {
            Console.WriteLine("Error ! Veuillez fournir 2 arguments :");
            return false;
        }
    }

    public static bool isValidString(string stringValue)
    {
        bool isString = false;

        foreach (char character in stringValue)
        {
            if (!char.IsDigit(character))
            {
                isString = true;
                break;
            }
        }
        if (!isString)
        {
            Console.WriteLine("error");
        }
        return isString;
    }

    // METHODE UTILITAIRE
    static bool ContainSubstring(string chaine, string sousChaine)
    {
        return chaine.Contains(sousChaine); // Ne pas utiliser .Contains() => boucle for ... + Considérer les casse !!!
    }
}