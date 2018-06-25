using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Language
{
    class Program
    {
        public static string dot = "_";

        static void Main(string[] args)
        {
            string phrase = "";
            string lower = "";
            while (true)
            {
                Console.Write("Type 'exit' to exit or enter a phrase:");
                phrase = Console.ReadLine();
                lower = phrase.ToLower();
                if (lower == "exit")
                {
                    Console.Write("Press any key to exit.");
                    Console.ReadKey();
                    return;
                }
                else
                {
                    DisplayWord(lower);
                }
            }
        }

        public static void DisplayWord(string phrase)
        {
            foreach (char c in phrase)
            {
                switch (c)
                {
                    case 'a': // * ***
                        Dot();
                        Dash();
                        Space(2);
                        break;
                    case 'b': // *** * * *
                        Dash();
                        Dot();
                        Dot();
                        Dot();
                        Space(2);
                        break;
                    case 'c': // *** * *** *
                        Dash();
                        Dot();
                        Dash();
                        Dot();
                        Space(2);
                        break;
                    case 'd': // *** * *
                        Dash();
                        Dot();
                        Dot();
                        Space(2);
                        break;
                    case 'e': // *
                        Dot();
                        Space(2);
                        break;
                    case 'f': // * * *** *
                        Dot();
                        Dot();
                        Dash();
                        Dot();
                        Space(2);
                        break;
                    case 'g': // *** *** *
                        Dash();
                        Dash();
                        Dot();
                        Space(2);
                        break;
                    case 'h': // * * * *
                        Dot();
                        Dot();
                        Dot();
                        Dot();
                        Space(2);
                        break;
                    case 'i': // * *
                        Dot();
                        Dot();
                        Space(2);
                        break;
                    case 'j': // * *** *** ***
                        Dot();
                        Dash();
                        Dash();
                        Dash();
                        Space(2);
                        break;
                    case 'k': // *** * ***
                        Dash();
                        Dot();
                        Dash();
                        Space(2);
                        break;
                    case 'l': // * *** * *
                        Dot();
                        Dash();
                        Dot();
                        Dot();
                        Space(2);
                        break;
                    case 'm': // *** ***
                        Dash();
                        Dash();
                        Space(2);
                        break;
                    case 'n': // *** *
                        Dash();
                        Dot();
                        Space(2);
                        break;
                    case 'o': // *** *** ***
                        Dash();
                        Dash();
                        Dash();
                        Space(2);
                        break;
                    case 'p': // * *** *** *
                        Dot();
                        Dash();
                        Dash();
                        Dot();
                        Space(2);
                        break;
                    case 'q': // *** *** * ***
                        Dash();
                        Dash();
                        Dot();
                        Dash();
                        Space(2);
                        break;
                    case 'r': // * *** *
                        Dot();
                        Dash();
                        Dot();
                        Space(2);
                        break;
                    case 's': // * * *
                        Dot();
                        Dot();
                        Dot();
                        Space(2);
                        break;
                    case 't': /// ***
                        Dash();
                        Space(2);
                        break;
                    case 'u': // * * ***
                        Dot();
                        Dot();
                        Dash();
                        Space(2);
                        break;
                    case 'v': // * * * ***
                        Dot();
                        Dot();
                        Dot();
                        Dash();
                        Space(2);
                        break;
                    case 'w': // * *** ***
                        Dot();
                        Dash();
                        Dash();
                        Space(2);
                        break;
                    case 'x': // *** * * ***
                        Dash();
                        Dot();
                        Dot();
                        Dash();
                        Space(2);
                        break;
                    case 'y': // *** * *** ***
                        Dash();
                        Dot();
                        Dash();
                        Dash();
                        Space(2);
                        break;
                    case 'z': // *** *** * *
                        Dash();
                        Dash();
                        Dot();
                        Dot();
                        Space(2);
                        break;
                    case '1': // * *** *** *** ***
                        Dot();
                        Dash();
                        Dash();
                        Dash();
                        Dash();
                        Space(2);
                        break;
                    case '2': // * * *** *** ***
                        Dot();
                        Dot();
                        Dash();
                        Dash();
                        Dash();
                        Space(2);
                        break;
                    case '3': // * * * *** ***
                        Dot();
                        Dot();
                        Dot();
                        Dash();
                        Dash();
                        Space(2);
                        break;
                    case '4': // * * * * ***
                        Dot();
                        Dot();
                        Dot();
                        Dot();
                        Dash();
                        Space(2);
                        break;
                    case '5': // * * * * *
                        Dot();
                        Dot();
                        Dot();
                        Dot();
                        Dot();
                        Space(2);
                        break;
                    case '6': // *** * * * *
                        Dash();
                        Dot();
                        Dot();
                        Dot();
                        Dot();
                        Space(2);
                        break;
                    case '7': // *** *** * * *
                        Dash();
                        Dash();
                        Dot();
                        Dot();
                        Dot();
                        Space(2);
                        break;
                    case '8': // *** *** *** * *
                        Dash();
                        Dash();
                        Dash();
                        Dot();
                        Dot();
                        Space(2);
                        break;
                    case '9': // *** *** *** *** *
                        Dash();
                        Dash();
                        Dash();
                        Dash();
                        Dot();
                        Space(2);
                        break;
                    case '0': // *** *** *** *** ***
                        Dash();
                        Dash();
                        Dash();
                        Dash();
                        Dash();
                        Space(2);
                        break;
                    case '.': // * * *   ***   *** *** ***   * *** *** *
                        Dot();
                        Dot();
                        Dot();
                        Space(2);
                        Dash();
                        Space(2);
                        Dash();
                        Dash();
                        Dash();
                        Space(2);
                        Dot();
                        Dash();
                        Dash();
                        Dot();
                        Space(2);
                        break;
                    case ' ': // "      "
                        Space(6);
                        break;
                    default:
                        break;
                }
            }
            Console.WriteLine("");
            Console.Write("Output: ");
            Console.WriteLine(phrase);
            /*
            for (int i = 0; i < phrase.Length; i++)
            {
                Console.Write(phrase[i]);
            }
            */
            Console.WriteLine("");
        }

        static void Dot()
        {
            System.Threading.Thread.Sleep(100);
            Console.Write(dot);
            System.Threading.Thread.Sleep(100);
            Space(1);
        }

        static void Dash()
        {
            System.Threading.Thread.Sleep(100);
            Console.Write(dot);
            System.Threading.Thread.Sleep(100);
            Console.Write(dot);
            System.Threading.Thread.Sleep(100);
            Console.Write(dot);
            System.Threading.Thread.Sleep(100);
            Space(1);
        }

        static void Space(int count)
        {
            for (int i = 0; i < count; ++i)
            {
                System.Threading.Thread.Sleep(100);
                Console.Write(" ");
            }
        }

    }
}
