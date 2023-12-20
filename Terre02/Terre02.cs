/* 02 - AFFICHEUR D'ARGUMENTS - 02

Créez un programme qui affiche les arguments qu’il reçoit ligne par ligne, peu importe le nombre d’arguments.
Exemples d’utilisation :
    $> ruby exo.rb je suis solide !
    je
    suis
    solide
    !
*/


class Terre02
{

    class Program
    {
        static void Main()
        {
            Console.WriteLine("==========-==========-==========");
            Console.WriteLine("Bonjour ! \nBienvenue dans ce programme. \nCette console affiche les arguments reçus ligne par ligne.");
            Console.WriteLine("==========-==========-==========");


            string[] args = { "Je s'appelle Groot !" };
            GetArgs(args);
        }

        static void GetArgs(string[] args)
        {
            for (int i = 0; i < args.Length; i++)
            {
                // Utilisez la méthode Split pour diviser la chaîne par la virgule
                string[] splitArgs = args[i].Split(' ');

                // Affichez chaque élément de la chaîne divisée ligne par ligne
                for (int j = 0; j < splitArgs.Length; j++)
                {
                    Console.WriteLine(splitArgs[j].Trim()); // Utilisez Trim pour supprimer les espaces autour des mots
                }
            }
            Console.WriteLine();
        }
    }
}

