/* 05 - DIVISIONS - 05

Cr�ez un programme qui affiche le r�sultat et le reste d�une division entre deux nombres.
Exemples d�utilisation :
    $> python exo.py 5 2
    r�sultat: 2
    reste: 1
    $> python exo.py 10 0
    erreur.
    $> python exo.py 3 5
    erreur.
*/
// Va faloir le commencer � m'en donn� !

class Terre05
{
    // exemple 5/2 = 2 : % = 1

    static void Main()
    {
        int a = 10;
        int b = 3;
        Console.WriteLine(Division(a, b));
        Console.WriteLine(Reste(a, b));
    }

    static int Division(int a, int b)
    {
        int resultat = a / b;
        return resultat;
    }

    static int Reste(int a, int b)
    {
        int reste = a % b;
        return reste;
    }

    //static (int, int) Reste(int a, int b)
    //{
    //    int reste = a % b;
    //    return (resultat, reste);
    //}
}