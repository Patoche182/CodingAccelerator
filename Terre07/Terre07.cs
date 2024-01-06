/* 07 - TAILLE D'UNE CHAINE - 07

Créez un programme qui affiche le nombre de caractères d’une chaîne de caractères passée en argument.
Exemples d’utilisation :
    $> python exo.py “Hello world!”
    12
    $> python exo.py
    erreur.
    $> python exo.py “Bonjour” “Aurevoir”
    erreur.
    $> python exo.py 10
    erreur.

Fonctions interdites: 
-La fonction length
-La fonction size
 */


class Terre07
{
    static void Main()
    {
        string chaine = "Je s'apelle Groot 22 !";
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