/* 03 - L’ALPHABET A PARTIR DE - 03

Créez un programme qui affiche l’alphabet à partir de la lettre donnée en argument en lettres minuscules suivi d’un retour à la ligne.
Exemples d’utilisation :
    $> python exo.py n
    nopqrstuvwxyz
    $>
Attention : votre programme devra utiliser une boucle.
*/
class Terre03
{
    static void Main()
    {
        GetAlphabetFromLetter('P');
    }

    static void GetAlphabetFromLetter(char letter)
    {
        letter = Convert.ToChar(letter.ToString().ToLower());
        string lettreAlphabet = "ABCDEFGHIJKLMNOPQRSTUVWXYZ";
        foreach (char i in lettreAlphabet.ToLower())
        {
            if (letter < i)
            {
            Console.Write(i);
            }
        }
        Console.WriteLine();
    }
}
