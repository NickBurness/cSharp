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
                catch(ArgumentException argexception)
                {
                    Console.WriteLine(argexception.Message);
                    throw;
                }
                catch(FormatException formatexception)
                {
                    Console.WriteLine(formatexception.Message);
                }
                finally
                {

                }
            }

            var stats = book.GetStatistics();
            Console.WriteLine($"The average grade is {stats.Average:N2}");
            Console.WriteLine($"The highest grade is {stats.High:N2}");
            Console.WriteLine($"The lowest grade is {stats.Low:N2}");
            Console.WriteLine($"The letter is {stats.Letter}");
        }
    }
}