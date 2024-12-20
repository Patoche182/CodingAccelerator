﻿/*     00 - Combinaisons de 3 chiffres - 00

Créez un programme qui affiche toutes les différentes combinaisons possibles de trois chiffres dans l’ordre croissant, dans l’ordre croissant.
La répétition est volontaire.

Exemples d’utilisation :
$> python exo.py
012, 013, 014, 015, 016, 017, 018, 019, 023, 024, ... , 789
$>
987 n’est pas là parce que 789 est présent.
020 n’est pas là parce que 0 apparaît deux fois.
021 n’est pas là parce que 012 est présent.
000 n’est pas là parce que cette combinaison ne comporte pas exclusivement des chiffres différents les uns des autres.
*/

namespace Eau2 // byHarry
{
    internal class Eau2_00
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello, Eau02!");

            // centaine
            for (int i = 0; i < 10; i++)
            {
                Console.WriteLine(i);

                // dizaine
                for (int j = 0; j < 10; j++)
                {
                    Console.WriteLine(j);

                    // unité
                    for (int k = 0; k < 10; k++)
                    {
                        Console.Write(k);
                    }
                }
            }
        }
    }
}