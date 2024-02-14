/* 01 - NOM DU PROGRAMME - 01

Cr�ez un programme qui affiche son nom de fichier.
Exemples d�utilisation :
    $> node exo.js
    exo.js
    $> node crevette.js
    crevette.js

|||||||||||||||||||||||| Objectif : apprendre comment r�cup�rer le chemin de la localisation d'un fichier et le formater (en utilisant Assembly.Get) ||||||||||||||||||||||||
*/

using System;
using System.Reflection;

class Terre01
{
    static void Main(string[] args)
    {
        string cheminExecutable = Assembly.GetExecutingAssembly().Location;     //Assembly.GetExecutingAssembly().Location r�cup�re le chemin d'acc�s complet du fichier ex�cutable (.exe) de l'application en cours d'ex�cution.
        string cheminSource = Path.ChangeExtension(cheminExecutable, ".cs");    //Path.ChangeExtension(cheminExecutable, ".cs") modifie l'extension du chemin r�cup�r� pour obtenir le chemin d'acc�s complet du fichier source(.cs) correspondant � l'ex�cutable.
        string fichierSource = Path.GetFileName(cheminSource);                  //Path.GetFileName(cheminSource) extrait le nom du fichier source � partir du chemin complet du fichier source.
        Console.WriteLine(fichierSource);                                       //Console.WriteLine(fichierSource) affiche le nom du fichier source sur la console.
    }
}

// Methode 0:
//    string chemin = Process.GetCurrentProcess().MainModule.FileName;  //Obtenir le chemin d'acc�s complet du programme en cours d'ex�cution
//    string fichier = System.IO.Path.GetFileName(chemin);              //Extraire le nom du fichier � partir du chemin complet
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
//    // V�rifier si des arguments ont �t� pass�s en ligne de commande
//    if (args.Length > 0)
//    {
//        // Si oui, afficher le nom du premier fichier pass� en argument
//        string fichier = System.IO.Path.GetFileName(args[0]);
//        Console.WriteLine(fichier);
//    }
//    else
//    {
//        // Si aucun argument n'est pass�, afficher un message d'erreur
//        Console.WriteLine("Aucun fichier sp�cifi� en argument.");
//    }