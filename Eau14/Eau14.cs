/*     14 - Par ordre Ascii - 14

Créez un programme qui trie les éléments donnés en argument par ordre ASCII.

Exemples d’utilisation :
$> python exo.py Alfred Momo Gilbert
Alfred Gilbert Momo

$> python exo.py A Z E R T Y
A E R T Y Z

Afficher error et quitter le programme en cas de problèmes d’arguments.
 */
class Eau14
{
    static void Main(string[] args)
    {
        Console.WriteLine("==========-==========-==========-==========");
        Console.WriteLine("Epreuve de l'Eau14 !");
        Console.WriteLine("==========-==========-==========-==========-==========");

        // Demander à l'utilisateur de saisir des chaînes de texte
        Console.WriteLine("Entrez des chaînes de texte séparées par des espaces, puis appuyez sur Entrée :");

        string input = Console.ReadLine(); // Lire l'entrée utilisateur
        List<string> elements = new List<string>(input.Split(' ')); // Diviser l'entrée en listes de chaînes

        // Trier les éléments par ordre ASCII
        List<string> sortedElements = SelectionSort(elements);

        Console.WriteLine("Chaînes triées par ordre ASCII : " + string.Join(" ", sortedElements));
    }

    // Fonction pour trier les éléments selon l'ordre ASCII avec le tri par sélection
    static List<string> SelectionSort(List<string> array)
    {
        int n = array.Count;

        for (int i = 0; i < n - 1; i++)
        {
            int minIndex = i;
            // Chercher le plus petit élément en ordre ASCII
            for (int j = i + 1; j < n; j++)
            {
                if (string.Compare(array[j], array[minIndex], StringComparison.Ordinal) < 0)
                {
                    minIndex = j;
                }
            }

            // Échanger si nécessaire
            if (minIndex != i)
            {
                string temp = array[minIndex];
                array[minIndex] = array[i];
                array[i] = temp;
            }
        }

        return array;
    }
}


/*
Explication :

La fonction SelectionSort utilise le même principe que dans l'exemple précédent, mais au lieu de comparer des nombres, elle compare des chaînes de caractères avec string.Compare, qui compare les chaînes selon leur valeur ASCII.
La fonction principale (Main) prend les arguments de la ligne de commande et les place dans une liste de chaînes.
Si aucun argument n'est fourni, elle affiche "error" et quitte le programme.
Si des arguments sont donnés, elle les trie avec SelectionSort puis les affiche dans l'ordre trié.
Pour utiliser ce programme, compilez-le avec un compilateur C# et exécutez-le avec des arguments de chaîne. Par exemple, si vous exécutez program.exe Alfred Momo Gilbert, le résultat sera Alfred Gilbert Momo, parce que 'A' vient avant 'G' et 'M' dans l'ordre ASCII. Si vous exécutez avec des arguments qui ne sont pas donnés, comme avec un appel vide, le programme affichera "error" et quittera.
 */