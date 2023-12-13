//Nom du programme
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
        string lettreAlphabet = "ABCDEFGHIJKLMNOPQRSTUVWXYZ";
        foreach (char lettre in lettreAlphabet)
        {
            Console.Write(lettre.ToString().ToLower());
        }
        Console.WriteLine();
    }
}