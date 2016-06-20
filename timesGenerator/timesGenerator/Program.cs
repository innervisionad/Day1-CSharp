using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace timesGenerator
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] numberAverage = new int[5];
            Console.WriteLine("Please enter 5 numbers, pressing Enter each time.");
            for(int i = 0; i<5; i++)
            {
                numberAverage[i] = Convert.ToInt32(Console.ReadLine());
            }
            double calc = numberAverage.Average();
            
            Console.WriteLine("The average is " + calc);

        }
    }
}
