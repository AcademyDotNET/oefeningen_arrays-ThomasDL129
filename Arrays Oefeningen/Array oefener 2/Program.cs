using System;

namespace Array_oefener_2
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] arrayA = new int[5];
            int[] arrayB = new int[5];
            int[] arrayC = new int[5];

            Console.WriteLine("Voer 5 getallen in om de eerste reeks in te vullen:");
            arrayA = ArrayOpvullen(arrayA);
            Console.WriteLine("\nVoer 5 getallen in om de tweede reeks in te vullen:");
            arrayB = ArrayOpvullen(arrayB);

            arrayC = ArraysOptellen(arrayA, arrayB, arrayC);
            Console.WriteLine("\nDe arrays opgeteld:");
            ToonArray(arrayC);
        }

        private static void ToonArray(int[] array)
        {
            for(int i = 0; i < array.Length; i++)
            {
                Console.Write($"{array[i]}, ");
            }
        }

        private static int[] ArraysOptellen(int[] arrayA, int[] arrayB, int[] arrayC)
        {
            for(int i = 0; i < arrayC.Length; i++)
            {
                arrayC[i] = arrayA[i] + arrayB[i];
            }
            return arrayC;
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
