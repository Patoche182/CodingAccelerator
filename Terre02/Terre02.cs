/* 02 - AFFICHEUR D'ARGUMENTS - 02

Créez un programme qui affiche les arguments qu’il reçoit ligne par ligne, peu importe le nombre d’arguments.
Exemples d’utilisation :
    $> ruby exo.rb je suis solide !
    je
    suis
    solide
    !
*/


class Terre02
{
    static void Main()
    {
        string[] args = { "Je s'appelle Groot !", "Je m'apelle Patrice", "Alex me saoule" };
        GetArgs(args);
    }
    static void GetArgs(string[] args)
    {
        for (int i = 0; i < args.Length; i++)
        {
            Console.WriteLine(args[i]);
        }
        Console.WriteLine();
    }
}
