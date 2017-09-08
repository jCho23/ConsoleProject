using System;
using System.Collections.Generic;
using System.Security.Cryptography;
using System.Net.Http.Headers;
using System.Globalization;

namespace ConsoleProject.ArraysAndLists
{
    public class DemoArrayAndLists
    {
        //Demo 1
        //Ask the user to enter different names, until the user presses Enter (w/o name)
        //Depending on the names provides, display a message
        //static void Main(string[] args)
        //{

        //    var names = new List<string>();
        //    while (true)
        //    {
        //        Console.WriteLine("Type a basketball player (or hit Enter to Quit): ");

        //        var input = Console.ReadLine();
        //        if (string.IsNullOrWhiteSpace(input))
        //            break;
        //        names.Add(input);
        //    }

        //    if (names.Count > 2)
        //        Console.WriteLine("{0}, {1}, and {2} all jammed out!", 
        //                          names[0], names[1], names.Count - 2);
        //    else if (names.Count == 2)
        //        Console.WriteLine("{0} and {1} dunked on you hard", names[0], names[1]);
        //    else if (names.Count == 1)
        //        Console.WriteLine("{0} dunked on you", names[0]);
        //    else
        //        Console.WriteLine();
        //}

        //Demo2
        //Ask the user to enter their name
        //Use an Array to reverse the name and then store the result in a new string
        //Display the reversed name
        //static void Main(string[] args)
        //{
        //    Console.WriteLine("What is your name? ");
        //    var name = Console.ReadLine();

        //    var array = new char[name.Length];
        //    for (var i = name.Length; i > 0; i--)
        //        array[name.Length - i] = name[i - 1];

        //    var reversed = new string(array);
        //    Console.WriteLine("Reversed name: " + reversed);
        //}

        //Demo3
        //Ask the user to enter 5 numbers
        //If a number has been previously entered, display an Error message and ask the user to re-try
        //Once the user enters 5 unique numbers, 
        //Sort and Display them on the console

        //static void Main(string[] args)
        //{
        //    var numbers = new List<int>();
        //    while(numbers.Count<5)
        //    {
        //        Console.WriteLine("Enter a number: ");
        //        var number= Convert.ToInt32(Console.ReadLine());
        //        if (numbers.Contains(number))
        //        {
        //            Console.WriteLine("You've previously entered " + number);
        //            continue;
        //        }

        //        numbers.Add(number);
        //    }

        //    numbers.Sort();

        //    foreach(var number in numbers)
        //        Console.WriteLine(number);
        //}

        //Demo4
        //Ask the user to continuously enter a number or type "Quit" to exit
        //The list of numbers may include duplicates
        //Display the unique numbers that the user has entered 
        //static void Main(string[] args)
        //{
        //    var numbers = new List<int>();

        //    while (true)
        //    {
        //        Console.WriteLine("Enter a number (or 'Quit' to exit): ");
        //        var input = Console.ReadLine();

        //        if (input.ToLower() == "quit")
        //            break;

        //        numbers.Add(Convert.ToInt32(input));
        //    }

        //    var uniques = new List<int>();
        //    foreach (var number in numbers)
        //    {
        //        if (!uniques.Contains(number))
        //            uniques.Add(number);
        //    }

        //    Console.WriteLine("Unique numbers:");
        //    foreach(var number in uniques)
        //        Console.WriteLine(number);
        //}

        //Demo5
        //Ask the user to supply a list of comma seperated numbers (i.e. 5, 6, 2, 0,)
        //If the list is empty or includes less than 5 numbers, display "Invalid List" and ask user to retry
        //Display the 3 smallest numbers in the list

        //static void Main(string[] args)
        //{
        //    string[] elements;
        //    while (true)
        //    {
        //        Console.WriteLine("Enter a list of comma-seperated numbers: ");
        //        var input = Console.ReadLine();

        //        if (!String.IsNullOrWhiteSpace(input))
        //        {
        //            elements = input.Split(',');
        //            if (elements.Length >= 5)
        //                break;
        //        }

        //        Console.WriteLine("InvalidList");
        //    }

        //    var numbers = new List<int>();
        //    foreach (var number in elements)
        //        numbers.Add(Convert.ToInt32(number));


        //    var smallests = new List<int>();
        //    while (smallests.Count <3)
        //    {
        //        //Assume the first number is the smallest
        //        var min = numbers[0];
        //        foreach (var number in numbers)
        //        {
        //            if (number < min)
        //                min = number;
        //        }

        //        smallests.Add(min);
        //        numbers.Remove(min);
        //    }

        //    Console.WriteLine("The 3 smallest numbers are: ");
        //    foreach (var number in smallests)
        //        Console.WriteLine(number);
        //}
    }
}
