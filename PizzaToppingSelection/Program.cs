using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PizzaToppingSelection
{
    class Program
    {
        static void Main(string[] args)
        {
            string topping = Input("What pizza topping would you like?: ").ToLower();

            switch(topping)
            {
                case "cheese and tomato":
                case "margherita":
                    Console.WriteLine("Simple means less can go wrong");
                    break;
                case "meat feast":
                case "pepperoni":
                    Console.WriteLine("Pepperoni, yum!");
                    break;
                default:
                    Console.WriteLine("Unknown pizza");
                    break;
            }

            string music = Input("What type of music do you like?: ");

            switch(music)
            {
                case "rock":
                case "jazz":
                    Print("Respectable if you get something good",ConsoleColor.Yellow);
                    break;
                case "rap":
                case "drill":
                    Print("I hate you", ConsoleColor.Red);
                    break;
                case "pop":
                case "edm":
                case "trance":
                    Print("Hmm, call me", ConsoleColor.Blue);
                    break;
                default:
                    Console.WriteLine("Wat?");
                    break;
            }

            Console.ReadLine();
        }

        /// <summary>
        /// Prints coloured text
        /// </summary>
        /// <param name="text"> Text displayed </param>
        /// <param name="color"> Colour text is displayed in</param>
        private static void Print(string text, ConsoleColor colour)
        {
            Console.ForegroundColor = colour;
            Console.WriteLine(text);
            Console.ForegroundColor = ConsoleColor.White;
        }

        /// <summary>
        /// Ask user for an input
        /// </summary>
        /// <param name="question"> Input being asked </param>
        /// <returns> Answer to input </returns>
        private static string Input(string question)
        {
            Console.Write(question);
            return Console.ReadLine();
        }
    }
}
