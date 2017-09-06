using System;
namespace ConsoleProject.ControlFlow
{
    class Exercises
    {
        //Create a program that counts how many numbers between 1 and 100
        //Divisible by 3 with no remainder
        //Display results on Console

        static void Main(string[] args)
        {
            var count = 0;
            for (var i = 1; i <= 100; i++)
            {
                if (i % 3 == 0)
                    count++;
            }
            Console.WriteLine("There are {0} numbers divisible by 3 between 1 and 100", count);

        }
    }
}
