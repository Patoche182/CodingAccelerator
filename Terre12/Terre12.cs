/* 12 - 12 to 24 - 12

Créez un programme qui transforme une heure affichée en format 12h en une heure affichée au format 24h.
Exemples d’utilisation :
    $> ruby exo.rb 11:40PM
    23:40

Attention : midi et minuit.
*/

class Terre12
{
    static void Main(string[] args)
    {
        Console.WriteLine("==========-==========-==========-==========-==========");
        Console.WriteLine("Bonjour ! \nBienvenue dans ce programme.");
        Console.WriteLine("Cette console transforme une heure affichée en format 12h en une heure affichée en format 24h.");
        Console.WriteLine("==========-==========-==========-==========-==========");
        string input;
        do
        {
            Console.Write("Entrez l'heure au format 12h (HH:mm) : ");
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
        } while (true);
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