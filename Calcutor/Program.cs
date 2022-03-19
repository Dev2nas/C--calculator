using System;

namespace Calcutor
{
    class Program
    {
        static void Main(string[] args)
        {
            // Declartion de mes variables
            int nb1 = 0;
            int nb2 = 0;

           bool endApp = false;
            // en tête.
            Console.WriteLine("Welcome to Calculator\r");
            Console.WriteLine("v2\r");
            Console.WriteLine("Welcome to DevNas Calculator\r");
            Console.WriteLine("Auteur:DevNas\r");
            Console.WriteLine("Email:devnas.inc@gmail.com\r");
            Console.WriteLine("GitHub:Deb2Nas\r");
            Console.WriteLine("02:00:00 March 19,2022 \r");
            Console.WriteLine("------------------------\n");

            // nb1 input
            Console.WriteLine("Saissiez votre 1er nombre entier ,puis entrer");
            nb1 = Convert.ToInt32(Console.ReadLine());

            // nb2 input.
            Console.WriteLine("Saissiez votre 2éme nombre entier ,puis entrer");
            nb2 = Convert.ToInt32(Console.ReadLine());

            // Les options.
            Console.WriteLine("Veuillez choisir une option dans ma liste:");
            Console.WriteLine("\t1- ADDITION");
            Console.WriteLine("\t2- SOUSTRATION");
            Console.WriteLine("\t3- MULTIPLICATION");
            Console.WriteLine("\t4- DIVISION");
            Console.WriteLine("\t5- QUITTER");
            Console.Write("Votre reponse? ");

            // Demarage de ma boucle Selon que.
            switch (Console.ReadLine())
            {
                case "1": // si 1
                    Console.WriteLine($"Le resultat de: {nb1} + {nb2} = " + (nb1 + nb2));
                    break;
                case "2": //si 2
                    Console.WriteLine($"Le resultat de: {nb1} - {nb2} = " + (nb1 - nb2));
                    break;
                case "3"://si 3
                    Console.WriteLine($"Le resultat de: {nb1} * {nb2} = " + (nb1 * nb2));
                    break;
                case "4"://si 4
                    if (nb2 != 0)
                    {
                        Console.WriteLine($"Le resultat de: {nb1} / {nb2} = " + (nb1 / nb2));
                    }
                    else
                    {
                        Console.WriteLine($"error d'operateur");
                    }
                    
                    break;
                case "5"://si 5
                    Console.Write("Vous êtes sur de pouvoir quitter?");
                    Console.Write("Press 'n' and Enter to close the app, or press any other key and Enter to continue: ");
                    if (Console.ReadLine() == "n") endApp = true;
                    else
                    {

                    }
                    
                    Console.WriteLine("\n"); // Friendly linespacing.
                    break;
            }
            // Wait for the user to respond before closing.
           
        }
    }
}
