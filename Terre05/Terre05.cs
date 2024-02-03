/* 05 - DIVISIONS - 05

Créez un programme qui affiche le résultat et le reste d’une division entre deux nombres.
Exemples d’utilisation :
    $> python exo.py 5 2
    résultat: 2
    reste: 1
    $> python exo.py 10 0
    erreur.
    $> python exo.py 3 5
    erreur.
*/





using static System.Runtime.InteropServices.JavaScript.JSType;

class Terre05
{
    static void Main()
    {
        Console.WriteLine("==========-==========-==========-==========-==========");
        Console.WriteLine("Bonjour ! \nBienvenue dans ce programme.");
        Console.WriteLine("Cette console récupère en [Entrée] 2 nombres à diviser et renvoi en [Sortie] le résultat. \nIl renvoi aussi le reste de la division."); // exemple 5/2 = 2 : % = 1
        Console.WriteLine("==========-==========-==========-==========-==========");

        do
        {
            Console.WriteLine("Donne-moi un nombre que tu souhaite diviser (ou 'exit' pour quitter) :");
            int a = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Maintenant, par quelle valeur souhaite-tu le diviser (ou 'exit' pour quitter) :");
            int b = Convert.ToInt32(Console.ReadLine());

            if (b != 0) // le deuxième nombre doit être différent de zéro avant de continuer
            {
                Console.WriteLine("Le résultat de la division est " + Division(a, b) + ". Le reste est de " + Reste(a, b));
            }
            else
            {
                Console.WriteLine("Attention, la division par zéro est impossible!");
            }
            Console.WriteLine("----------=----------=----------=----------=----------");
        } while (true);
    }

    static int Division(int a, int b)
    {
        int resultat = a / b;
        return resultat;
    }

    static int Reste(int a, int b)
    {
        int reste = a % b; // à modifier pour ne pas utiliser le Modulo
        return reste;
    }

    // Console.WriteLine("Donne-moi un chiffre:");
    // string response = Console.ReadLine();
    //int a = 10;
    //int b = 3;
    //Console.WriteLine(Division(a, b));
    //Console.WriteLine(Reste(a, b));

    //static (int, int) Reste(int a, int b)
    //{
    //    int reste = a % b;
    //    return (resultat, reste);
    //}
}