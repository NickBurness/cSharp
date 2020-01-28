using System;

namespace BranchesAndLoops
{
    class Program
    {
        static void ExploreIf()
        {
            int a = 5;
            int b = 4;
            if (a + b > 10)
            {
                Console.WriteLine("The answer is greater than 10");
            }
            else
            {
                Console.WriteLine("The answer is not greater than 10");
            }

            int c = 1;
            if ((a + b + c > 10) && (a == b))
            {
                Console.WriteLine("The answer is greater than 10");
                Console.WriteLine("And the first number is equal to the second");
            }
            else
            {
                Console.WriteLine("The answer is not greater than 10");
                Console.WriteLine("Or the first number is not equal to the second");
            }
        }

        static void DoWhileAndLoops()
        {
            int counter = 0;
            do
            {
                Console.WriteLine($"The counter is at {counter}");
                counter++;
            }
            while (counter < 10);

            for (int index = 5; index <= 25; index++)
            {
                Console.WriteLine($"Hello World! The index is {index}");
            }
        }

        static void SumOfAllIntsFrom1To20()
        {
            int sum = 0;
            for (int number = 0; number <= 20; number++)
            {
                if (number % 3 == 0)
                {
                    sum = number + sum;
                    Console.WriteLine($"This is the sum {sum}");
                }
            }
        }

            static void Main(string[] args)
            {

            // ExploreIf();
            // DoWhileAndLoops();
            // SumOfAllIntsFrom1To20();
                
        }
    }
}

