using System;
using System.Collections.Generic;

namespace GradeBook
{
    class Program
    {
        static void Main(string[] args)
        {
            var book = new Book("Nicks GradeBook");

            // ..
            while (true)
            {
                Console.WriteLine("Enter a Grade or 'q' to quit or 'd' when done with the program");
                var input = Console.ReadLine();

                if (input == "q" || input == "d")
                {
                    break;
                }

                try
                {
                var grade = double.Parse(input);
                book.AddGrade(grade);
                }
                catch(ArgumentException exception)
                {
                    Console.WriteLine(exception.Message);
                    throw;
                }
                catch(FormatException exception)
                {
                    Console.WriteLine(exception.Message);
                }
                finally
                {
                    Console.WriteLine("**");
                }
            }

            var stats = book.GetStatistics();

            //////
            Console.WriteLine(Book.CATEGORY);
            Console.WriteLine($"For the book named {book.Name}");
            Console.WriteLine($"The average grade is {stats.Average:N2}");
            Console.WriteLine($"The highest grade is {stats.High:N2}");
            Console.WriteLine($"The lowest grade is {stats.Low:N2}");
            Console.WriteLine($"The letter is {stats.Letter}");
        }
    }
}