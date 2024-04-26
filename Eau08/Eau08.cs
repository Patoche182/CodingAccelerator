/*     08 - Chiffres only - 08

Créez un programme qui détermine si une chaîne de caractères ne contient que des chiffres.

Exemples d’utilisation :
$> python exo.py “4445353”
true

$> python exo.py 42
true

$> python exo.py “Bonjour 36”
false

Afficher error et quitter le programme en cas de problèmes d’arguments.
 */
class Eau08
{
    static void Main(string[] args)
    {
        DisplayHeader();
        string input = GetInput(args);
        ProcessInput(input);
        WaitForExit();
    }

    static void DisplayHeader()
    {
        Console.WriteLine("==========-==========-==========-==========-==========");
        Console.WriteLine("==========-==========-==========-==========-==========");
        Console.WriteLine("Epreuve de l'Eau08 !");
        Console.WriteLine("==========-==========-==========-==========-==========");
        Console.WriteLine("==========-==========-==========-==========-==========");
    }

    static string GetInput(string[] args)
    {
        if (args.Length != 0)
        {
            return args[0];
        }
        else
        {
            Console.WriteLine("Veuillez entrer une chaîne de caractères à vérifier :");
            return Console.ReadLine();
        }
    }

    static void ProcessInput(string input)
    {
        Console.WriteLine(IsNumeric(input) ? "true" : "false");
    }

    static bool IsNumeric(string str)
    {
        foreach (char c in str)
        {
            if (!char.IsDigit(c)) // Refaire avec les code ASCII 30 -39 pour vérifer que c'est bien un chiffre
            {
                return false;
            }
        }
        return true;
    }

    static void WaitForExit()
    {
        Console.WriteLine("Appuyez sur n'importe quelle touche pour quitter...");
        Console.ReadKey();
    }
}
