/* 01 - NOM DU PROGRAMME - 01

Créez un programme qui affiche son nom de fichier.
Exemples d’utilisation :
    $> node exo.js
    exo.js
    $> node crevette.js
    crevette.js

|||||||||||||||||||||||| Objectif : apprendre comment récupérer le chemin de la localisation d'un fichier et le formater (en utilisant Assembly.Get) ||||||||||||||||||||||||
*/

using System;
using System.Reflection;

class Terre01
{
    static void Main(string[] args)
    {
        string cheminExecutable = Assembly.GetExecutingAssembly().Location;     //Assembly.GetExecutingAssembly().Location récupère le chemin d'accès complet du fichier exécutable (.exe) de l'application en cours d'exécution.
        string cheminSource = Path.ChangeExtension(cheminExecutable, ".cs");    //Path.ChangeExtension(cheminExecutable, ".cs") modifie l'extension du chemin récupéré pour obtenir le chemin d'accès complet du fichier source(.cs) correspondant à l'exécutable.
        string fichierSource = Path.GetFileName(cheminSource);                  //Path.GetFileName(cheminSource) extrait le nom du fichier source à partir du chemin complet du fichier source.
        Console.WriteLine(fichierSource);                                       //Console.WriteLine(fichierSource) affiche le nom du fichier source sur la console.
    }
}

// Methode 0:
//    string chemin = Process.GetCurrentProcess().MainModule.FileName;  //Obtenir le chemin d'accès complet du programme en cours d'exécution
//    string fichier = System.IO.Path.GetFileName(chemin);              //Extraire le nom du fichier à partir du chemin complet
//    Console.WriteLine(fichier);                                        //Afficher le nom du fichier

// Methode 1:
//    Console.WriteLine($"Le nom du programme est : {AppDomain.CurrentDomain.FriendlyName}" + ".cs");
//    Console.WriteLine("----------");

// Methode 2:
//    string filePath = @"C:\Users\patri\source\repos\CodingAccelerator\Terre01.cs";
//    string fileName = Path.GetFileName(filePath);
//    Console.WriteLine("Nom du fichier : " + fileName);

// Methode 3:
//static void Main(string[] args)
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