using System;

namespace Arrays_Oefeningen
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] getallenTien = new int[11];
            int[] getallenHonderd = new int[100];
            char[] alphabet = new char[26];
            int[] randomGetallen = new int[20];
            bool[] binaireGolf = new bool[30];

            getallenTien = OpvullenTien(getallenTien);
            PrintTien(getallenTien);

            getallenHonderd = OpvullenHonderd(getallenHonderd);
            PrintHonderd(getallenHonderd);

            alphabet = OpvullenAlphabet(alphabet);
            PrintAlphabet(alphabet);

            randomGetallen = OpvullenRandom(randomGetallen);
            PrintRandom(randomGetallen);

            binaireGolf = OpvullenBinaireGolf(binaireGolf);
            PrintBinair(binaireGolf);
        }

        private static int[] OpvullenTien(int[] getallenTien)
        {
            for (int i = 0; i < getallenTien.Length; i++)
            {
                getallenTien[i] = i;
            }
            return getallenTien;
        }

        private static void PrintTien(int[] getallenTien)
        {
            for (int i = 0; i < getallenTien.Length; i++)
            {
                Console.Write($"{getallenTien[i]}, ");
            }
            Console.Write("\n\n");
        }

        private static int[] OpvullenHonderd(int[] getallenHonderd)
        {
            for (int i = 0; i < getallenHonderd.Length; i++)
            {
                getallenHonderd[i] = getallenHonderd.Length - i;
            }
            return getallenHonderd;
        }

        private static void PrintHonderd(int[] getallenHonderd)
        {
            for (int i = 0; i < getallenHonderd.Length; i++)
            {
                Console.Write($"{getallenHonderd[i]} ");
            }
            Console.Write("\n\n");
        }

        private static char[] OpvullenAlphabet(char[] alphabet)
        {
            for (int i = 0; i < alphabet.Length; i++)
            {
                alphabet[i] = Convert.ToChar(i + 97);
            }
            return alphabet;
        }

        private static void PrintAlphabet(char[] alphabet)
        {
            for (int i = 0; i < alphabet.Length; i++)
            {
                Console.Write($"{alphabet[i]}, ");
            }
            Console.Write("\n\n");
        }

        private static int[] OpvullenRandom(int[] randomGetallen)
        {
            Random rand = new Random();

            for (int i = 0; i < randomGetallen.Length; i++)
            {
                randomGetallen[i] = rand.Next(1, 101);
            }
            return randomGetallen;
        }

        private static void PrintRandom(int[] randomGetallen)
        {
            for (int i = 0; i < randomGetallen.Length; i++)
            {
                Console.Write($"{randomGetallen[i]} ");
            }
            Console.Write("\n\n");
        }

        private static bool[] OpvullenBinaireGolf(bool[] binaireGolf)
        {
            bool element = true;
            for (int i = 0; i < binaireGolf.Length; i++)
            {
                binaireGolf[i] = element;
                element = !element;
            }
            return binaireGolf;
        }

        private static void PrintBinair(bool[] binaireGolf)
        {
            for (int i = 0; i < binaireGolf.Length; i++)
            {
                Console.Write($"{binaireGolf[i]}, ");
            }
            Console.Write("\n\n");
        }
    }
}
/*
 Een kort programma om op te warmen. Iedere opdracht hieronder is een apart programma (uiteraard mag je dit ook in 1 project oplossen).

Gebruik steeds een loop om dit op te lossen.

Maak een array gevuld met de getallen 0 tot 10
Maak een array gevuld met de getallen van 100 tot 1
Maak een array gevuld met de letters a tot z
Maak een array gevuld met willekeurige getallen tussen 1 en 100 (de array is 20 lang)
Maak een array gevuld met afwisselend true en false (de array is 30 lang)
Per array: output de array naar het scherm, maar ieder element naast elkaar met komma gescheiden. Dus niet:

true
false
true
\\etc
maar wel: true, false, true, ...
 */