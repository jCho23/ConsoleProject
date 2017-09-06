using System;
namespace ConsoleProject.ControlFlow
{
    class Exercises
    {
        #region Exercise1
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

        //static void Main(string[] args)
        //{
        //    Console.WriteLine("Enter a number: ");
        //    var number = Convert.ToInt32(Console.ReadLine());

        //    var factorial = 1;
        //    for (var i = 1; i <= number; i++)
        //        factorial *= i;

        //    Console.WriteLine("{0}!={1}", number, factorial);
        //}
        #endregion

        #region Exercise4
        //Create a program that picks a random number between 1 and 10
        //Give the user 4 chances to guess
        //If the user guesses the number, "You WON!!!"
        //If not, "You LOST"

        //static void Main(string[] args)
        //{
        //    var number = new Random().Next(1, 10);

        //    Console.WriteLine("Secret is " + number);
        //    for (var i = 0; i < 4; i++)
        //    {
        //        Console.WriteLine("Guess the secret number: ");
        //        var guess = Convert.ToInt32(Console.ReadLine());

        //        if (guess == number)
        //        {
        //            Console.WriteLine("You WON!!!");
        //            return;
        //        }

        //        else
        //        {
        //            Console.WriteLine("You LOST");
        //        }
        //    }
        //}
        #endregion
    }
}
