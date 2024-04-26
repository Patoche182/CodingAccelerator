/*     11 - Différence minimum absolue - 11

Créez un programme qui affiche la différence minimum absolue entre deux éléments d’un tableau constitué uniquement de nombres. Nombres négatifs acceptés.

Exemples d’utilisation :
$> python exo.py 5 1 19 21
2

$> python exo.py 20 5 1 19 21
1

$> python exo.py -8 -6 4
2

Afficher error et quitter le programme en cas de problèmes d’arguments.
 */
class Eau11
{
    static void Main(string[] args)
    {
        Console.WriteLine("==========-==========-==========-==========-==========");
        Console.WriteLine("Epreuve de l'Eau11 !");
        Console.WriteLine("==========-==========-==========-==========-==========");
        try
        {
            // Demander à l'utilisateur d'entrer au moins deux nombres
            Console.WriteLine("Entrez les nombres séparés par des espaces :");
            var input = Console.ReadLine();

            if (string.IsNullOrEmpty(input))
            {
                Console.WriteLine("error");
                return;
            }

            // Convertir l'entrée en liste de nombres entiers
            var numbers = input.Split(' ')
                               .Select(x => int.Parse(x))
                               .ToList();

            if (numbers.Count < 2)
            {
                Console.WriteLine("error");
                return;
            }

            // Trier la liste
            numbers.Sort();

            // Calculer la différence minimale absolue
            int minDifference = int.MaxValue;

            for (int i = 0; i < numbers.Count - 1; i++)
            {
                int diff = Math.Abs(numbers[i + 1] - numbers[i]);
                if (diff < minDifference)
                {
                    minDifference = diff;
                }
            }

            // Afficher la différence minimale
            Console.WriteLine($"La différence minimale est : {minDifference}");
        }
        catch (Exception)
        {
            Console.WriteLine("error");
        }
    }
}




//        // Vérifier si on a au moins deux arguments
//        if (args.Length < 2)
//        {
//            Console.WriteLine("error");
//            return;
//        }

//        try
//        {
//            // Convertir les arguments en entiers
//            var numbers = args.Select(arg => int.Parse(arg)).ToList();

//            // Trier le tableau
//            numbers.Sort();

//            // Calculer la différence minimale
//            int minDifference = int.MaxValue;

//            for (int i = 0; i < numbers.Count - 1; i++)
//            {
//                int diff = Math.Abs(numbers[i + 1] - numbers[i]);
//                if (diff < minDifference)
//                {
//                    minDifference = diff;
//                }
//            }

//            // Afficher la différence minimale
//            Console.WriteLine(minDifference);
//        }
//        catch (Exception)
//        {
//            Console.WriteLine("error");
//        }
//    }
//}