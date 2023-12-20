/* 02 - AFFICHEUR D'ARGUMENTS - 02

Cr�ez un programme qui affiche les arguments qu�il re�oit ligne par ligne, peu importe le nombre d�arguments.
Exemples d�utilisation :
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
            Console.WriteLine("Bonjour ! \nBienvenue dans ce programme. \nCette console affiche les arguments re�us ligne par ligne.");
            Console.WriteLine("==========-==========-==========");


            string[] args = { "Je s'appelle Groot !" };
            GetArgs(args);
        }

        static void GetArgs(string[] args)
        {
            for (int i = 0; i < args.Length; i++)
            {
                // Utilisez la m�thode Split pour diviser la cha�ne par la virgule
                string[] splitArgs = args[i].Split(' ');

                // Affichez chaque �l�ment de la cha�ne divis�e ligne par ligne
                for (int j = 0; j < splitArgs.Length; j++)
                {
                    Console.WriteLine(splitArgs[j].Trim()); // Utilisez Trim pour supprimer les espaces autour des mots
                }
            }
            Console.WriteLine();
        }
    }
}

