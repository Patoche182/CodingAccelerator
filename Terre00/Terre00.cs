/* 00 - L’ALPHABET - 00

Créez un programme qui affiche l’alphabet en lettres minuscules suivi d’un retour à la ligne.
Exemples d’utilisation :
    $> python exo.py
    abcdefghijklmnopqrstuvwxyz
    $>
Attention : votre programme devra utiliser une boucle. 

|||||||||||||||||||||||| Objectif : apprendre qu'on peut récupérer simplement chaque caractère a l'aide d'un code ASCII ||||||||||||||||||||||||
*/

// Méthode 0 (Ascii) :

class Terre00
{
    static void Main()
    {
        string alphabet = ""; // Création d'une chaîne pour stocker l'alphabet

        for (int i = 97; i <= 122; i++) // Utilisation d'une boucle pour concaténer les lettres à la chaîne alphabet
        {
            alphabet += (char)i; // Incrémentation de la variable alphabet
        }
        Console.WriteLine(alphabet); // Affichage de l'alphabet sur une seule ligne
    }
}

// Méthode 1 :
//class Terre00
//{
//    static void Main()
//    {
//        string lettreAlphabet = "ABCDEFGHIJKLMNOPQRSTUVWXYZ";
//        foreach (char lettre in lettreAlphabet)
//        {
//            Console.Write(lettre.ToString().ToLower());
//        }
//        Console.WriteLine();
//        Console.ReadLine();
//    }
//}


// Méthode 2 :
//class Terre00
//{
//    static void Main()
//    {
//        for (char lettre = 'A'; lettre <= 'Z'; lettre++)
//        {
//            Console.Write(lettre.ToString().ToLower());
//        }
//        Console.WriteLine();
//    }
//}