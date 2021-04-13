using System;

namespace Leveringsbedrijf
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = System.Text.Encoding.UTF8;

            string[] postcodes = { "1000", "5492", "5463", "4194", "3218", "5643", "7601", "9743", "4215", "7645" };
            int[] prijs = { 10, 25, 28, 30, 16, 84, 15, 46, 23, 14 };

            Console.WriteLine("Geef gewicht pakket");
            int gewicht = IntUserInput();

            Console.WriteLine("Naar welke gemeente wenst u dit pakket te versturen?");
            string postcode = IntUserInput().ToString();

            int index = Array.IndexOf(postcodes, postcode);
            if (index != -1)
            {
                Console.WriteLine($"Dit zal {prijs[index]*gewicht:C} kosten.");
            }
            else
            {
                Console.WriteLine("We leveren niet naar die gemeente.");
            }
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
