﻿using System;
using System.Collections.Generic;
using System.Security.Cryptography;

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
        static void Main(string[] args)
        {
            var numbers = new List<int>();
        }





    }
}
