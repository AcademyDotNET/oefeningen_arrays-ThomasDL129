using System;

namespace Vraag_array
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] vragen = { "Wat is 5 x 6?", "Wat is 4 / 2?", "Wat is 6 + 9?", "Wat is 3 x 4?", "Wat is 17 - 9?", "Wat is 27 / 3?" };
            int[] antwoorden = new int[6];

            for(int i = 0; i < vragen.Length; i++)
            {
                PrintVraag(vragen, i);
                antwoorden[i] = UserInput();
            }
            PrintResultaat(vragen, antwoorden);
        }

        private static void PrintResultaat(string[] vragen, int[] antwoorden)
        {
            Console.Clear();
            for(int i = 0; i < vragen.Length; i++)
            {
                Console.WriteLine($"{vragen[i]}\tAntwoord: {antwoorden[i]}");
            }
        }

        private static void PrintVraag(string[] vragen, int i)
        {
            Console.Clear();
            Console.WriteLine($"{vragen[i]}");
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
//Maak een array die 6 strings kan bevatten. Ieder element van de array bevat een vraag (naar keuze te verzinnen) als string waar de gebruiker met een getal op moet antwoorden.
//Maak een array aan die tot 6 ints kan bevatten. Lees 1 voor 1 de vraag uit de string-array uit en toon deze op het scherm.
//Lees vervolgens het antwoord uit dat de gebruiker intypt en bewaar dit als int in de 2e array.

//Na de 6 vragen toon je vervolgens de vragen opnieuw met achter iedere vraag het antwoord van de gebruiker.