using System;

namespace Paswoord_generator
{
    class Program
    {
        static void Main(string[] args)
        {
            string naam;
            string telefoon;
            string postcode;
            string paswoord = string.Empty;

            Console.WriteLine("Familienaam:");
            naam = Console.ReadLine().ToLower();
            Console.WriteLine("Telefoon:");
            telefoon = Console.ReadLine();
            Console.WriteLine("Postcode:");
            postcode = Console.ReadLine();

            string eersteLetter = naam[0].ToString().ToUpper();
            string tweedeLetter = naam[1].ToString();
            paswoord = tweedeLetter + eersteLetter;

            telefoon = telefoon.Remove(telefoon.IndexOf('/'));
            paswoord += telefoon[1..];

            paswoord += Math.Pow(Char.GetNumericValue(postcode[0]), 2).ToString();

            Console.WriteLine($"Paswoord:\n{paswoord}");
        }
    }
}
