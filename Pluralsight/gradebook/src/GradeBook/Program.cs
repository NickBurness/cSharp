using System;
using System.Collections.Generic;

namespace GradeBook
{
    class Program
    {
        static void Main(string[] args)
        {
            var book = new Book("Nicks GradeBook");

            book.AddGrade(50.1);
            book.AddGrade(78.6);
            book.AddGrade(84.3);
            book.AddGrade(90);

            var stats = book.GetStatistics();
            Console.WriteLine($"The average grade is {stats.Average:N2}");
            Console.WriteLine($"The highest grade is {stats.High:N2}");
            Console.WriteLine($"The lowest grade is {stats.Low:N2}");
        }
    }
}