/* 06 - INVERSER UNE CHAINE - 06 

Cr�ez un programme qui affiche l�inverse de la cha�ne de caract�res donn�e en argument.
Exemples d�utilisation :
    $> node exo.js �Hello world!�
    !dlrow olleH
    $> node exo.js �lehciM�
    Michel
Attention : je compte sur vous pour g�rer les potentielles erreurs d�arguments.

Fonctions interdites: 
-La fonction reverse
*/


class Terre06
{
    static void Main()
    {
        Console.WriteLine("==========-==========-==========-==========-==========");
        Console.WriteLine("Bonjour ! \nBienvenue dans ce programme.");
        Console.WriteLine("Cette console inverse une cha�ne de caract�re. \nAutrement dit, le mot ou la phrase est � l'envers.");
        Console.WriteLine("==========-==========-==========-==========-==========");

        do
        {
            Console.WriteLine("Ecris un mot ou une phrase (ou 'exit' pour quitter) :");
            string userInput = Console.ReadLine();
            string chaine = userInput;

            if (chaine == "exit")
                break;

            if (chaine != "")
            {
                Console.WriteLine(Inverser(chaine));
            }
            else
            {
                Console.WriteLine("Attention, ce n'est pas valide. Pour fermer ce programme �cris : exit");
            }
            Console.WriteLine("----------=----------=----------=----------=----------");
            Console.WriteLine("----------=----------=----------=----------=----------");
        } while (true);
    }

    // M�thodes :
    static string Inverser(string chaine)
    {
        string inverse = "";
        for (int i = chaine.Length - 1; i >= 0; i--)
        {
            // �crire les char un � un dans inverse
            inverse += chaine[i];
        }
        return inverse;
    }
}