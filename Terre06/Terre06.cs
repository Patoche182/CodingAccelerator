/* 06 - INVERSER UNE CHAINE - 06 

Cr�ez un programme qui affiche l�inverse de la cha�ne de caract�res donn�e en argument.
Exemples d�utilisation :
    $> node exo.js �Hello world!�
    !dlrow olleH
    $> node exo.js �lehciM�
    Michel
Attention : je compte sur vous pour g�rer les potentielles erreurs d�arguments.

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
            // �crire les char un � un dans inverse
            inverse += chaine[i];
        }
        return inverse;
    }
}