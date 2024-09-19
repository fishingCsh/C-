using System;

namespace papier__kamień__nożyce
{
    class Program
    {
        static void Main(string[] args)
        {
            int wybór;
            int my_score = 0;
            int bot_score = 0;
            int wybór_3;

            start:
            Random los = new Random();
            int bot_los = los.Next(1, 4);
            Console.WriteLine("Witaj w grze ,,Papier, Kamień, Nożyce''!\n");
            while (true)
            {
                Console.WriteLine("wybierz:");
                Console.WriteLine("1. Papier");
                Console.WriteLine("2. Kamień");
                Console.WriteLine("3. Nożyce\n");
                Console.Write("Podaj swój wybór: ");

                wybór = int.Parse(Console.ReadLine());
                if (wybór > 3)
                {
                    Console.WriteLine("Niema takiego wyboru!!!");

                    Console.WriteLine("1. Wybierz ponownie");
                    Console.WriteLine("2. Zakończ grę");

                    wybór_3 = int.Parse(Console.ReadLine());
                    switch (wybór_3)
                    {
                        case 1:
                            goto start;

                        case 2:
                            Environment.Exit(0);
                            break;
                    }
                }


                if (wybór == bot_los)
                {
                    Console.WriteLine("REMIS!!!");
                }
                else if (bot_los == 1 && wybór == 3)
                {
                    Console.WriteLine("BRAWO!!! wygrałeś");
                    Console.WriteLine("Wybrałeś nożyce, a bot papier");
                    my_score++;
                }
                else if (bot_los == 2 && wybór == 1)
                {
                    Console.WriteLine("BRAWO!!! wygrałeś");
                    Console.WriteLine("Wybrałeś papier, a bot kamień");
                    my_score++;
                }
                else if (bot_los == 3 && wybór == 2)
                {
                    Console.WriteLine("BRAWO!!! wygrałeś");
                    Console.WriteLine("Wybrałeś kamień, a bot nożyce");
                    my_score++;
                }

                else if (bot_los == 3 && wybór == 1)
                {
                    Console.WriteLine("Przegrana!!!");
                    Console.WriteLine("Wybrałeś papier, a bot nożyce");
                    bot_score++;
                }
                else if (bot_los == 1 && wybór == 2)
                {
                    Console.WriteLine("Przegrana!!!");
                    Console.WriteLine("Wybrałeś kamień, a bot papier");
                    bot_score++;
                }
                else if (bot_los == 2 && wybór == 3)
                {
                    Console.WriteLine("Przegrana!!!");
                    Console.WriteLine("Wybrałeś nożyce, a bot kamień");
                    bot_score++;
                }

                Console.WriteLine("\nTwój wynik: " + my_score);
                Console.WriteLine("Wynik bota: " + bot_score);
                Console.WriteLine("\n\nCo teraz chcesz zrobić?");
                Console.WriteLine("1. Zagraj ponownie");
                Console.WriteLine("2. Zakończ grę");
                int wybór_2 = int.Parse(Console.ReadLine());
                if (wybór_2 == 1)
                {
                    goto start;
                }
                else if (wybór_2 == 2)
                {
                    Environment.Exit(0);
                }
            }
        }
    }
}
