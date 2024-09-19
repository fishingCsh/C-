using System;
using System.Threading;

namespace KalkulatorFigur.ConsoleApp
{
    class Program
    {
        static void Main(string[] args)
        {
            Start:
            Console.WriteLine("Witaj użytkowniku!!!\n");

            Console.WriteLine("Oto kalkulator wzorów na pola figur.\nMożesz tu się ich nauczyć lub obliczać nimi powierzchnię wielu kształtów!!!\n\n\n\n");




            Console.WriteLine("Kliknij spację aby przejść dalej...");
            ConsoleKeyInfo spacja = Console.ReadKey();
            if (spacja.Key == ConsoleKey.Spacebar)
            {
                Console.Clear();
            }
            else
            {
                Console.WriteLine("\nZły klawisz");
                Thread.Sleep(1500);
                Console.Clear();
                goto Start;
            }

            switch1:

            Console.Clear();

            Console.WriteLine("1. Pole kwadratu" +
                "\n2. Pole prostokąta" +
                "\n3. Pole równoległoboku" +
                "\n4. Pole trapezu" +
                "\n5. Pole trójkąta" +
                "\n6. Pole tr. równobocznego" +
                "\n7. Pole koła" +
                "\n8. Wylosuj mi wzór do nauki" +
                "\n9. Zamknij program\n");
            Console.Write("Wybierz opcję która cię interesuje podając jej numer: "); int switch1 = int.Parse(Console.ReadLine());
            if(switch1 > 10 || switch1 < 1)
            {
                Console.WriteLine("NIE MA TAKIEJ OPCJI!!!\n");
                Console.Write("Spróbuj poniwnie za... "); Thread.Sleep(1000);
                Console.Write("3... "); Thread.Sleep(1000);
                Console.Write("2... "); Thread.Sleep(1000);
                Console.Write("1..."); Thread.Sleep(1000);
                Console.Clear();
                goto switch1;
            }

            Console.Clear();

            float a, b, h, r;
            switch (switch1)
            {
                case 1:
                    Console.WriteLine("Pole kwadratu jest równe a²\n");
                    Console.Write("Podaj długość boku a: "); a = float.Parse(Console.ReadLine());
                    Console.Write("Obliczam "); Thread.Sleep(500);
                    Console.Write(". "); Thread.Sleep(500);
                    Console.Write(". "); Thread.Sleep(500);
                    Console.Write(". "); Thread.Sleep(500);
                    Console.WriteLine($"\nPole tego kwadratu wynosi {Math.Pow(a, 2):F2} :)");
                    break;

                case 2:
                    Console.WriteLine("Pole prostokąta jest równe a*b\n");
                    Console.Write("Podaj długość boku a: "); a = float.Parse(Console.ReadLine());
                    Console.Write("Podaj długość boku b: "); b = float.Parse(Console.ReadLine());
                    Console.Write("Obliczam "); Thread.Sleep(500);
                    Console.Write(". "); Thread.Sleep(500);
                    Console.Write(". "); Thread.Sleep(500);
                    Console.Write(". "); Thread.Sleep(500);
                    Console.WriteLine($"\nPole tego prostokąta wynosi {a * b:F2} :)");
                    break;

                case 3:
                    Console.WriteLine("Pole równoległoboku i rombu jest równe bok a*h\n");
                    Console.Write("Podaj długość boku a: "); a = float.Parse(Console.ReadLine());
                    Console.Write("Podaj długość wysokości h: "); h = float.Parse(Console.ReadLine());
                    Console.Write("Obliczam "); Thread.Sleep(500);
                    Console.Write(". "); Thread.Sleep(500);
                    Console.Write(". "); Thread.Sleep(500);
                    Console.Write(". "); Thread.Sleep(500);
                    Console.WriteLine($"\nPole tego równoległoboku wynosi {a * h:F2} :)");
                    break;

                case 4:
                    Console.WriteLine("Wzór na pole trapezu to:\n");
                    Console.WriteLine("(a+b)*h");
                    Console.WriteLine("-------");
                    Console.WriteLine("   2   ");
                    Console.Write("\nPodaj długość boku a: "); a = float.Parse(Console.ReadLine());
                    Console.Write("Podaj długość boku b: "); b = float.Parse(Console.ReadLine());
                    Console.Write("Podaj długość wysokości h: "); h = float.Parse(Console.ReadLine());
                    Console.Write("Obliczam "); Thread.Sleep(500);
                    Console.Write(". "); Thread.Sleep(500);
                    Console.Write(". "); Thread.Sleep(500);
                    Console.Write(". "); Thread.Sleep(500);
                    Console.WriteLine($"\nPole tego trapezu wynosi {((a+b)*h)/2:F2} :)");
                    break;

                case 5:
                    Console.WriteLine("Pole trójkąta jest równe ½*a*h\n");
                    Console.Write("Podaj długość boku a: "); a = float.Parse(Console.ReadLine());
                    Console.Write("Podaj długość wysokości h: "); h = float.Parse(Console.ReadLine());
                    Console.Write("Obliczam "); Thread.Sleep(500);
                    Console.Write(". "); Thread.Sleep(500);
                    Console.Write(". "); Thread.Sleep(500);
                    Console.Write(". "); Thread.Sleep(500);
                    Console.WriteLine($"\nPole tego trójkąta wynosi {0.5 * a * h:F2} :)");
                    break;

                case 6:
                    Console.WriteLine("Wzór na pole tr. równobocznego to:");
                    Console.WriteLine("a²*√3");
                    Console.WriteLine("-----");
                    Console.WriteLine("  2  ");
                    Console.Write("\nPodaj długość boku a: "); a = float.Parse(Console.ReadLine());
                    Console.Write("Obliczam "); Thread.Sleep(500);
                    Console.Write(". "); Thread.Sleep(500);
                    Console.Write(". "); Thread.Sleep(500);
                    Console.Write(". "); Thread.Sleep(500);
                    Console.WriteLine($"\nPole tego tr. równobocznego wynosi {(Math.Pow(a, 2) * Math.Sqrt(3))/4:F2} :)");
                    break;

                case 7:
                    Console.WriteLine("Pole koła jest równe π*r²\n");
                    Console.Write("Podaj długość promienia r: "); r = float.Parse(Console.ReadLine());
                    Console.Write("Obliczam "); Thread.Sleep(500);
                    Console.Write(". "); Thread.Sleep(500);
                    Console.Write(". "); Thread.Sleep(500);
                    Console.Write(". "); Thread.Sleep(500);
                    Console.WriteLine($"\nPole tego koła wynosi {Math.PI * Math.Pow(r, 2):F2} :)");
                    break;

                case 8:
                    int rand;
                    Random random = new Random();
                    rand = random.Next(1, 8);

                    switch (rand)
                    {
                        case 1:
                            Console.WriteLine("Wzór na pole kwadratu to a² :)");
                            break;

                        case 2:
                            Console.WriteLine("Wzór na pole prostokąta to a*b :)");
                            break;

                        case 3:
                            Console.WriteLine("Wzór na pole równoległoboku oraz rombu to a*h :)");
                            break;

                        case 4:
                            Console.WriteLine("Wzór na pole trapezu to:\n");
                            Console.WriteLine("(a+b)*h");
                            Console.WriteLine("-------");
                            Console.WriteLine("   2   ");
                            break;

                        case 5:
                            Console.WriteLine("Wzór na pole trójkąta to ½*a*h :)");
                            break;

                        case 6:
                            Console.WriteLine("Wzór na pole tr. równobocznego to:");
                            Console.WriteLine("a²*√3");
                            Console.WriteLine("-----");
                            Console.WriteLine("  2  ");
                            break;

                        case 7:
                            Console.WriteLine("Wzór na pole koła to π*r² :)");
                            break;

                    }
                    break;

                case 9:
                    Key:
                    Console.WriteLine("Czy napewno chcesz wyjsć? (T/N)");
                    ConsoleKeyInfo tn = Console.ReadKey();
                    if(tn.Key != ConsoleKey.T && tn.Key != ConsoleKey.N)
                    {
                        Console.WriteLine("Zły klawisz");
                        Thread.Sleep(1500);
                        Console.Clear();
                        goto Key;
                    }
                    if(tn.Key == ConsoleKey.T)
                    {
                        Environment.Exit(0);
                    }
                    else if(tn.Key == ConsoleKey.N)
                    {
                        goto switch1;
                    }
                    break;
            }

            End:
            Console.WriteLine("Kliknij spację aby wrócić do menu głównego...");
            ConsoleKeyInfo spacja1 = Console.ReadKey();
            if (spacja1.Key == ConsoleKey.Spacebar)
            {
                Console.Clear();
                goto switch1;
            }
            else
            {
                Console.WriteLine("\nZły klawisz");
                Thread.Sleep(1500);
                Console.Clear();
                goto End;
            }
        }
    }
}
