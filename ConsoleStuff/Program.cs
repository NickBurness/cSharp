using System;

namespace ConsoleStuff
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");

            string aFriend = "Athena";
            Console.WriteLine(aFriend);

            aFriend = "Bob";
            string anotherFriend = "Bill";
            Console.WriteLine("Hello " + aFriend);
            Console.WriteLine($"Hello {aFriend} & {anotherFriend}");

            Console.WriteLine($"My friend {aFriend} has {aFriend.Length} letters in their name.");
            Console.WriteLine($"My friend {anotherFriend} has {anotherFriend.Length} letters in their name.");

            string friday = "     Friday!!!!! FEELING!!!!      ";
            Console.WriteLine($"{friday}");

            string trimFriday = friday.TrimStart();
            Console.WriteLine($"[{trimFriday}]");

            trimFriday = friday.TrimEnd();
            Console.WriteLine($"[{trimFriday}]");

            trimFriday = friday.Trim();
            Console.WriteLine($"[{trimFriday}]");

            string sayHello = "Hello World!";
            Console.WriteLine(sayHello);
            sayHello = sayHello.Replace("World!", aFriend);
            Console.WriteLine(sayHello);
            Console.WriteLine(sayHello.ToUpper());
            Console.WriteLine(sayHello.ToLower());

            string songLyrics = "We will, we will rock you!";
            Console.WriteLine(songLyrics.Contains("rock"));
            Console.WriteLine(songLyrics.Contains("stone"));
            Console.WriteLine(songLyrics.StartsWith("We"));
            Console.WriteLine(songLyrics.StartsWith("I"));
            Console.WriteLine(songLyrics.EndsWith("you!"));
            Console.WriteLine(songLyrics.EndsWith("me!"));
        }
    }
}