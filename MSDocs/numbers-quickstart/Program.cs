using System;

namespace NumbersInCSharp
{
    class Program
    {
        static void WorkingWithIntegers()
        {
            int a = 10;
            int b = 5;
            int c = a + b;
            Console.WriteLine(c); //expected output 15

            // subtraction
            c = a - b;
            Console.WriteLine(c); //expected output 5

            // multiplication
            c = a * b;
            Console.WriteLine(c); //expected output 50

            // division
            c = a / b;
            Console.WriteLine(c); //expected output 2

            // modulo  
            c = a % b;
            Console.WriteLine(c); // expected output 0


            // order of operations
            c = (a + b - 12) * 20;
            Console.WriteLine(c); // expected output 60
        }

        static void OrderPrecedence() 
        {
        
            int a = 5;
            int b = 4;
            int c = 2;
            int d = a + b * c;
            Console.WriteLine(d);

            d = (a + b) * c;
            Console.WriteLine(d);

            d = (a + b) - 6 * c + (12 * 4) / 3 + 12;
            Console.WriteLine(d);

            int e = 7;
            int f = 4;
            int g = 3;
            int h = (e + f) / g;
            Console.WriteLine(h);
        }

        static void TestLimits() 
        {
            int a = 7;
            int b = 4;
            int c = 3;
            int d = (a + b) / c;
            int e = (a + b) % c;
            Console.WriteLine($"quotient: {d}");
            Console.WriteLine($"remainder: {e}");

            int max = int.MaxValue;
            int min = int.MinValue;
            Console.WriteLine($"The range of integers is {min} to {max}");
            
            int what = max + 3;
            Console.WriteLine($"An example of overflow: {what}");
        }

        static void WorkWithDoubles()
        {
            double a = 5;
            double b = 4;
            double c = 2;
            double d = (a + b) / c;
            Console.WriteLine(d);

            double e = 19;
            double f = 23;
            double g = 8;
            double h = (e + f) / g;
            Console.WriteLine(h);

            double max = double.MaxValue;
            double min = double.MinValue;
            Console.WriteLine($"The range of double is {min} to {max}");
            
            double third = 1.0 / 3.0;
            Console.WriteLine(third);

            double halve = 1.0 / 2.0;
            Console.WriteLine(halve);

            double fifth = 1.0 / 5.0;
            Console.WriteLine(fifth);

            double tenth = 1.0 / 10.0;
            Console.WriteLine(tenth);

            double someResult = tenth + halve + fifth + third;
            Console.WriteLine(someResult);

            double someWeirdResult = tenth / (halve * tenth) + third;
            Console.WriteLine(someWeirdResult);
        }

        static void WorkWithDecimals() 
        {
            decimal min = decimal.MinValue;
            decimal max = decimal.MaxValue;
            Console.WriteLine($"The range of decimal is {min} to {max}");

            double a = 1.0;
            double b = 3.0;
            Console.WriteLine(a / b);

            decimal c = 1.0M; 
            decimal d = 3.0M;
            Console.WriteLine(c / d);
        }

        static void CalculateArea() 
        {
           double radius = 2.50;
           double area = Math.Pow(radius, 2) * Math.PI;
           Console.WriteLine(area);
        }

        static void Main(string[] args)
        {
           // WorkingWithIntegers();

           // OrderPrecedence();

           // TestLimits();

           // WorkWithDoubles();

           // WorkWithDecimals();

           // CalculateArea();
        }
    }
}
