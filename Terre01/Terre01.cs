/* 01 - NOM DU PROGRAMME - 01

Créez un programme qui affiche son nom de fichier.
Exemples d’utilisation :
    $> node exo.js
    exo.js
    $> node crevette.js
    crevette.js
*/

using System.IO.Enumeration;

class Terre01
{
    static void Main()

    // Methode 1:
    //{
    //    Console.WriteLine($"Le nom du programme est : {AppDomain.CurrentDomain.FriendlyName}" + ".cs");
    //    Console.WriteLine("----------");
    //}

    // Methode 2:
    {
        string filePath = @"C:\Users\patri\source\repos\CodingAccelerator\Terre01.cs";
        string fileName = Path.GetFileName(filePath);
        Console.WriteLine("Nom du fichier : " + fileName);
    }
}