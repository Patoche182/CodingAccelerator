/*     09 - Entre min et max - 09

Créez un programme qui affiche toutes les valeurs comprises entre deux nombres dans l’ordre croissant. Min inclus, max exclus.

Exemples d’utilisation :
$> python exo.py 20 25
20 21 22 23 24

$> python exo.py 25 20
20 21 22 23 24

$> python exo.py hello
error

Afficher error et quitter le programme en cas de problèmes d’arguments.
 */
class Eau09
{
    static void Main(string[] args)
    {
        Console.WriteLine("==========-==========-==========-==========-==========");
        Console.WriteLine("Epreuve de l'Eau09 !");
        Console.WriteLine("==========-==========-==========-==========-==========");

        // Demander à l'utilisateur d'entrer les deux nombres
        Console.WriteLine("Entrez le nombre minimum :");
        int min = int.Parse(Console.ReadLine());

        Console.WriteLine("Entrez le nombre maximum :");
        int max = int.Parse(Console.ReadLine());

        // Vérifier si le maximum est supérieur au minimum
        if (max <= min)
        {
            Console.WriteLine("Le nombre maximum doit être supérieur au nombre minimum.");
            return; // Sortir du programme
        }

        // Afficher les valeurs entre min et max dans l'ordre croissant
        Console.WriteLine("Les valeurs entre " + min + " et " + max + " (exclus) sont :");
        for (int i = min; i < max; i++)
        {
            Console.WriteLine(i);
        }
    }
}