/*     06 - Majuscule sur deux - 06

Créez un programme qui met en majuscule une lettre sur deux d’une chaîne de caractères. Seule les lettres (A-Z, a-z) sont prises en compte.

Exemples d’utilisation :
$> python exo.py “Hello world !”
HeLlO wOrLd !

$> python exo.py 42
error

Afficher error et quitter le programme en cas de problèmes d’arguments.
 */

// METHODE RESOLUTION 
// METHODE UTILITAIRE 
// GESTION ERREUR 

class Eau06
{
    // METHODE RESOLUTION 
    static void Main(string[] args)
    {
        if (args.Length == 1)
        {
            Console.WriteLine("Veuillez fournir une chaîne de caractères en argument : ");
            string input = Console.ReadLine();
            AfficherMajusculeUneLettreSurDeux(input);
        }
        else
        {
            Console.WriteLine("Error");
            return;
            //AfficherMajusculeUneLettreSurDeux(args[0]);
        }
    }

    // METHODE UTILITAIRE 
    static void AfficherMajusculeUneLettreSurDeux(string chaine)
    {
        bool majuscule = true;

        foreach (char c in chaine)
        {
            if (char.IsLetter(c))
            {
                if (majuscule)
                {
                    Console.Write(char.ToUpper(c));
                }
                else
                {
                    Console.Write(char.ToLower(c));
                }
                majuscule = !majuscule;
            }
            else
            {
                Console.Write(c);
            }
        }
        Console.WriteLine();
    }
}
