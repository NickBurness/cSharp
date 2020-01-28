using System;
using System.Collections.Generic;

namespace GradeBook
{
    class Book
    {
        public Book(string name)
        {
            grades = new List<double>();
            this.name = name;
        }

        public void AddGrade(double grade)
        {
            grades.Add(grade);
        }

        public void ShowStatistics()
        {
            double average = 0.0;
            double result = 0.0;
            double highestGrade = double.MinValue;
            double lowestGrade = double.MaxValue;

            foreach (double number in grades)
            {
                if (number > highestGrade)
                {
                    highestGrade = Math.Max(number, highestGrade);

                    lowestGrade = Math.Min(number, lowestGrade);
                }
                result += number;
                average = result / grades.Count;
            }
            Console.WriteLine($"The combined total of grades is {result:N2}");
            Console.WriteLine($"The average grade is {average:N2}");
            Console.WriteLine($"The highest grade is {highestGrade:N2}");
            Console.WriteLine($"The lowest grade is {lowestGrade:N2}");
        }

        private List<double> grades;
        private string name;
    }
}