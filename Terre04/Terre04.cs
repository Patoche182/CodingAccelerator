/* 04 - PAIR OU IMPAIR - 04

Créez un programme qui permet de déterminer si l’argument donné est un entier pair ou impair..
Exemples d’utilisation :
    $> ruby exo.rb 2
    pair
    $> ruby exo.rb 5
    impair
    $> ruby exo.rb Bonjour
    Tu ne me la mettras pas à l’envers.
    $> ruby exo.rb
    Tu ne me la mettras pas à l’envers.
Attention : gérez aussi les entiers négatifs.
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
        Console.WriteLine("Cette console récupère en [Entrée] le chiffre donné et renvoi en [Sortie] si c'est un chiffre Pair ou Impaire. \nIl renvoi aussi si il est Positif ou Négatif.");
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
                Console.WriteLine("Tu ne me la mettras pas à l'envers. Il me faut un chiffre entier !");
            }
            Console.WriteLine("---------- ---------- ----------");
        } while (true);
    }

    // Voilà commment déterminer si l’argument donné est un entier pair ou impair
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

    // Voilà comment gérez aussi les entiers négatifs.
    static string PositifOuNegatif(int nombre)
    {
        if (nombre > 0)
        {
            return "Positif";
        }
        else if (nombre < 0)
        {
            return "Négatif";
        }
        else
        {
            return "Zéro || 0 est bien Pair mais il n'est ni Positif ni Négatif !";
        }
    }
}