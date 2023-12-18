// 01 - NOM DU PROGRAMME - 01

//Créez un programme qui affiche son nom de fichier.
//Exemples d’utilisation :
//$> node exo.js
//exo.js
//$> node crevette.js
//crevette.js

class Terre01
{
    static void Main()
    {
        Console.WriteLine($"Le nom du programme est :  {AppDomain.CurrentDomain.FriendlyName}");
        Console.ReadLine();

    }
}