/* 11 - 24 to 12 - 11

Créez un programme qui transforme une heure affichée en format 24h en une heure affichée en format 12h.
Exemples d’utilisation :
    $> ruby exo.rb 23:40
    11:40PM

Attention : midi et minuit.
*/

class Terre11
{
    static void Main(string[] args)
    {
        Console.WriteLine("==========-==========-==========-==========-==========");
        Console.WriteLine("Bonjour ! \nBienvenue dans ce programme.");
        Console.WriteLine("Cette console transforme une heure affichée en format 24h en une heure affichée en format 12h.");
        Console.WriteLine("==========-==========-==========-==========-==========");
        string input;
        do
        {
            Console.Write("Entrez l'heure au format 24h (HH:mm) : ");
            input = Console.ReadLine();

            if (DateTime.TryParseExact(input, "HH:mm", null, System.Globalization.DateTimeStyles.None, out DateTime time))
            {
                string formattedTime = ConvertTo12HourFormat(time);
                Console.WriteLine("Heure en format 12h : " + formattedTime);
            }
            else
            {
                Console.WriteLine("Format d'heure incorrect. Assurez-vous d'utiliser le format HH:mm.");
            }

            Console.Write("Voulez-vous continuer? (O/N) : ");
        } while (Console.ReadLine().ToUpper() == "O");
    }

    static string ConvertTo12HourFormat(DateTime time)
    {
        string period = "AM";
        if (time.Hour >= 12)
        {
            period = "PM";
        }

        int hour12 = time.Hour > 12 ? time.Hour - 12 : time.Hour;
        if (hour12 == 0)
        {
            hour12 = 12; // Pour 00:00 en format 12h, nous affichons 12 AM.
        }

        return $"{hour12:D2}:{time.Minute:D2} {period}";
    }
}

/*
class Program
{
    static void Main(string[] args)
    {
        Console.Write("Entrez l'heure au format 24h (HH:mm) : ");
        string input = Console.ReadLine();

        if (DateTime.TryParseExact(input, "HH:mm", null, System.Globalization.DateTimeStyles.None, out DateTime time))
        {
            Console.WriteLine("Heure en format 12h : " + ConvertTo12HourFormat(time));
        }
        else
        {
            Console.WriteLine("Format d'heure incorrect. Assurez-vous d'utiliser le format HH:mm.");
        }
    }

    static string ConvertTo12HourFormat(DateTime time)
    {
        return time.ToString("hh:mm tt");
    }
}
 */


//----------------------------------

//class Program
//{
//    static void Main(string[] args)
//    {
//        string input;
//        do
//        {
//            Console.Write("Entrez l'heure au format 24h (HH:mm) : ");
//            input = Console.ReadLine();

//            if (DateTime.TryParseExact(input, "HH:mm", null, System.Globalization.DateTimeStyles.None, out DateTime time))
//            {
//                Console.WriteLine("Heure en format 12h : " + ConvertTo12HourFormat(time));
//            }
//            else
//            {
//                Console.WriteLine("Format d'heure incorrect. Assurez-vous d'utiliser le format HH:mm.");
//            }

//            Console.Write("Voulez-vous continuer? (O/N) : ");
//        } while (Console.ReadLine().ToUpper() == "O");
//    }

//    static string ConvertTo12HourFormat(DateTime time)
//    {
//        return time.ToString("hh:mm tt");
//    }
//}