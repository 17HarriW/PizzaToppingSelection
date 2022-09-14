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
                    Console.WriteLine("Respectable if you get something good");
                    break;
                case "rap":
                case "drill":
                    Console.WriteLine("I hate you");
                    break;
                case "pop":
                case "edm":
                case "trance":
                    Console.WriteLine("Hmm, call me");
                    break;
                default:
                    Console.WriteLine("Wat?");
                    break;
            }

            Console.ReadLine();
        }

        /// <summary>
        /// Ask user for an input
        /// </summary>
        /// <param name="question"> The input being asked </param>
        /// <returns> The answer to the input </returns>
        private static string Input(string question)
        {
            Console.Write(question);
            return Console.ReadLine();
        }
    }
}
