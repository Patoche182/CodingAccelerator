/*     12 - Tri à bulle - 12

Créez un programme qui trie une liste de nombres. Votre programme devra implémenter l’algorithme du tri à bulle.

Vous utiliserez une fonction de cette forme (selon votre langage) :
my_bubble_sort(array) 
{
	# votre algorithme
	return (new_array)
}

Exemples d’utilisation :
$> python exo.py 6 5 4 3 2 1
1 2 3 4 5 6

$> python exo.py test test test
error

Afficher error et quitter le programme en cas de problèmes d’arguments.

Wikipedia vous présentera une belle description de cet algorithme de tri.
 */
class Eau12
{
    // Fonction pour implémenter le tri à bulle
    static List<int> my_bubble_sort(List<int> array)
    {
        int n = array.Count;
        bool swapped;

        do
        {
            swapped = false;
            for (int i = 0; i < n - 1; i++)
            {
                if (array[i] > array[i + 1])
                {
                    // Échange des éléments
                    int temp = array[i];
                    array[i] = array[i + 1];
                    array[i + 1] = temp;
                    swapped = true;
                }
            }
            n--; // Chaque boucle de tri garantit que le dernier élément est le plus grand
        } while (swapped);

        return array;
    }

    static void Main()
    {
        try
        {
            Console.WriteLine("Entrez des nombres séparés par des espaces :");
            var input = Console.ReadLine();

            if (string.IsNullOrEmpty(input))
            {
                Console.WriteLine("error");
                return;
            }

            // Convertir les entrées en liste de nombres
            var numbers = input.Split(' ')
                               .Select(x => int.Parse(x))
                               .ToList();

            // Appeler le tri à bulle
            var sorted = my_bubble_sort(numbers);

            // Afficher la liste triée
            Console.WriteLine(string.Join(" ", sorted));
        }
        catch (Exception)
        {
            Console.WriteLine("error");
        }
    }
}
