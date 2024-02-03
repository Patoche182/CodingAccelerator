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

            if (chaine != "") // on pourrait ajouter une condition pour que seul les lettres soit prise en compte :  if ((chaine != "") && (chaine != int))  ==>> Correction GPT ==>> if (!string.IsNullOrEmpty(chaine) && !chaine.Any(char.IsDigit)) 
            {
                Console.WriteLine("La chaîne contient - " + Taille(chaine) + " - caractères.");
            }
            else
            {
                Console.WriteLine("Attention, vous n'avez pas entré une chaine valide. \nEcrivez un mot, une phrase, un code à chiffres, etc ...");
            }
            Console.WriteLine("----------=----------=----------=----------=----------");
        } while (true);
    }

    // Méthodes :
    static string Taille(string chaine)
    {
        int count = 0; // on initialise notre variable Count à zéro
        foreach (char lettre in chaine) // pour chaque lettre, et espace, dans notre chaine on ajoute +1 à notre variable count
        {
            count++;
        }
        return count.ToString(); // on renvoie la valeur final de count dans en string
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
