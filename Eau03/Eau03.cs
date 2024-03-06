/*     03 - Suite de Fibonacci - 03

Créez un programme qui affiche le N-ème élément de la célèbre suite de Fibonacci. (0, 1, 1, 2) étant le début de la suite et le premier élément étant à l’index 0.

Exemples d’utilisation :
$> python exo.py 3
2
$>
Afficher -1 si le paramètre est négatif ou mauvais.
*/


class Eau03
{
    static void Main(string[] args)
    {
        Console.WriteLine("==========-==========-==========-==========-==========");
        Console.WriteLine("Epreuve de l'Eau03 !");
        Console.WriteLine("==========-==========-==========-==========-==========");

        Console.WriteLine("Entrez la valeur de N :");
        int n = int.Parse(Console.ReadLine());

        int result = Fibonacci(n);

        Console.WriteLine($"Le {n}-ème élément de la suite de Fibonacci est : {result}");
    }

    static int Fibonacci(int n)
    {
        if (n <= 1)
            return n;

        int a = 0;
        int b = 1;
        int temp = 0;

        for (int i = 2; i <= n; i++)
        {
            temp = a + b;
            a = b;
            b = temp;
        }

        return b;
    }
}