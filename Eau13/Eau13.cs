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


//Voici ce que fait ce programme :

//Il accepte une liste d'arguments de ligne de commande.
//Il tente de les convertir en nombres entiers. S'il y a un argument qui n'est pas un nombre, il affiche "error" et quitte le programme.
//S'il réussit à convertir tous les arguments en nombres, il utilise le tri par sélection pour les trier.
//Ensuite, il affiche les nombres triés.



/*
1. Fonction de tri par sélection:
Le tri par sélection fonctionne en cherchant le plus petit élément dans une liste non triée et en le mettant à la première position. Ensuite, on passe au reste de la liste, cherche le prochain plus petit élément, et le place à la position suivante, et ainsi de suite, jusqu'à ce que toute la liste soit triée.
Dans la fonction SelectionSort, on fait des boucles pour parcourir la liste. La boucle externe (celle qui commence par for (int i = 0; i < n - 1; i++)) représente la position où l'on placera le plus petit élément trouvé. La boucle interne (for (int j = i + 1; j < n; j++)) est celle qui recherche ce plus petit élément.
Quand on trouve le plus petit élément, on l'échange avec celui de la position actuelle (utilisant une variable temporaire pour ne pas perdre la valeur).
2. Fonction principale (Main):
C'est la fonction qui exécute le programme. Elle reçoit des arguments (les valeurs que tu veux trier) via la ligne de commande.
Elle commence par vérifier s'il y a des arguments. Si ce n'est pas le cas, elle affiche "error" et quitte le programme.
Si des arguments sont fournis, elle essaie de les convertir en nombres entiers (avec int.TryParse(arg, out number)). Si l'un des arguments n'est pas un nombre, elle affiche "error" et quitte le programme.
Si tous les arguments sont bien des nombres, elle appelle la fonction SelectionSort pour les trier.
Enfin, elle affiche la liste triée en utilisant string.Join(" ", sortedNumbers).
Exemple d'utilisation:
Quand tu exécutes le programme, tu peux passer des arguments qui représentent les nombres à trier.
Si tu passes une liste de nombres, comme 6 5 4 3 2 1, le programme les trie et affiche 1 2 3 4 5 6.
Si tu passes quelque chose qui n'est pas un nombre, comme test, le programme affiche "error" et s'arrête.

En résumé, ce programme prend des arguments, les convertit en nombres, les trie en utilisant le tri par sélection, et affiche le résultat trié. Si les arguments ne peuvent pas être convertis en nombres, il affiche "error" et quitte.
 */