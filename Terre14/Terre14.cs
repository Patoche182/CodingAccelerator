/* 14 - Trié ou pas - 14

Créez un programme qui détermine si une liste d’entiers est triée ou pas.
Exemples d’utilisation :
    $> ruby exo.rb 9 8 3
    Pas triée !
    $> ruby exo.rb 3 8 9 12
    Triée !
    $> ruby exo.rb “Salut”
    erreur.

Fonctions interdites: 
-La fonction sort
*/

class Terre14
{
    static void Main()
    {
        Console.WriteLine("==========-==========-==========-==========-==========");
        Console.WriteLine("Bonjour ! \nBienvenue dans ce programme.");
        Console.WriteLine("Cette console récupère en [Entrée] une liste de nombres entier et renvoi en [Sortie] si ceux-ci sont triée ou pas. \nFournissez des nombres séparé par un espace ex: 5 10 3 25 105 9");
        Console.WriteLine("==========-==========-==========-==========-==========");

        do
        {
            Console.WriteLine("Veuillez entrer vos nombres entiers, séparés par un espace (ou 'exit' pour quitter) :");
            string input = Console.ReadLine();

            if (input.ToLower() == "exit") { break; } // ne pas oublier ToLower()
            string[] inputs = input.Split(' ');
            if (inputs.Length != 3)
            {
                Console.WriteLine("Veuillez entrer exactement 3 nombres entiers.");
                continue;
            }
            // On essaie de vérifier que les entrées sont bien convertie en int : ( avec int.TryParse() )
            int a, b, c;
            if (!int.TryParse(inputs[0], out a) || !int.TryParse(inputs[1], out b) || !int.TryParse(inputs[2], out c)) // Si une des conditons est true (si elle echoue quoi) ce If renvoi un message d'erreur.
            {
                Console.WriteLine("Veuillez entrer des nombres entiers valides.");
                continue;
            }
            if ((a < b) && (b < c))
            {
                Console.WriteLine("La valeur intermédiaire est " + b);
            }
            else if ((a < c) && (c < b))
            {
                Console.WriteLine("La valeur intermédiaire est " + c);
            }
            else
            {
                Console.WriteLine("La valeur intermédiaire est " + a);
            }
            Console.WriteLine("----------=----------=----------=----------=----------");
        } while (true);
    }
}