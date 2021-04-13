using System;

namespace Arrays_Extra_Oefeningen
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = System.Text.Encoding.UTF8;

            Console.WriteLine("Geef aantal auto's in:");
            int autos = UserInput();

            int[] uren = new int[autos];
            double[] kosten;
            InputGeefUren(autos);
            kosten = BerekenKosten(uren);
            PrintResult(uren, kosten);
        }

        private static void PrintResult(int[] uren, double[] kosten)
        {
            Console.Clear();
            Console.WriteLine("Auto\tDuur\tKost");
            for (int i = 0; i < uren.Length; i++)
            {
                Console.Write(i + 1);
                Console.SetCursorPosition(8, i + 1);
                Console.Write($"{uren[i]}u");
                Console.SetCursorPosition(16, i + 1);
                Console.Write($"{kosten[i]:C}\n");
            }

            Console.WriteLine("\nTotaal:");
            Console.Write($"{uren.Length}");
            Console.SetCursorPosition(8, Console.CursorTop);
            Console.Write($"{BerekenSomUren(uren)}u");
            Console.SetCursorPosition(16, Console.CursorTop);
            Console.Write($"{BerekenSomKosten(kosten):C}\n");
        }

        private static double BerekenSomKosten(double[] kosten)
        {
            double som = 0;
            for (int i = 0; i < kosten.Length; i++)
            {
                som += kosten[i];
            }
            return som;
        }

        public static int BerekenSomUren(int[] uren)
        {
            int som = 0;
            for (int i = 0; i < uren.Length; i++)
            {
                som += uren[i];
            }
            return som;
        }

        private static double[] BerekenKosten(int[] uren)
        {
            double[] kosten = new double[uren.Length];

            for (int i = 0; i < uren.Length; i++)
            {
                if (uren[i] <= 3)
                {
                    kosten[i] = 2.0;
                }
                if (uren[i] <= 19)
                {
                    kosten[i] = (uren[i] - 3) * 0.5 + 2;
                }
                else
                {
                    kosten[i] = 10;
                }
            }

            return kosten;
        }

        private static int[] InputGeefUren(int autos)
        {
            int[] array = new int[autos];
            for (int i = 0; i < autos; i++)
            {
                Console.WriteLine($"Geef parkeertijd auto {i + 1} in (uren):");
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
