/* 04 - PAIR OU IMPAIR - 04

Cr�ez un programme qui permet de d�terminer si l�argument donn� est un entier pair ou impair..
Exemples d�utilisation :
    $> ruby exo.rb 2
    pair
    $> ruby exo.rb 5
    impair
    $> ruby exo.rb Bonjour
    Tu ne me la mettras pas � l�envers.
    $> ruby exo.rb
    Tu ne me la mettras pas � l�envers.
Attention : g�rez aussi les entiers n�gatifs.
Fonctions interdites: 
-En Ruby: even? et odd ?
*/

class Terre04
{
    static void Main()
    {
        do
        {
            Console.WriteLine("Donne un chiffre:");
            string response = Console.ReadLine();
            int x;
            if (int.TryParse(response, out x) && int.IsPositive(x))
            {
                Console.WriteLine(PairOuImpair(x));
            }
            else
            {
                Console.WriteLine("Tu ne me la mettras pas � l'envers.\nIl me faut un chiffre positif !");
            }
        } while (true);
    }

    static string PairOuImpair(int nombre)
    {
        if (nombre % 2 == 0)
        {
            return "Pair !";
        }
        else
        {
            return "Impair !";
        }
    }
}