/*     03 - Suite de Fibonacci - 03

Créez un programme qui affiche le N-ème élément de la célèbre suite de Fibonacci. (0, 1, 1, 2) étant le début de la suite et le premier élément étant à l’index 0.

Exemples d’utilisation :
$> python exo.py 3
2
$>
Afficher -1 si le paramètre est négatif ou mauvais.
*/

using System.Net.Http.Headers;

class Eau03
{

    // METHODE RESOLUTION
    static void Main(string[] args)
    {
        if (Eau03.IsValidArguments(args))
        {
            string argument = args[0];
            if (Eau03.IsValidNumber(argument))
            {
                int n = int.Parse(args[0]);
                int result = Fibonacci(n);

                if (result == -1)
                {
                    return;
                }
                Console.WriteLine($"Le {n}-ème élément de la suite de Fibonacci est : {result}");
            }
        }
    }

    // METHODE UTILITAIRE
    static int Fibonacci(int n)
    {
        if (!IsPositiveNumber(n))
        {
            int wrongNumber = -1;
            return wrongNumber;
        }

        int a = 0;
        int b = 1;
        int temp;

        /*
       À chaque itération de la boucle, nous calculons la somme de "a" et "b" et la stockons dans "temp". 
       Puis nous mettons à jour "a" avec la valeur de "b" et "b" avec la valeur de "temp".
       Cela nous permet de déplacer "a" et "b" vers les nombres suivants dans la suite de Fibonacci.
         */

        for (int i = 2; i <= n; i++)
        {
            temp = a + b;
            a = b;
            b = temp;
        }
        return b;
    }

    // GESTION ERREUR
    public static bool IsValidArguments(string[] arguments)
    {
        if (arguments.Length == 1)
        {
            return true;
        }
        else
        {
            Console.WriteLine("Error ! Please only one argument.");
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
            Console.WriteLine("Error ! Please only number.");
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
}