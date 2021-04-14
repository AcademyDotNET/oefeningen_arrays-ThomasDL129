using System;

namespace Galgje
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Voer een woord in om the raden (Laat het niet zien aan de speler(s):");
            string input = StringCleaner();

            HangmanMain(input);
        }

        private static void HangmanMain(string input)
        {
            char[] word = input.ToCharArray();
            bool[] visibleLetters = new bool[word.Length];
            int errors = 0;
            do
            {
                Console.Clear();
                PrintWord(visibleLetters, word);
                PrintHangMan(errors);

                char c = InputLetter();
                bool letterFound = CheckLetter(word, visibleLetters, c);

                if (!letterFound)
                {
                    errors++;
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine($"De letter {c} komt niet voor.");
                    Console.ForegroundColor = ConsoleColor.Gray;
                    Console.ReadLine();
                }


            } while (Array.IndexOf(visibleLetters, false) != -1 && errors != 10);

            if (errors == 10)
            {
                Console.WriteLine($"Verloren. Het woord was {input}");
            }
        }

        private static char InputLetter()
        {
            char c;
            bool validInput = false;
            do
            {
                Console.WriteLine("Geef een letter:");
                validInput = char.TryParse(Console.ReadLine().ToUpper(), out c);
            } while (!validInput || c > 'Z' || c < 'A');

            return c;
        }

        private static bool CheckLetter(char[] word, bool[] visibleLetters, char c)
        {
            int index = Array.IndexOf(word, c);
            if(index != -1)
            {
                visibleLetters[index] = true;
                return true;
            }
            else
            {
                return false;
            }
            
        }

        private static void PrintWord(bool[] visibleLetters, char[] word)
        {
            Console.WriteLine("Woord:\n");
            for(int i = 0; i < visibleLetters.Length; i++)
            {
                if (!visibleLetters[i])
                {
                    Console.Write("-");
                }
                else
                {
                    Console.Write($"{word[i]}");
                }
            }
            Console.WriteLine("\n\n");
        }

        private static string StringCleaner()
        {
            string clean = string.Empty;
            string input = Console.ReadLine().ToUpper();

            foreach(char element in input)
            {
                if(element >= 'A' && element <= 'Z' && element != ' ')
                {
                    clean += element.ToString();
                }
            }

            return clean;
        }
        private static void PrintHangMan(int errors)
        {
            string[,] hangman = { { "     ",
                                    "|    ",
                                    "|    ",
                                    "|    ",
                                    "|    ",
                                    "|_ _ " },
                                  { "____ ",
                                    "|    ",
                                    "|    ",
                                    "|    ",
                                    "|    ",
                                    "|_ _ " },
                                  { "____ ",
                                    "|/   ",
                                    "|    ",
                                    "|    ",
                                    "|    ",
                                    "|_ _ " },
                                  { "____ ",
                                    "|/ | ",
                                    "|    ",
                                    "|    ",
                                    "|    ",
                                    "|_ _ " },
                                  { "____",
                                    "|/ |",
                                    "|  O",
                                    "|   ",
                                    "|   ",
                                    "|_ _" },
                                  { "____ ",
                                    "|/ | ",
                                    "|  O ",
                                    "|  | ",
                                    "|    ",
                                    "|_ _ " },
                                  { "____ ",
                                    "|/ | ",
                                    "|  O ",
                                    "| /| ",
                                    "|    ",
                                    "|_ _ " },
                                  { "____ ",
                                    "|/ | ",
                                    "|  O ",
                                    "| /|\\",
                                    "|    ",
                                    "|_ _ " },
                                  { "____ ",
                                    "|/ | ",
                                    "|  O ",
                                    "| /|\\",
                                    "| /  ",
                                    "|_ _ " },
                                  { "____ ",
                                    "|/ | ",
                                    "|  O ",
                                    "| /|\\",
                                    "| / \\ ",
                                    "|_ _ " }
            };


        }
    }
}
//          ____     ____     ____     ____
//1 |      2|       3|/      4|/ |    5|/ |
//  |       |        |        |        |  O
//  |       |        |        |        |
//  |       |        |        |        |
//  |_ _    |_ _     |_ _     |_ _     |_ _
//  ____    ____     ____     ____     ____
//6 |/ |   7|/ |    8|/ |    9|/ |   10|/ |
//  |  O    |  O     |  O     |  O     |  O
//  |  |    | /|     | /|\    | /|\    | /|\
//  |       |        |        | /      | / \
//  |_ _    |_ _     |_ _     |_ _     |_ _