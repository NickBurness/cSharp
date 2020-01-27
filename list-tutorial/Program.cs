using System;
using System.Collections.Generic;

namespace list_tutorial
{
    class Program
    {
        static void Main(string[] args)
        {
            var names = new List<string> { "Nick", "Ana", "Felipe"};
            foreach (var name in names)
            {
                Console.WriteLine($"Hello {name.ToUpper()}!");
            }
            Console.WriteLine();
            names.Add("Maria");
            names.Add("Bill");
            names.Remove("Ana");
            foreach (var name in names)
            {
               Console.WriteLine($"Hello {name.ToUpper()}!");
            }
            Console.WriteLine($"My name is {names[0]}");
            Console.WriteLine($"I added {names[2]} & {names[3]}'s names to the original list");
            Console.WriteLine($"The list has {names.Count} people in it");
        }
    }
}