/* 03 - L�ALPHABET A PARTIR DE - 03

Cr�ez un programme qui affiche l�alphabet � partir de la lettre donn�e en argument en lettres minuscules suivi d�un retour � la ligne.
Exemples d�utilisation :
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
