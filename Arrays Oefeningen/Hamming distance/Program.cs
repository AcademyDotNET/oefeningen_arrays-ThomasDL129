using System;

namespace Hamming_distance
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Geef twee reeksen op gescheiden met een enter. De twee reeksen moeten dezelfde lengte hebben.");
            string input1 = Console.ReadLine().ToUpper();
            input1 = InputCleaner(input1);
            string input2 = Console.ReadLine().ToUpper();
            input2 = InputCleaner(input2);
            string hamming = string.Empty;

            if(input1.Length == input2.Length)
            {
                for(int i = 0; i < input1.Length; i++)
                {
                    if(input1[i] == input2[i])
                    {
                        hamming += " ";
                    }
                    else
                    {
                        hamming += "^";
                    }
                }
            }
            else
            {
                Console.WriteLine("Fout. De twee reeksen hebben niet dezelfde lengte.");
            }
            Console.WriteLine(hamming);
        }

        private static string InputCleaner(string input)
        {
            string newInput = string.Empty;
            foreach (char element in input)
            {
                if (element == 'G' || element == 'T' || element == 'A' || element == 'C')
                {
                    newInput += element.ToString();
                }
            }

            return newInput;
        }
    }
}
