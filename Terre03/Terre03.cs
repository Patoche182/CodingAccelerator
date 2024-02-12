/* 03 - L’ALPHABET A PARTIR DE - 03

Créez un programme qui affiche l’alphabet à partir de la lettre donnée en argument en lettres minuscules suivi d’un retour à la ligne.
Exemples d’utilisation :
    $> python exo.py n
    nopqrstuvwxyz
    $>
Attention : votre programme devra utiliser une boucle.

|||||||||||||||||||||||| Correction : environment.getCommandLineArgs (pour récupérer mes arguments) ||||||||||||||||||||||||
|||||||||||||||||||||||| Correction : chaine vide + incrémenter ||||||||||||||||||||||||
*/



class Terre03
{
    static void Main()
    {
        Console.WriteLine("==========-==========-==========-==========-==========");
        Console.WriteLine("Bonjour ! \nBienvenue dans ce programme. \nCette console donne l'alphabet à partir de la lettre donnée en argument.");
        Console.WriteLine("==========-==========-==========-==========-==========");

        // Méthode 2 :

        // Avant Optimisation ChatGPT
        //    do
        //    {
        //        Console.Write("Veuillez entrer une lettre (ou 'exit' pour quitter) : ");
        //        string userInput = Console.ReadLine();

        //        if (userInput.ToLower() == "exit")
        //            break;

        //        if (userInput.Length == 1 && char.IsLetter(userInput[0]))
        //        {
        //            char userLetter = char.ToLower(userInput[0]);
        //            GetAlphabetFromLetter(userLetter);
        //        }
        //        else
        //        {
        //            Console.WriteLine("Entrée non valide. Vous avez entré un chiffre ou plusieurs caractères.");
        //        }
        //    } while (true);
        //}

        // Après Optimisation ChatGPT
        while (true)
        {
            Console.Write("Veuillez entrer une lettre : (ou 'exit' pour quitter)");
            string userInput = Console.ReadLine().ToLower();

            if (userInput == "exit")
                break;

            if (userInput.Length == 1 && char.IsLetter(userInput[0]))
            {
                char userLetter = userInput[0];
                GetAlphabetFromLetter(char.ToLower(userLetter));
            }
            else
            {
                Console.WriteLine("\n-------------=-------------=-------------=-------------=-------------");
                Console.WriteLine("Entrée non valide. Vous avez entré un chiffre ou plusieurs caractères.");
                Console.WriteLine("-------------=-------------=-------------=-------------=-------------\n");
            }
        }
    }

    static void GetAlphabetFromLetter(char letter)
    {
        string alphabet = "ABCDEFGHIJKLMNOPQRSTUVWXYZ"; // abcdefghijklmnopqrstuvwxyz "ABCDEFGHIJKLMNOPQRSTUVWXYZ"
        letter = char.ToLower(letter);
        bool found = false; // J'intègre un bool ==> 
        /*
         La variable found est une variable booléenne (de type bool) qui est utilisée comme un indicateur pour suivre si la lettre de l'utilisateur a été trouvée lors de la boucle à travers l'alphabet.
         Son objectif est de déterminer à partir de quelle position dans l'alphabet l'affichage doit commencer.
         Initialement, found est défini sur false (non trouvé) avant que la boucle commence.
         Pendant la boucle, lorsque la lettre de l'utilisateur est trouvée (c'est-à-dire lorsque letter == i), la variable found est définie sur true pour indiquer que la lettre a été trouvée.
         Ensuite, la boucle continue à afficher les caractères de l'alphabet même après avoir trouvé la lettre de l'utilisateur.
         Cette approche permet de déterminer à partir de quelle position dans l'alphabet l'affichage doit commencer, garantissant ainsi que la lettre de l'utilisateur est incluse dans le résultat.
         Sans cette variable, l'affichage commencerait dès le début de l'alphabet, et la lettre de l'utilisateur ne serait pas incluse dans le résultat.
         */

        foreach (char i in alphabet.ToLower())
        {
            if (letter == i)
            {
                found = true;
            }
            if (found)
            {
                Console.Write(i);
            }
        }
    }
}

// Méthode 1 :

//static void Main()
//{
//    Console.WriteLine("==========-==========-==========-==========-==========");
//    Console.WriteLine("Bonjour ! \nBienvenue dans ce programme. \nCette console donne l'alphabet à partir de la lettre donnée en argument.");
//    Console.WriteLine("==========-==========-==========-==========-==========");

//    GetAlphabetFromLetter('F');
//}

//static void GetAlphabetFromLetter(char letter)
//{
//    letter = Convert.ToChar(letter.ToString().ToLower());
//    string lettreAlphabet = "ABCDEFGHIJKLMNOPQRSTUVWXYZ";
//    foreach (char i in lettreAlphabet.ToLower())
//    {
//        if (letter < i)
//        {
//        Console.Write(i);
//        }
//    }
//    Console.WriteLine();
//}