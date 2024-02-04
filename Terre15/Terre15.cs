/* 15 - Terre : ok - 15

Créez un programme qui célèbre votre victoire.
Exemples d’utilisation :
    $> ruby exo.rb
    J’ai terminé l’Épreuve de la Terre et c’était [].
    $>

Note : [] est à remplacer par un adjectif de votre choix (facile ?)
*/




class Terre15
{
    static void Main()
    {
        Console.WriteLine("J'ai terminé l'Epreuve de la Terre et c'était franchement hard !");
        Console.WriteLine("==========-==========-==========-==========-==========");
        Console.ReadKey();
    }
}

Créez un programme qui affiche toutes les différentes combinaisons possibles de trois chiffres dans l’ordre croissant, dans l’ordre croissant. La répétition est volontaire.


Exemples d’utilisation :
$> python exo.py
012, 013, 014, 015, 016, 017, 018, 019, 023, 024, ... , 789
$>

987 n’est pas là parce que 789 est présent.

020 n’est pas là parce que 0 apparaît deux fois.

021 n’est pas là parce que 012 est présent.

000 n’est pas là parce que cette combinaison ne comporte pas exclusivement des chiffres différents les uns des autres.
