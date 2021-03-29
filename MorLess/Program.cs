using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MorLess
{
    class Program
    {
        static void Main(string[] args)
        {
            /*Console.WriteLine("Comment vous appelez vous ?");
            string username = Console.ReadLine();
            Console.WriteLine(Environment.NewLine);*/
            TextCenter("JEU DU PLUS OU DU MOINS");
            Console.WriteLine(Environment.NewLine);
            Console.WriteLine(Time() + Environment.NewLine + "Bienvenue dans ce jeu \"Du plus ou du moins\" !");
            Console.WriteLine(Environment.NewLine);
            Console.WriteLine("Les consignes sont simples. Vous devez trouver le nombre auquel je pense (compris entre 0 et 100 exclus)." + Environment.NewLine + "Je vous dirais si le nombre que vous avez mentionné est supérieur ou inférieur au nombre à trouver." + Environment.NewLine + "Si vous l'avez trouvé, alors bravo. :)");
            Console.WriteLine(Environment.NewLine);
            int w = 0;
            bool wouldplay = true;
            if (w == 0)
            {
                Console.WriteLine("Alors, vous êtes prêt(e) ? (O/N)");
                ConsoleKeyInfo avis = Console.ReadKey(true);
                if (avis.Key == ConsoleKey.O)
                {
                    Console.WriteLine("Eh bien allons-y !");
                }
                else
                {
                    Console.WriteLine("Prêt ou pas, on y va quand même !");
                }
                Console.WriteLine(Environment.NewLine);
            }
            int highscore = 999999999;

            // Jeu
            while (wouldplay)
            {
                int ValueFound = new Random().Next(0, 100);

                int i = 1;
                int number;
                bool NumberFake = true;
                while (NumberFake)
                {
                    Console.WriteLine("Entrez un nombre (entre 0 et 100 exclus).");
                    string UserNumber = Console.ReadLine();
                    if (int.TryParse(UserNumber, out number))
                    {
                        NumberFake = false;
                        if (number < 100 && number >= 0)
                        {
                            if (number == ValueFound)
                            {
                                Console.WriteLine(Environment.NewLine);
                                Console.WriteLine("Bravo ! Vous avez trouvé le nombre qui est bel est bien " + number + " !");
                                if (i == 1)
                                    Console.WriteLine("Vous avez réussi en " + i + " coup. Excellent !");
                                else
                                    Console.WriteLine("Vous avez réussi en " + i + " coups.");
                                if (i < highscore)
                                {
                                    highscore = i;
                                    Console.WriteLine("Bien joué ! vous venez d'établir un nouveau record !");
                                }
                                Console.WriteLine(Environment.NewLine);
                                Console.WriteLine("Voulez-vous rejouer pour battre le record de " + highscore + " ? (O/N)");
                                ConsoleKeyInfo avis = Console.ReadKey(true);
                                if (avis.Key == ConsoleKey.O)
                                {
                                    Console.WriteLine("Super !");
                                    Console.WriteLine(Environment.NewLine);
                                }
                                else
                                {
                                    wouldplay = false;
                                }
                            }
                            else if (number < ValueFound)
                            {
                                Console.WriteLine("Presque ! Votre nombre est plus petit ..." + Environment.NewLine);
                                i++;
                                NumberFake = true;
                            }
                            else if (number > ValueFound)
                            {
                                Console.WriteLine("Presque ! Votre nombre est plus grand ..." + Environment.NewLine);
                                i++;
                                NumberFake = true;
                            }
                        }
                        else
                        {
                            Console.WriteLine("Désolé, mais votre nombre n'est pas compris entre 0 et 100 exclus. Réessayez !" + Environment.NewLine);
                            NumberFake = true;
                        }
                    }
                    else
                    {
                        NumberFake = true;
                        Console.WriteLine("Désolé, mais la valeur saisie est incorrecte. Réessayez !" + Environment.NewLine);
                    }
                }
            }
        }

        static string Time()
        {
            if (DateTime.Now.Hour > 0 && DateTime.Now.Hour < 12)
            {
                string goodmorning = "Bonjour chère joueur(se) !";
                return goodmorning;
            }
            else
            {
                string goodafternoon = "Bonsoir chère joueur(se) !";
                return goodafternoon;
            }
        }

        static void TextCenter(string text)
        {
            int SpaceNb = (Console.WindowWidth - text.Length) / 2;
            Console.SetCursorPosition(SpaceNb, Console.CursorTop);
            Console.WriteLine(text);
        }
    }
}
