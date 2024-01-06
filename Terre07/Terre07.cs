using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

class Terre07
{
    static void Main()
    {
        string chaine = "Je s'apelle Groot 22 !";
        Console.WriteLine(Reverse(chaine));
    }
    static string Reverse(string chaine)
    {
        string inverse = "";
        for (int i = chaine.Length - 1; i >= 0; i--)
        {
            // écrire les char un à un dans inverse
            inverse += chaine[i];
        }
        return inverse;
    }
}