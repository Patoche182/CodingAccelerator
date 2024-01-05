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
        string chaine = "Je s'apelle Groot !";
        Console.WriteLine(Reverse(chaine));
    }
    static string Reverse(string chaine)
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