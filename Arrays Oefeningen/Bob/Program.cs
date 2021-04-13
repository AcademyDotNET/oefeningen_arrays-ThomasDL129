using System;

namespace Bob
{
    class Program
    {
        static void Main(string[] args)
        {
            string input;

            do
            {
                input = Console.ReadLine();
                Bob(input);
            } while (!input.ToLower().Contains("bye"));
        }

        private static void Bob(string input)
        {
            string[] answers = { "Sure.", "Whoa, chill out !", "Calm down, I know what I'm doing!", "Fine. Be that way!", "Yeah, bye.", "Whatever." };
            if (input.ToLower().Contains("bye"))
            {
                Console.WriteLine(answers[4]);
            }
            else if (input.Contains("?!"))
            {
                Console.WriteLine(answers[2]);
            }
            else if (input.Contains("!"))
            {
                Console.WriteLine(answers[1]);
            }
            else if (input == string.Empty)
            {
                Console.WriteLine(answers[3]);
            }
            else if (input.Contains("?"))
            {
                Console.WriteLine(answers[0]);
            }
            else
            {
                Console.WriteLine(answers[5]);
            }
        }
    }
}
