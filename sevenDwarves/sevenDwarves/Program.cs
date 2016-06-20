using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace sevenDwarves
{
    class Program
    {
        static void Main(string[] args)
        {

            string[] sevenDwarves = { "Happy", "Doc", "Sleepy", "Sneezy", "Dopey", "Bashful", "Grumpy" };

            string food;
            string drink;

            for (int i = 0; i < 7; i++)
            {
                Console.WriteLine(sevenDwarves[i] + ", What would you like to eat?");
                food = Console.ReadLine();
                Console.WriteLine(sevenDwarves[i] + ", Your " + food + " is ready!");
            }
            
            foreach (string dwarf in sevenDwarves)
            {
                
                Console.WriteLine(dwarf + ", What would you like to drink?");
                drink = Console.ReadLine();
                Console.WriteLine(dwarf + ", your " + drink + " is ready!");
            }


        }
    }
}
