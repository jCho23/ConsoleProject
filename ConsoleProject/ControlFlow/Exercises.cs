using System;
namespace ConsoleProject.ControlFlow
{
    class Exercises
    {
        #region ExerciseOne
        //Create a program that counts how many numbers between 1 and 100
        //Divisible by 3 with no remainder
        //Display results on Console

        //static void Main(string[] args)
        //{
        //    var count = 0;
        //    for (var i = 1; i <= 100; i++)
        //    {
        //        if (i % 3 == 0)
        //            count++;
        //    }
        //    Console.WriteLine("There are {0} numbers divisible by 3 between 1 and 100", count);

        //}
        #endregion

        #region Exercise2
        //Create a program that continuosly asks the user to enter a number
        //The loop terminates when the user enter "OK"
        //Calculate the sum of all the previouslt entered numbers and display it 

        //static void Main(string[] args)
        //{
        //    var sum = 0;
        //    while (true)
        //    {
        //        Console.WriteLine("Enter a number(or 'OK' to exit): ");
        //        var input = Console.ReadLine();

        //        if (input.ToLower() == "OK")
        //            break;

        //        sum += Convert.ToInt32(input);
        //    }
        //    Console.WriteLine("Sum of all numbers is: " + sum);
        //}
        #endregion

        #region Exercise3
        //Create a program that takes a single argument from the console
        //Computes the factorial and prints the value on the console

        static void Main(string[] args)
        {
            Console.WriteLine("Enter a number: ");
            var number = Convert.ToInt32(Console.ReadLine());

            var factorial = 1;
            for (var i = 1; i <= number; i++)
                factorial *= i;

            Console.WriteLine("{0}!={1}", number, factorial);
        }
        #endregion
    }
}
