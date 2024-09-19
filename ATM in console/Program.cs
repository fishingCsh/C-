using System;

namespace ATM_in_console
{
    class Program
    {
        static void Main(string[] args)
        {
            int PIN = 5201;
            int myPIN;
            int wybór;
            double stan_konta;
            string odbiorca_kasy;

            logowanie:
            Console.WriteLine("\nWitaj w naszym banku!!!\n");
            Console.Write("Podaj swój PIN: ");
            myPIN = int.Parse(Console.ReadLine());

            if (PIN == myPIN)
            {
                Console.WriteLine("\nWitaj użytkowniku!!!");
                Console.WriteLine("Ile aktualnie posiadasz pieniędzy?\n");
                Console.Write("Twój aktualny stan konta: ");
                stan_konta = double.Parse(Console.ReadLine());
            wybór:
                Console.WriteLine("\nCo chcesz zrobić?\n");

                Console.WriteLine("1. Wypłata");
                Console.WriteLine("2. Wpłata");
                Console.WriteLine("3. Sprawdź stan konta");
                Console.WriteLine("4. Przelew\n");

                wybór = int.Parse(Console.ReadLine());
                switch (wybór)
                {
                    case 1:
                        Console.Write("\nIle pieniędzy chcesz wypłacić?\nPodaj ilość: ");
                        int wypłata = int.Parse(Console.ReadLine());
                        Console.WriteLine("\nTwój stan konta po wypłacie: " + (stan_konta - wypłata));
                        break;

                    case 2:
                        Console.Write("\nIle pieniędzy chcesz wpłacić?\nPodaj ilość: ");
                        int wpłata = int.Parse(Console.ReadLine());
                        Console.WriteLine("\nTwój stan konta po wpłacie: " + (stan_konta + wpłata));
                        break;

                    case 3:
                        Console.WriteLine("\nTwój aktualny stan konta wynosi: " + stan_konta);
                        break;

                    case 4:
                        Console.WriteLine("\nDo kogo i ile pieniędzy chcesz wysłać?\nPodaj imię i nazwisko odbiorcy oraz ilość wysłanych pieniędzy.");
                        Console.Write("\nOdbiorca: ");
                        odbiorca_kasy = Console.ReadLine();
                        Console.Write("\nIlość wysłanych pieniędzy: ");
                        double przelew = double.Parse(Console.ReadLine());
                        if (odbiorca_kasy == "Ja")
                        {
                            Console.WriteLine("\nTwój stan konta po przelewie: " + stan_konta);
                        }
                        else
                        {
                            Console.WriteLine("\nTwój stan konta po przelewie: " + (stan_konta - przelew));
                        }
                        break;
                }

                Console.WriteLine("\nCo teraz chcesz zrobić?\n");
                Console.WriteLine("1. Powrót do wyboru");
                Console.WriteLine("2. Wyjmij kartę\n");

                int wybór_2 = int.Parse(Console.ReadLine());
                switch (wybór_2)
                {
                    case 1:
                        goto wybór;

                    case 2:
                        Environment.Exit(0);
                        break;
                }
            }
            else
            {
                Console.WriteLine("\nNiepoprawny PIN!!!\n");
                Console.WriteLine("1. Sprubój ponownie");
                Console.WriteLine("2. Wyjmij kartę");

                int wybór_2 = int.Parse(Console.ReadLine());
                switch (wybór_2)
                {
                    case 1:
                        goto logowanie;

                    case 2:
                        Environment.Exit(0);
                        break;
                }
            }
        }
    }
}