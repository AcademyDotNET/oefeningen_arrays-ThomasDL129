using System;

namespace Array_Zoeker
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] array = new int[10];

            Console.WriteLine("Geef 10 waarden in.");
            array = ArrayOpvullen(array);

            Console.WriteLine("Geef een waarde die je wil verwijderen:");
            array = VerwijderUitArray(array, UserInput());
            ToonArray(array);
        }
        private static void ToonArray(int[] array)
        {
            for (int i = 0; i < array.Length; i++)
            {
                Console.Write($"{array[i]}, ");
            }
        }

        private static int[] VerwijderUitArray(int[] array, int v)
        {
            int[] newArray = new int[array.Length];
            Array.Copy(array, newArray, array.Length);
            int index = Array.IndexOf(array, v);

            if (index != -1)
            {
                Array.ConstrainedCopy(newArray, index + 1, array, index, newArray.Length - (index + 1));
                array[^1] = -1;
            }

            return array;
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
//Maak een programma dat eerst weer aan de gebruiker om 10 waarden vraagt die in een array worden gezet.

//Vervolgens vraagt het programma welke waarde verwijderd moet worden.
//Wanneer de gebruiker hierop antwoordt met een nieuwe waarde dan zal deze nieuw ingevoerde waarde in de array gezocht worden.
//Indien deze gevonden wordt dan wordt deze waarde uit de array verwijderd en worden alle waarden die erachter komen met een plaatsje naar links opgeschoven,
//zodat achteraan de array terug een lege plek komt.

//Deze laatste plek krijgt de waarde -1.

//Toon vervolgens alle waarden van de array.

//Indien de te zoeken waarde meer dan 1 keer voorkomt, wordt enkel de eerst gevonden waarde verwijderd.