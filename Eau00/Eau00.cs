/*     00 - Combinaisons de 3 chiffres - 00

Créez un programme qui affiche toutes les différentes combinaisons possibles de trois chiffres dans l’ordre croissant, dans l’ordre croissant. La répétition est volontaire.

Exemples d’utilisation :
$> python exo.py
012, 013, 014, 015, 016, 017, 018, 019, 023, 024, ... , 789
$>
987 n’est pas là parce que 789 est présent.
020 n’est pas là parce que 0 apparaît deux fois.
021 n’est pas là parce que 012 est présent.
000 n’est pas là parce que cette combinaison ne comporte pas exclusivement des chiffres différents les uns des autres.
*/


class Eau00
{
    static void Main()
    {
        Console.WriteLine("==========-==========-==========-==========-==========");
        Console.WriteLine("Epreuve de l'Eau00 !");
        Console.WriteLine("==========-==========-==========-==========-==========");

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
    }
}