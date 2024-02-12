/* 01 - NOM DU PROGRAMME - 01

Créez un programme qui affiche son nom de fichier.
Exemples d’utilisation :
    $> node exo.js
    exo.js
    $> node crevette.js
    crevette.js

|||||||||||||||||||||||| Correction : Assembly ou Get IO ||||||||||||||||||||||||
*/


using System.Diagnostics;
using System.Reflection;

class Terre01
{
    static void Main(string[] args)
    {
        // Obtenir le chemin d'accès complet du fichier exécutable (.exe)
        string cheminExecutable = Assembly.GetExecutingAssembly().Location;

        // Obtenir le chemin d'accès complet du fichier source (.cs)
        string cheminSource = Path.ChangeExtension(cheminExecutable, ".cs");

        // Extraire le nom du fichier source à partir du chemin complet
        string fichierSource = Path.GetFileName(cheminSource);

        // Afficher le nom du fichier source
        Console.WriteLine(fichierSource);
    }



    //{
    //    // Obtenir le chemin d'accès complet du programme en cours d'exécution
    //    string chemin = Process.GetCurrentProcess().MainModule.FileName;

    //    // Extraire le nom du fichier à partir du chemin complet
    //    string fichier = System.IO.Path.GetFileName(chemin);

    //    // Afficher le nom du fichier
    //    Console.WriteLine(fichier);
    //}



    //static void Main(string[] args)
    //{
    //    // Vérifier si des arguments ont été passés en ligne de commande
    //    if (args.Length > 0)
    //    {
    //        // Si oui, afficher le nom du premier fichier passé en argument
    //        string fichier = System.IO.Path.GetFileName(args[0]);
    //        Console.WriteLine(fichier);
    //    }
    //    else
    //    {
    //        // Si aucun argument n'est passé, afficher un message d'erreur
    //        Console.WriteLine("Aucun fichier spécifié en argument.");
    //    }
    //}
}

    // Methode 1:
    //{
    //    Console.WriteLine($"Le nom du programme est : {AppDomain.CurrentDomain.FriendlyName}" + ".cs");
    //    Console.WriteLine("----------");
    //}

    // Methode 2:
    //{
    //    string filePath = @"C:\Users\patri\source\repos\CodingAccelerator\Terre01.cs";
    //    string fileName = Path.GetFileName(filePath);
    //    Console.WriteLine("Nom du fichier : " + fileName);
    //}