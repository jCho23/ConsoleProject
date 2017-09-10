//using System;
//using System.Collections.Generic;

//namespace ConsoleProject.Texts
//{
    //public class StringDemos
    //{
        //Demo 1
        //Ask the user to enter a few number seperated by a hyphen
        //Work out if the numbers are consecutive
        //If consecutive == Display "Consecutive"
        //Else Display Non-Consecutive
        //static void Main(string[] args)
        //{
        //    Console.WriteLine("Enter a few numbers seperated by a hyphen (i.e. 1-2-3-4) ");
        //    var input = Console.ReadLine();

        //    var numbers = new List<int>();
        //    foreach (var number in input.Split('-'))
        //        numbers.Add(Convert.ToInt32(number));

        //    numbers.Sort();

        //    var isConsecutive = true;
        //    for (var i = 1; i < numbers.Count; i++)
        //    {
        //        if (numbers[i] !=numbers[i-1] +1)
        //        {
        //            isConsecutive = false;
        //            break;
        //        }
        //    }

        //    var message = isConsecutive ? "Consecutive" : "Not Consecutive";
        //    Console.WriteLine(message);


        //Demo 2
        //Ask the User to enter a time value in 24hr format (i.e. 14:00)
        //A valid time should be between 00;00-23:59
        //IF the time is valid == Display "OK"
        //Else == Display Invalid Time
        //If the user enters nothing == Display Invalid Time
        //static void Main(string[] args)
        //{
        //    Console.WriteLine("Enter a time Military style: ");
        //    var input = Console.ReadLine();

        //    if (String.IsNullOrWhiteSpace(input))
        //    {
        //        Console.WriteLine("Invalid Time");
        //        return;
        //    }

        //    var components = input.Split(':');
        //    if (components.Length !=2)
        //    {
        //        Console.WriteLine("Invalid Time");
        //        return;
        //    }

        //    try
        //    {
        //        var hour = Convert.ToInt32(components[0]);
        //        var minute = Convert.ToInt32(components[1]);

        //        if (hour >= 0 && hour <= 23 && minute <=59)
        //            Console.WriteLine("OK TIME");
        //        else
        //            Console.WriteLine("Invalid Time");
        //    }

        //    catch (Exception)
        //    {
        //        Console.WriteLine("Invalid Time");
        //    }

        //}

        //Demo3
        //Ask the user to enter an English word
        //Count the number of vowels, Caps do not matter
        //Diplay the number of vowels

        //static void Main(string[] args)
        //{
        //    Console.WriteLine("Enter a word: ");
        //    //Notice that we used ToLower here to count for "A" and "a"
        //    var input = Console.ReadLine().ToLower();

        //    var vowels = new List<char>(new char[] { 'a', 'e', 'i', 'o', 'u' });
        //    var vowelsCount = 0;
        //    foreach (var character in input)
        //    {
        //        if (vowels.Contains(character))
        //            vowelsCount++;
        //    }

        //    Console.WriteLine(vowelsCount);
        //}
//    }
//}
