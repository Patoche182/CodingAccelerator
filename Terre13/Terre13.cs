/* 13 - Trouver la Suisse (lol) - 13

Créez un programme qui prend en paramètre trois entiers et affiche la valeur du milieu.

Exemples d’utilisation :
    $> ruby exo.rb 11 40 34
    34

    $> ruby exo.rb 2 1 3
    2

    $> ruby exo.rb 2 2 2
    erreur.

Fonctions interdites: 
-La fonction sort
*/

Console.WriteLine("==========-==========-==========-==========-==========");
Console.WriteLine("Bonjour ! \nBienvenue dans ce programme.");
Console.WriteLine("Cette console récupère en [Entrée] 3 nombres entier et renvoi en [Sortie] celui du millieu. \nAutrement dit, celui qui à la valeur intermédire.");
Console.WriteLine("==========-==========-==========-==========-==========");

do
{
    Console.WriteLine("Veuillez entrer vos 3 nombres entiers, séparés par un espace (ou 'exit' pour quitter) :");
    string input = Console.ReadLine();

    if (input.ToLower() == "exit") { break; } // ne pas oublier ToLower()

    string[] inputs = input.Split(' ');

    if (inputs.Length != 3)
    {
        Console.WriteLine("Veuillez entrer exactement 3 nombres entiers.");
        continue;
    }
    // On essaie de vérfier que les entrées sont bien convertie en int : ( avec int.TryParse() )
    int a, b, c;
    if (!int.TryParse(inputs[0], out a) || !int.TryParse(inputs[1], out b) || !int.TryParse(inputs[2], out c)) // Si une des conditons est true (si elle echoue quoi) ce If renvoi un message d'erreur.
    {
        Console.WriteLine("Veuillez entrer des nombres entiers valides.");
        continue;
    }

    if ((a < b) && (b < c))
    {
        Console.WriteLine("La valeur intermédiaire est " + b);
    }
    else if ((a < c) && (c < b))
    {
        Console.WriteLine("La valeur intermédiaire est " + c);
    }
    else
    {
        Console.WriteLine("La valeur intermédiaire est " + a);
    }

    Console.WriteLine("----------=----------=----------=----------=----------");

} while (true);



//do
//{
//    Console.WriteLine("Veuillez entrer votre nombres entier 1 sur 3 : (ou 'exit' pour quitter) :");
//    int a = Convert.ToInt32(Console.ReadLine());

//    Console.WriteLine("Veuillez entrer votre nombres entier 2 sur 3 : (ou 'exit' pour quitter) :");
//    int b = Convert.ToInt32(Console.ReadLine());

//    Console.WriteLine("Veuillez entrer votre nombres entier 3 sur 3 : (ou 'exit' pour quitter) :");
//    int c = Convert.ToInt32(Console.ReadLine());

//    if (a || b || c = "exit")
//    {
//        break;
//    }
//    if ((a < b) && (b < c))
//    {
//        Console.WriteLine("La valeur intermédiaire est " + b);
//    }
//    else if ((a < c) && (c < b))
//    {
//        Console.WriteLine("La valeur intermédiaire est " + c);
//    }
//    else
//    {
//        Console.WriteLine("La valeur intermédiaire est " + a);
//    }
//    Console.WriteLine("----------=----------=----------=----------=----------");
//} while (true);
