using System;
using System.Collections.Generic;

namespace LinkedList
{
    class Program
    {
        static void Main(string[] args)
        {
            int x = 1;

            if (x == 0)
            {
                     // fdsdf
            }

            if (x == 1)
            {

                // Create List of int
                List<int> numbers = new List<int>(5) { 5, 19, 45, 60, 25 };

                // Create List of strings
                List<string> names = new List<string>() { "Some Name", "Another Name", "Test string" };

                // Create List of objects
                List<Author> authors = new List<Author>
            {
                new Author {_Name = "Some Name", _Book = "Some Book", _Price = 44.95},
                new Author {_Name = "Another Name", _Book = "Another Book", _Price = 29.95},
                new Author {_Name = "Test string", _Book = "A test book", _Price = 23.95}
            };

                // Add more items 
                numbers.Add(22); numbers.Add(12); numbers.Add(7);
                names.Add("New String");
                Author newObject = new Author { _Name = "Test", _Book = "TestBook", _Price = 23.32 };
                authors.Add(newObject);

                // Print items
                foreach (int num in numbers)
                {
                    Console.WriteLine($"{num}, ");
                }
                foreach (string str in names)
                {
                    Console.WriteLine($"{str}, ");
                }
                foreach (Author aut in authors)
                {
                    Console.WriteLine($"{aut._Name}, {aut._Book}, {aut._Price},  ");
                }

                // Sort and print List
                numbers.Sort();
                foreach (int num in numbers)
                {
                    Console.WriteLine($"{num}, ");
                }

                Console.ReadKey();
            }
        }
    }
}
