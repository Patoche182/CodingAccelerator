/*     04 - Prochain nombre premier - 04
Créez un programme qui affiche le premier nombre premier supérieur au nombre donné en argument.

Exemples d’utilisation :
$> python exo.py 14
17
$>

Afficher -1 si le paramètre est négatif ou mauvais.

 */

class Eau04
{

    // METHODE RESOLUTION
    // METHODE UTILITAIRE
    // GESTION ERREUR

    static void Main(string[] args)
    {
        Console.WriteLine("==========-==========-==========-==========-==========");
        Console.WriteLine("Epreuve de l'Eau04 !");
        Console.WriteLine("==========-==========-==========-==========-==========");

        int nombreDonne;
        if (args.Length == 0) // Bizare à checker
        {
            Console.WriteLine("Veuillez entrer un nombre en argument : ");
            string input = Console.ReadLine();
            if (!int.TryParse(input, out nombreDonne) || nombreDonne < 0)
            {
                Console.WriteLine("Veuillez entrer un nombre valide et positif.");
                Console.WriteLine("-1");
                return;
            }
        }
        else
        {
            if (!int.TryParse(args[0], out nombreDonne) || nombreDonne < 0)
            {
                Console.WriteLine("Veuillez entrer un nombre valide et positif.");
                Console.WriteLine("-1");
                return;
            }
        }

        int nombrePremierSuivant = TrouverNombrePremierSuivant(nombreDonne);
        Console.WriteLine($"Le premier nombre premier supérieur à {nombreDonne} est : {nombrePremierSuivant}");
    }

    static bool EstPremier(int nombre)
    {
        if (nombre <= 1)
            return false;
        for (int i = 2; i <= Math.Sqrt(nombre); i++) // for (int i = 2; i <= nombre; i++) à tester!
        {
            if (nombre % i == 0)
                return false;
        }
        return true;
    }

    static int TrouverNombrePremierSuivant(int nombre)
    {
        int nombreSuivant = nombre + 1;
        while (true)
        {
            if (EstPremier(nombreSuivant))
                return nombreSuivant;
            nombreSuivant++;
        }
    }
}