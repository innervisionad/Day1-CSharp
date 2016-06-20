using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Text.RegularExpressions;

namespace Riddles
{
    class Program
    {
        static void Main(string[] args)
        {
            
            Console.WriteLine("What comes down, but never goes up?");
            string answer = Console.ReadLine();

            while (!answer.Contains("rain"))
            {
                Console.WriteLine("Try again");
                answer = Console.ReadLine();
            }

            Console.WriteLine("You got it!");
            Console.WriteLine("I'm tall when I'm young and short when I'm old. What am I?");

            do
            {
                answer = Console.ReadLine();
                if(!answer.Contains("candle"))
                {
                    Console.WriteLine("Try again");
                }
                
            } while (!answer.Contains("candle"));

            Console.WriteLine("You got both correct! well done!");
            Console.WriteLine("Please press enter twice to exit");
            Console.ReadLine();
        }
    }
}
