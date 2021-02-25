using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyMenu
{
    class Program
    {





        static void Main(string[] args)
        {
            bool showMenu = true;
            while (showMenu)
            {
                showMenu = MainMenu();
            }
        }

        private static bool MainMenu()
        {
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine("Please choose one options: \n 1)    Reverse String \n 2)    Remove Whitespace \n 3)    Exit");
            Console.WriteLine("\r\nSelect an option: ");

            switch (Convert.ToInt32(Console.ReadLine()))
            {
                case 1:
                    Console.Write("Please insert a word: ");
                    string a = Console.ReadLine();
                    Console.WriteLine(ReverseString(a));
                    return true;
                case 2:
                    Console.Write("Please insert your sentence: ");
                    string b = Console.ReadLine();
                    Console.WriteLine(RemoveWhitespaces(b));
                    return true;
                case 3:
                    return false;
                default:
                    return true;

            }

        }

        private static string ReverseString(string Phrase)
        {
            string PhraseNew = "";
            for (int i = Phrase.Length - 1; i >= 0; i--)
                PhraseNew += Phrase[i];
            return PhraseNew;
        }


        private static string RemoveWhitespaces(string Phrase)
        {
            int j = 0, inputlen = Phrase.Length;
            char[] newarr = new char[inputlen];

            for (int i = 0; i < inputlen; ++i)
            {
                char tmp = Phrase[i];

                if (!char.IsWhiteSpace(tmp))
                {
                    newarr[j] = tmp;
                    ++j;
                }
            }
            return new String(newarr, 0, j);
        }
    }
}
