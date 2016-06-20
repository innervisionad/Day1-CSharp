using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace numberGuessingGame
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("I will guess a number between 1 and 50 and you need to guess it");
            Random rnd = new Random();
            int secretAnswer = rnd.Next(1, 51);

            int numGuess;
            do
            {
                string input1 = Console.ReadLine();
                numGuess = Convert.ToInt32(input1);

                if (numGuess > secretAnswer)
                {
                    Console.WriteLine("Too high, guess again...");
                }
                else if (numGuess < secretAnswer)
                {
                    Console.WriteLine("Too low, guess again...");
                }
                else
                {
                    Console.WriteLine("You got it! Well done!");
                }

            } while (numGuess != secretAnswer);
        }
    }
}
