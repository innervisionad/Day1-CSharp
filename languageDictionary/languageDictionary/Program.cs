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
            
            bool running = true;
            do
            {
                Console.WriteLine("Welcome to the language library. You can add, delete and search entries.");
                string lang = Console.ReadLine();

                switch (lang)
                {
                    case "add":
                        Console.WriteLine("Please enter the Language you wish to add, press enter, then add the description");
                        languageDict.Add(Console.ReadLine(), Console.ReadLine());
                        break;
                    case "delete":
                        Console.WriteLine("Please enter the language name you wish to delete");
                        languageDict.Remove(Console.ReadLine());
                        break;
                    case "search":
                        Console.WriteLine("Please enter the language you wish to find");

                        string searchString = Console.ReadLine();
                        if (languageDict.ContainsKey(searchString))
                        {
                            Console.WriteLine(languageDict[searchString]);
                        }else
                        {
                            Console.WriteLine(searchString + " is not in the dictionary.");
                        }
                        break;
                    case "exit":
                        running = false;
                        break;
                    default:
                        Console.WriteLine("Command not recognised");
                        break;
                }
            } while (running);

        }
    }
}
