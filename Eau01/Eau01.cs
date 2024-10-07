/*     01 - Combinaisons de 2 nombres - 01

Créez un programme qui affiche toutes les différentes combinaisons de deux nombre entre 00 et 99 dans l’ordre croissant.

Exemples d’utilisation :
$> python exo.py
00 01, 00 02, 00 03, 00 04, ... , 00 99, 01 02, ... , 97 99, 98 99
$>
*/

class Eau01
{
    static void Main()
    {
        Console.WriteLine("==========-==========-==========-==========-==========");
        Console.WriteLine("==========-==========-==========-==========-==========");
        Console.WriteLine("Epreuve de l'Eau01 !");
        Console.WriteLine("Epreuve de l'Eau01 !");
        Console.WriteLine("==========-==========-==========-==========-==========");
        Console.WriteLine("==========-==========-==========-==========-==========");

        for (int first = 0; first < 100; first++)
        {
            for (int second = 0; second < 100; second++)
            {
                if (second > first) // si le 2nd chiffre est + grand que le 1er je l'affiche
                    {
                        Console.WriteLine($"{first.ToString("00")} " + $"{second.ToString("00")}");
                    }
            }
        }
    }
}