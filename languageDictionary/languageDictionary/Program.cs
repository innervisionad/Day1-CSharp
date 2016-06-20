using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace languageDictionary
{
    class Program
    {
        static void Main(string[] args)
        {
            Dictionary<string, string> languageDict = new Dictionary<string, string>();
            languageDict.Add("C#", "Pretty useful language");
            languageDict.Add("Python", "user friendly, slithery language");
            languageDict.Add("ruby", "expensive language");
            Console.WriteLine("Welcome to the language library.");
            string lang = Console.ReadLine();

        }
    }
}
