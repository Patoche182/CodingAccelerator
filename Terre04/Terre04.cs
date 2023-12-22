/* 04 - PAIR OU IMPAIR - 04

Cr�ez un programme qui permet de d�terminer si l�argument donn� est un entier pair ou impair..
Exemples d�utilisation :
    $> ruby exo.rb 2
    pair
    $> ruby exo.rb 5
    impair
    $> ruby exo.rb Bonjour
    Tu ne me la mettras pas � l�envers.
    $> ruby exo.rb
    Tu ne me la mettras pas � l�envers.
Attention : g�rez aussi les entiers n�gatifs.
Fonctions interdites: 
-En Ruby: even? et odd ?
*/

class Terre04
{
    static void Main()
    {
        Console.WriteLine(System.IO.Path.GetTempPath());

        Console.WriteLine("==========-==========-==========");
        Console.WriteLine("Bonjour ! \nBienvenue dans ce programme.");
        Console.WriteLine("Cette console r�cup�re en [Entr�e] le chiffre donn� et renvoi en [Sortie] si c'est un chiffre Pair ou Impaire. \nIl renvoi aussi si il est Positif ou N�gatif.");
        Console.WriteLine("==========-==========-==========");

        // Boucle Do-While
        do
        {
            Console.WriteLine("Donne-moi un chiffre:");
            string response = Console.ReadLine();
            int x;
            if (int.TryParse(response, out x))
            {
                Console.WriteLine("C'est un " + PairOuImpair(x) + " - " + PositifOuNegatif(x));
            }
            else
            {
                Console.WriteLine("Tu ne me la mettras pas � l'envers. Il me faut un chiffre entier !");
            }
            Console.WriteLine("---------- ---------- ----------");
        } while (true);
    }

    // Voil� commment d�terminer si l�argument donn� est un entier pair ou impair
    static string PairOuImpair(int nombre)
    {
        if (nombre % 2 == 0) 
        {
            return "Pair";
        }
        else
        {
            return "Impair";
        }
    }

    // Voil� comment g�rez aussi les entiers n�gatifs.
    static string PositifOuNegatif(int nombre)
    {
        if (nombre > 0)
        {
            return "Positif";
        }
        else if (nombre < 0)
        {
            return "N�gatif";
        }
        else
        {
            return "Z�ro || 0 est bien Pair mais il n'est ni Positif ni N�gatif !";
        }
    }
}