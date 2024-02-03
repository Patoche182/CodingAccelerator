/* 00 - L’ALPHABET - 00

Créez un programme qui affiche l’alphabet en lettres minuscules suivi d’un retour à la ligne.
Exemples d’utilisation :
    $> python exo.py
    abcdefghijklmnopqrstuvwxyz
    $>
Attention : votre programme devra utiliser une boucle. 

||||||||||||||||||| Correction : AsCii |||||||||||||||||||
*/






// Méthode 1 :

class Terre00
{
    static void Main()
    {
        string lettreAlphabet = "ABCDEFGHIJKLMNOPQRSTUVWXYZ";
        foreach (char lettre in lettreAlphabet)
        {
            Console.Write(lettre.ToString().ToLower());
        }
        Console.WriteLine();
        Console.ReadLine();
    }
}

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