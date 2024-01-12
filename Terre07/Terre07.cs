/* 07 - TAILLE D'UNE CHAINE - 07

Créez un programme qui affiche le nombre de caractères d’une chaîne de caractères passée en argument.
Exemples d’utilisation :
    $> python exo.py “Hello world!”
    12
    $> python exo.py
    erreur.
    $> python exo.py “Bonjour” “Aurevoir”
    erreur.
    $> python exo.py 10
    erreur.

Fonctions interdites: 
-La fonction length
-La fonction size
 */

// allé on va le faire et vite :) !!!

class Terre07
{
    static void Main()
    {
        Console.WriteLine("==========-==========-==========-==========-==========");
        Console.WriteLine("Bonjour ! \nBienvenue dans ce programme.");
        Console.WriteLine("Cette console affiche le nombre de caractères d’une chaîne de caractères, sans utiliser la fonction Length !");
        Console.WriteLine("==========-==========-==========-==========-==========");

        do
        {
            Console.WriteLine("Veuillez entrer une chaîne de caradctère. (ou 'exit' pour quitter) :");
            string userInput = Console.ReadLine();
            string chaine = userInput;

            if (chaine == "exit")
                break;

            if (chaine != "")
            {
                Console.WriteLine(Taille(chaine));
            }
            else
            {
                Console.WriteLine("Attention, ce n'est pas valide. Pour fermer ce programme : exit");
            }
            Console.WriteLine("----------=----------=----------=----------=----------");
            Console.WriteLine("----------=----------=----------=----------=----------");
        } while (true);
    }

    // Méthodes :
    static string Taille(string chaine)
    {
        string taille = "";
        for (int i = 0; i < chaine.Length; i++)
        {
            // compter le nombre de lettre

        }
        return taille;
    }
}


//class Program
//{
//    static void Main(string[] args)
//    {
//        if (args.Length > 0)
//        {
//            string inputString = args[0];

//            // Utilisez une boucle pour compter les caractères
//            int characterCount = 0;

//            foreach (char c in inputString)
//            {
//                // Incrémentez le compteur pour chaque caractère
//                characterCount++;
//            }

//            // Affichez le résultat
//            Console.WriteLine($"La chaîne \"{inputString}\" contient {characterCount} caractères.");
//        }
//        else
//        {
//            Console.WriteLine("Veuillez fournir une chaîne de caractères en argument.");
//        }
//    }
//}
