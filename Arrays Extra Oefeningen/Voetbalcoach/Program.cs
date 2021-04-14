using System;

namespace Voetbalcoach
{
    class Program
    {
        static void Main(string[] args)
        {
            int[,] acties = new int[12, 2];

            DataInput(acties);
            PrintResult(acties);
        }

        private static void DataInput(int[,] acties)
        {
            int rugnummer;

            do
            {
                rugnummer = InputRugnummer();

                if (rugnummer != 99 && rugnummer > 0 && rugnummer <= 12)
                {
                    int actieKeuze = InputActieKeuze();
                    acties[rugnummer - 1, actieKeuze] = InputAantalActies(actieKeuze);
                }
            } while (rugnummer != 99);
        }

        private static void PrintResult(int[,] acties)
        {
            Console.Clear();
            Console.WriteLine("Rugnummer\tGoede\tSlechte\t\tVerschil");

            int[] resultaat = new int[12];
            int indexHoogsteResultaat = 0;
            int indexKleinsteResultaat = 0;
            int indexGemiddelde = 0;

            for (int i = 0; i <= acties.GetUpperBound(0); i++)
            {
                resultaat[i] = acties[i, 0] - acties[i, 1];
                Console.Write($"{i + 1}\t\t{acties[i, 0]}\t{acties[i, 1]}\t\t{resultaat[i]}\n");

                if (resultaat[i] > resultaat[indexHoogsteResultaat])
                {
                    indexHoogsteResultaat = i;
                }
                if (resultaat[i] < resultaat[indexKleinsteResultaat])
                {
                    indexKleinsteResultaat = i;
                }
                if ((Math.Abs(resultaat[i]) < Math.Abs(resultaat[indexGemiddelde])) && acties[i, 0] != 0 && acties[i, 1] != 0)
                {
                    indexGemiddelde = i;
                }
            }

            Console.WriteLine($"\nMeest performante speler: {indexHoogsteResultaat + 1}");
            Console.WriteLine($"\nMinst performante speler: {indexKleinsteResultaat + 1}");
            Console.WriteLine($"\nMeest gemiddelde speler: {indexGemiddelde + 1}");
        }

        private static int InputAantalActies(int actieKeuze)
        {
            switch (actieKeuze)
            {
                case 0:
                    Console.WriteLine("Voer het aantal goede acties in:");
                    break;
                case 1:
                    Console.WriteLine("Voer het aantal slechte acties in:");
                    break;
            }

            return IntUserInput();
        }

        private static int InputActieKeuze()
        {
            string actieKeuze;

            do
            {
                Console.WriteLine("Welke actie wil je invoeren? (a = goede acties, b = slechte acties)");
                actieKeuze = Console.ReadLine().ToLower();
            } while (actieKeuze != "a" && actieKeuze != "b");

            if (actieKeuze == "a")
            {
                return 0;
            }
            else
            {
                return 1;
            }
        }

        private static int InputRugnummer()
        {
            int rugnummer;

            Console.Clear();
            Console.WriteLine("Voer een rugnummer in (99 om te stoppen):");
            rugnummer = IntUserInput();

            return rugnummer;
        }

        private static int IntUserInput()
        {
            bool validInput;
            int invoer;
            do
            {
                validInput = int.TryParse(Console.ReadLine(), out invoer);
            } while (!validInput);

            return invoer;
        }
    }
}
