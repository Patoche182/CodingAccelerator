/*     13 - Tri par sélection - 13

Créez un programme qui trie une liste de nombres. Votre programme devra implémenter l’algorithme du tri par sélection.

Vous utiliserez une fonction de cette forme (selon votre langage) :
my_select_sort(array)
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
class Eau13
{
    static void Main(string[] args)
    {
        Console.WriteLine("==========-==========-==========-==========-==========");
        Console.WriteLine("Epreuve de l'Eau13 !");
        Console.WriteLine("==========-==========-==========-==========-==========");


        // Fonction pour implémenter le tri par sélection
        static List<int> SelectionSort(List<int> array)
        {
            int n = array.Count;

            for (int i = 0; i < n - 1; i++)
            {
                int minIndex = i;
                // Trouver l'indice du plus petit élément restant
                for (int j = i + 1; j < n; j++)
                {
                    if (array[j] < array[minIndex])
                    {
                        minIndex = j;
                    }
                }

                // Échanger le plus petit élément avec l'élément à la position courante
                if (minIndex != i)
                {
                    int temp = array[minIndex];
                    array[minIndex] = array[i];
                    array[i] = temp;
                }
            }
            return array;
        }

        // Fonction principale qui accepte des arguments et appelle la fonction de tri
        static void Main(string[] args)
        {
            if (args.Length == 0)
            {
                Console.WriteLine("error");
                return;
            }

            List<int> numbers = new List<int>();

            foreach (string arg in args)
            {
                int number;
                if (int.TryParse(arg, out number))
                {
                    numbers.Add(number);
                }
                else
                {
                    Console.WriteLine("error");
                    return;
                }
            }
            List<int> sortedNumbers = SelectionSort(numbers);
            Console.WriteLine(string.Join(" ", sortedNumbers));
        }
    }
}