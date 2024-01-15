/* 02 - AFFICHEUR D'ARGUMENTS - 02

Créez un programme qui affiche les arguments qu’il reçoit ligne par ligne, peu importe le nombre d’arguments.
Exemples d’utilisation :
    $> ruby exo.rb je suis solide !
    je
    suis
    solide
    !
*/

class Terre02
{
    class Program
    {
        static void Main()
        {
            Console.WriteLine("==========-==========-==========-==========-==========");
            Console.WriteLine("Bonjour ! \nBienvenue dans ce programme. \nCette console affiche les arguments reçus ligne par ligne.");
            Console.WriteLine("==========-==========-==========-==========-==========");

            //// Methode 1:

            //            string[] args = {"Je s'appelle Groot !", "Je suis Patrice...", "\\m/_Children_Of_Bodom COB"};
            //            GetArgs(args);
            //        }

            //        static void GetArgs(string[] args)
            //        {
            //            for (int i = 0; i < args.Length; i++)
            //            {
            //                string[] splitArgs = args[i].Split(' ');

            //                for (int j = 0; j < splitArgs.Length; j++)
            //                {
            //                    Console.WriteLine(splitArgs[j]);
            //                }
            //            }
            //            Console.WriteLine("---------- ---------- ----------");
            //            Console.WriteLine();
            //        }
            //    }
            //}

            // Methode 2:

            do
            {
                Console.WriteLine("Veuillez entrer une phrase, ex : je suis solide ! (ou 'exit' pour quitter) :");
                string input = Console.ReadLine();
                if (input.ToLower() == "exit")
                    break;

                string[] phraseInput = { input };
                Console.WriteLine("---------- ---------- ---------- ----------");
                ConvertirPhrase(phraseInput);
                Console.WriteLine("---------- ---------- ---------- ----------");
            } while (true);
        }

        static void ConvertirPhrase(string[] phraseInput)
        {
            for (int mot = 0; mot < phraseInput.Length; mot++)
            {
                // Utilisez la méthode Split pour diviser la chaîne par les espaces
                string[] splitPhraseInput = phraseInput[mot].Split(' ');

                // Affichez chaque élément de la chaîne divisée ligne par ligne
                for (int mots = 0; mots < splitPhraseInput.Length; mots++)
                {
                    Console.WriteLine(splitPhraseInput[mots].Trim()); // Utilisez Trim pour supprimer les espaces autour des mots
                }
            }
            Console.WriteLine();
        }
    }
}