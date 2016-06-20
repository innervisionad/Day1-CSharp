using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace President_selection
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Here are the candidates for the 2016 presidency. Who do you think will win?");
            Console.WriteLine("Adam Clements");
            Console.WriteLine("Rob Bays");
            Console.WriteLine("Mark Perez");
            Console.WriteLine("Shrek Shrekson");
            string favorite = Console.ReadLine();

            switch (favorite) {
                case "Adam":
                case "Clements":
                case ("Adam Clements"):
                    Console.WriteLine("Good choice!");
                    break;
                case "Rob":
                case "Bays":
                case ("Rob Bays"):
                    Console.WriteLine("Good choice.. but Adam is better");
                    break;
                case "Mark":
                case "Perez":
                case ("Mark Perez"):
                    Console.WriteLine("Good, Smart, money-wise choice!");
                    break;
                case "Shrek":
                case "Shekson":
                case ("Shrek Shrekson"):
                    Console.WriteLine("Obviously the right choice! ah hell.. he wins already, let's all live in the swamp!!");
                    break;
                default:
                    Console.WriteLine("Sorry, " + favorite + " is not a Canddate.");
                    break;
            }
        }
    }
}
