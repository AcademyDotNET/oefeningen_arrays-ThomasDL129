using System;

//TO DO: Decrypt werkt niet

namespace Caesar_encryptie
{
    class Program
    {
        static void Main(string[] args)
        {
            int sleutel = 0;
            Console.WriteLine("Geef de encryptie-sleutel:");
            do
            {
                sleutel = IntUserInput();
            } while (sleutel < 0 && sleutel > 25);

            Console.WriteLine("Geef de tekst die je wil encrypteren:");
            char[] tekst = Console.ReadLine().ToUpper().ToCharArray();
            Encrypt(tekst, sleutel);
            Console.WriteLine(tekst);
            
            Console.WriteLine("Geef tekst in dat je wil decrypteren:");
            char[] encTekst = Console.ReadLine().ToUpper().ToCharArray();
            Decrypt(encTekst, sleutel);
            Console.WriteLine(encTekst);
        }

        private static void Decrypt(char[] tekst, int sleutel)
        {
            sleutel = 26 - sleutel;
            Encrypt(tekst, sleutel);
        }

        private static void Encrypt(char[] tekst, int sleutel)
        {
            for (int i = 0; i < tekst.Length; i++)
            {
                if(tekst[i] == ' ')
                {
                    tekst[i] = ' ';
                }
                else if(tekst[i] + sleutel <= 'Z')
                {
                    tekst[i] = Convert.ToChar(Convert.ToInt32(tekst[i]) + sleutel);
                }
                else if(tekst[i] + sleutel > 'Z')
                {
                    tekst[i] = Convert.ToChar(Convert.ToInt32(tekst[i] - (26 - sleutel)));
                }
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
