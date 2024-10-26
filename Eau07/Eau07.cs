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
        string[] mots = phrase.Split(new char[] { ' ', '\t', '\n' }, StringSplitOptions.RemoveEmptyEntries); // Splitter par espace uniquement
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


/*
class Eau07
{
    static void Main(string[] args)
    {
        Console.WriteLine("==========-==========-==========-==========-==========");
        Console.WriteLine("Epreuve de l'Eau07 !");
        Console.WriteLine("==========-==========-==========-==========-==========");

        Console.WriteLine("Entrez une phrase :");
        string phrase = Console.ReadLine();
        string nouvellePhrase = MettrePremiereLettreMajuscule(phrase);
        Console.WriteLine("Phrase avec la première lettre de chaque mot en majuscule :");
        Console.WriteLine(nouvellePhrase);
    }

    static string MettrePremiereLettreMajuscule(string phrase)
    {
        // 1. Divise la phrase en mots en utilisant les espaces ' ' les tabulations '\t' et les sauts de ligne '\n' comme délimiteurs.
        // 2. Parcours chaque mot.
        // 3. Pour chaque mot non vide, met la première lettre en majuscule avec char.ToUpper et convertit le reste du mot en minuscules avec ToLower.
        // 4. Enfin, rejoint les mots modifiés avec un espace pour former une nouvelle phrase.

        string[] mots = phrase.Split(new char[] { ' ', '\t', '\n' }, StringSplitOptions.RemoveEmptyEntries);
        for (int i = 0; i < mots.Length; i++)
        {
            if (!string.IsNullOrEmpty(mots[i])) //Cette condition vérifie si le mot à l'indice i du tableau mots n'est pas nul ni vide. Cela permet d'éviter de traiter les éventuels espaces supplémentaires ou les délimiteurs multiples qui pourraient résulter de la division de la phrase.
            {
                mots[i] = char.ToUpper(mots[i][0]) + mots[i].Substring(1).ToLower(); // Pour chaque mot non vide, cette ligne met la première lettre en majuscule en utilisant char.ToUpper sur le premier caractère du mot (mots[i][0]), puis elle concatène le reste du mot, converti en minuscules avec ToLower(), en utilisant Substring(1). Ainsi, chaque mot commence par une majuscule suivie de lettres minuscules.
            }
        }
        return string.Join(" ", mots); //cette ligne rejoint les mots modifiés en une seule chaîne de caractères en utilisant un espace comme séparateur. Cela donne la nouvelle phrase où chaque mot a sa première lettre en majuscule et les autres lettres en minuscule.
    }
} 
 */