﻿/*     10 - Index wanted - 10

Créez un programme qui met en majuscule une lettre sur deux d’une chaîne de caractères. Seule les lettres (A-Z, a-z) sont prises en compte.

Exemples d’utilisation :
$> python exo.py “Hello world !”
HeLlO wOrLd !

$> python exo.py 42
error

Afficher error et quitter le programme en cas de problèmes d’arguments.
 */
class Eau10
{
    static void Main(string[] args)
    {
        Console.WriteLine("==========-==========-==========-==========-==========");
        Console.WriteLine("Epreuve de l'Eau10 !");
        Console.WriteLine("==========-==========-==========-==========-==========");

        // Demander à l'utilisateur d'entrer une chaîne de caractères
        Console.WriteLine("Entrez une chaîne de caractères :");
        string input = Console.ReadLine();

        // Convertir chaque caractère de la chaîne
        string result = "";
        for (int i = 0; i < input.Length; i++)
        {
            // Vérifier si le caractère est une lettre
            if (char.IsLetter(input[i]))
            {
                // Si l'index est pair, mettre le caractère en majuscule
                if (i % 2 == 0)
                {
                    result += char.ToUpper(input[i]);
                }
                // Sinon, laisser le caractère tel quel
                else
                {
                    result += input[i];
                }
            }
            else
            {
                // Si le caractère n'est pas une lettre, le laisser tel quel
                result += input[i];
            }
        }

        // Afficher le résultat
        Console.WriteLine("Résultat : " + result);
    }
}
