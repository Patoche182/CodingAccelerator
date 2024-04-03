/*     07 - Majuscule - 07

Créez un programme qui met en majuscule la première lettre de chaque mot d’une chaîne de caractères. Les autres lettres devront être en minuscules. Les mots ne sont délimités que par un espace, une tabulation ou un retour à la ligne.

Exemples d’utilisation :
$> python exo.py “bonjour mathilde, comment vas-tu ?!”
Bonjour Mathilde, Comment Vas-tu ?!

$> python exo.py 42
error

Afficher error et quitter le programme en cas de problèmes d’arguments.
 */
class Eau07
{
    static void Main(string[] args)
    {
        AfficherSeparateurs();
        Console.WriteLine("Epreuve de l'Eau07 !");
        AfficherSeparateurs();

        Console.WriteLine("Entrez une phrase :");
        string phrase = Console.ReadLine();
        string nouvellePhrase = MettrePremiereLettreMajuscule(phrase);
        Console.WriteLine("Phrase avec la première lettre de chaque mot en majuscule :");
        Console.WriteLine(nouvellePhrase);
    }

    static void AfficherSeparateurs()
    {
        Console.WriteLine("==========-==========-==========-==========-==========");
    }

    static string MettrePremiereLettreMajuscule(string phrase)
    {
        string[] mots = phrase.Split(new char[] { ' ', '\t', '\n' }, StringSplitOptions.RemoveEmptyEntries);
        for (int i = 0; i < mots.Length; i++)
        {
            mots[i] = PremierCaractereMajuscule(mots[i]);
        }
        return string.Join(" ", mots);
    }

    static string PremierCaractereMajuscule(string mot)
    {
        if (string.IsNullOrEmpty(mot))
        {
            return mot;
        }
        return char.ToUpper(mot[0]) + mot.Substring(1).ToLower();
    }
}