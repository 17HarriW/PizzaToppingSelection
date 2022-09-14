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
            Console.Write("What pizza topping would you like?: ");
            string topping = Console.ReadLine().ToLower();

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

            Console.ReadLine();
        }
    }
}
