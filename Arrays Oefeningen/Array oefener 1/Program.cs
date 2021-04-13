using System;

namespace Array_oefener_1
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] array = new int[10];

            Console.WriteLine("Voer 10 getallen in:");
            array = ArrayOpvullen(array);
            int som = BerekenSom(array);
            ToonSom(som);
            ToonGemiddelde(som, array.Length);
            ToonGrootste(array);

            Console.WriteLine($"\nVoer een getal in:");
            int getal = UserInput();
            BerekenGroter(getal, array);
        }

        private static void BerekenGroter(int getal, int[] array)
        {
            bool groterBestaat = false;

            Console.WriteLine("\nGetallen in de reeks die groter of gelijk zijn:");
            for(int i = 0; i < array.Length; i++)
            {
                if (getal <= array[i])
                {
                    Console.Write($"{array[i]}, ");
                    groterBestaat = true;
                }
            }
            if (!groterBestaat)
            {
                Console.WriteLine($"Niets is groter.");
            }
        }

        private static void ToonGrootste(int[] array)
        {
            Array.Sort(array);
            Console.WriteLine($"Het grootste getal in de reeks is: {array[^1]}");
        }

        private static int BerekenSom(int[] array)
        {
            int som = 0;
            for (int i = 0; i < array.Length; i++)
            {
                som += array[i];
            }
            return som;
        }

        private static void ToonGemiddelde(int som, int lengte)
        {
            Console.WriteLine($"Het gemiddelde van alle getallen is : {som / lengte}");
        }

        private static void ToonSom(int som)
        {
            Console.WriteLine($"\nDe som van alle getallen is : {som}");
        }

        private static int[] ArrayOpvullen(int[] array)
        {
            for (int i = 0; i < array.Length; i++)
            {
                array[i] = UserInput();
            }
            return array;
        }

        private static int UserInput()
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
