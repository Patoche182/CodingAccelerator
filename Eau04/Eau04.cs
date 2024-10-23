/*     04 - Prochain number premier - 04
Créez un programme qui affiche le premier number premier supérieur au number donné en argument.

Exemples d’utilisation :
$> python exo.py 14
17
$>

Afficher -1 si le paramètre est négatif ou mauvais.

 */

class Eau04
{
    // GESTION ERREUR
    public static bool IsValidArguments(string[] arguments)
    {
        if (arguments.Length == 1)
        {
            return true;
        }
        else
        {
            Console.WriteLine("Error ! Please enter only one argument.");
            return false;
        }
    }
    public static bool IsValidNumber(string number)
    {
        if (int.TryParse(number, out _))
        {
            return true;
        }
        else
        {
            Console.WriteLine("Error ! Please enter only number.");
            return false;
        }
    }
    public static bool IsPositiveNumber(int number)
    {
        if (number > 0)
        {
            return true;
        }
        else
        {
            Console.WriteLine("-1");
            return false;
        }
    }

    // METHODE RESOLUTION
    static void Main(string[] args)
    {
        if (Eau04.IsValidArguments(args))
        {
            string argument = args[0];
            if (Eau04.IsValidNumber(argument))
            {
                int number = int.Parse(args[0]);
                int result = FindNextPrimeNumber(number);
                if (result == -1)
                {
                    return;
                }
                Console.WriteLine($"Le premier nombre premier supérieur à {number} est : {result}");
            }
        }
    }

    // METHODE UTILITAIRE
    static bool isPrimeNumber(int number)
    {
        if (number <= 1)
            return false;
        for (int i = 2; i <= Math.Sqrt(number); i++) // for (int i = 2; i <= number; i++) à tester!
        {
            if (number % i == 0)
                return false;
        }
        return true;
    }

    static int FindNextPrimeNumber(int number)
    {
        int nextNumber = number + 1;
        while (true)
        {
            if (isPrimeNumber(nextNumber))
                return nextNumber;
            nextNumber++;
        }
    }
}