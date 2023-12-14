// 02 - AFFICHEUR D'ARGUMENTS - 02
//Créez un programme qui affiche les arguments qu’il reçoit ligne par ligne, peu importe le nombre d’arguments.
//Exemples d’utilisation :
//$> ruby exo.rb je suis solide !
//je
//suis
//solide
//!


class Terre02
{
    static void Main()
    {
        string lettreAlphabet = "ABCDEFGHIJKLMNOPQRSTUVWXYZ";
        foreach (char lettre in lettreAlphabet)
        {
            Console.Write(lettre.ToString().ToLower());
        }
        Console.WriteLine();
    }
}
