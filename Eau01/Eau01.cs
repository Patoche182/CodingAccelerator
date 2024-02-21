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
        Console.WriteLine("Epreuve de l'Eau01 !");
        Console.WriteLine("==========-==========-==========-==========-==========");




    }
}

/*
 int centaine = 0;
        for (int i = 0; i < 10; i++)
        {
            int dizaine = 0;
            for (int j = 0; j < 10; j++)
            {
                int unite = 0;
                for (int k = 0; k < 10; k++)
                {
                    if ((unite != dizaine) && (dizaine != centaine) && (unite != centaine) && (unite > dizaine) && (dizaine > centaine))
                    {
                        Console.WriteLine($"{centaine}" + $"{dizaine}" + $"{unite}");
                    }
                    unite = unite + 1;
                }
                dizaine = dizaine + 1;
            }
            centaine = centaine + 1;
        } 
 */
