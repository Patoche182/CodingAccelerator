/* 03 - L�ALPHABET A PARTIR DE - 03

Cr�ez un programme qui affiche l�alphabet � partir de la lettre donn�e en argument en lettres minuscules suivi d�un retour � la ligne.
Exemples d�utilisation :
    $> python exo.py n
    nopqrstuvwxyz
    $>
Attention : votre programme devra utiliser une boucle.

|||||||||||||||||||||||| Correction : environment.getCommandLineArgs (pour r�cup�rer mes arguments) ||||||||||||||||||||||||
|||||||||||||||||||||||| Correction : chaine vide + incr�menter ||||||||||||||||||||||||
*/



class Terre03
{
    static void Main()
    {
        Console.WriteLine("==========-==========-==========-==========-==========");
        Console.WriteLine("Bonjour ! \nBienvenue dans ce programme. \nCette console donne l'alphabet � partir de la lettre donn�e en argument.");
        Console.WriteLine("==========-==========-==========-==========-==========");

        // M�thode 2 :

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
        //            Console.WriteLine("Entr�e non valide. Vous avez entr� un chiffre ou plusieurs caract�res.");
        //        }
        //    } while (true);
        //}

        // Apr�s Optimisation ChatGPT
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
                Console.WriteLine("Entr�e non valide. Vous avez entr� un chiffre ou plusieurs caract�res.");
                Console.WriteLine("-------------=-------------=-------------=-------------=-------------\n");
            }
        }
    }

    static void GetAlphabetFromLetter(char letter)
    {
        string alphabet = "ABCDEFGHIJKLMNOPQRSTUVWXYZ"; // abcdefghijklmnopqrstuvwxyz "ABCDEFGHIJKLMNOPQRSTUVWXYZ"
        letter = char.ToLower(letter);
        bool found = false; // J'int�gre un bool ==> 
        /*
         La variable found est une variable bool�enne (de type bool) qui est utilis�e comme un indicateur pour suivre si la lettre de l'utilisateur a �t� trouv�e lors de la boucle � travers l'alphabet.
         Son objectif est de d�terminer � partir de quelle position dans l'alphabet l'affichage doit commencer.
         Initialement, found est d�fini sur false (non trouv�) avant que la boucle commence.
         Pendant la boucle, lorsque la lettre de l'utilisateur est trouv�e (c'est-�-dire lorsque letter == i), la variable found est d�finie sur true pour indiquer que la lettre a �t� trouv�e.
         Ensuite, la boucle continue � afficher les caract�res de l'alphabet m�me apr�s avoir trouv� la lettre de l'utilisateur.
         Cette approche permet de d�terminer � partir de quelle position dans l'alphabet l'affichage doit commencer, garantissant ainsi que la lettre de l'utilisateur est incluse dans le r�sultat.
         Sans cette variable, l'affichage commencerait d�s le d�but de l'alphabet, et la lettre de l'utilisateur ne serait pas incluse dans le r�sultat.
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

// M�thode 1 :

//static void Main()
//{
//    Console.WriteLine("==========-==========-==========-==========-==========");
//    Console.WriteLine("Bonjour ! \nBienvenue dans ce programme. \nCette console donne l'alphabet � partir de la lettre donn�e en argument.");
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