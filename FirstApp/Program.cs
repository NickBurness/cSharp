using System;

namespace FirstApp
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            Console.ReadLine();

            string firstName = "John";
            string lastName = "Doe";


            Console.WriteLine($"Name: {firstName} {lastName}");

            Console.WriteLine("Please enter a new first name:");
            firstName = Console.ReadLine();

            Console.WriteLine($"New name: {firstName} {lastName}");
            Console.ReadLine();

            int number1, number2;

            Console.WriteLine("Please enter a number");
            number1 = int.Parse(Console.ReadLine());
            Console.WriteLine("and another");
            number2 = int.Parse(Console.ReadLine());

            Console.WriteLine($"Adding the two numbers: {number1 + number2}");
            Console.ReadLine();
        }
    }
}