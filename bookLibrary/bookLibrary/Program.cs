using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace bookLibrary
{
    class Program
    {
        static void Main(string[] args)
        {

            List<string> bookList = new List<string>();
           

            bool running = true;
            string[] commands = { "add", "delete", "sort", "List", "search", "quit" };            
         

            while (running) {
                Console.WriteLine("Welcome to the book Library. You can add, delete, sort, list and search titles.");
                string book = Console.ReadLine();
                switch (book)
                {
                    case "add":
                        Console.WriteLine("Please enter the book you want to add...");
                        string bookIn = Console.ReadLine();
                        bookList.Add(bookIn);
                        break;
                    case "delete":
                        Console.WriteLine("Please enter the book you would like to remove form the list...");
                        foreach (string novel in bookList)
                        {
                            Console.WriteLine(novel);
                        }
                        string bookOut = Console.ReadLine();
                        bookList.Remove(bookOut);
                        break;
                    case "sort":
                        bookList.Sort();
                        Console.WriteLine("Your list has been sorted!");
                        break;
                    case "list":
                        foreach (string novel in bookList)
                        {
                            Console.WriteLine(novel);
                        }
                        break;
                    case "search":
                        Console.WriteLine("Please enter what you would like to search");
                        string bookSearch = Console.ReadLine();
                        if (bookList.Contains(bookSearch))
                        {
                            Console.WriteLine("Yes it's there");
                        }
                        else
                        {
                            Console.WriteLine("it's not in the list");
                        }
                        break;
                    case "exit":
                        running = false;
                        break;
                    default:
                        Console.WriteLine("command not recognised");
                        break;           
                }
            }
        }
    }
}
