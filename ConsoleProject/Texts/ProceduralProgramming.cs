using System;

//Procedural Programming: A programming paradigm based on procedure calls
//Object-Oriented Programming: A programming based on objects
using System.Collections.Generic;

namespace ConsoleProject.Texts
{
    ////First Demo
    //internal class ProceduralProgramming
    //{
    //    public static void Main(string[] args)
    //    {
    //        Console.WriteLine("What is your name? ");
    //        var name = Console.ReadLine();

    //        var reversed = ReverseName(name);
    //        Console.WriteLine("Reversed Name: " + reversed);
    //    }

    //    //Here all the processing is done by the String "name" thus we passed it here
    //    public static string ReverseName(string name)
    //    {
    //        var array = new char[name.Length];
    //        for (var i = name.Length; i > 0; i--)
    //            array[name.Length - i] = name[i - 1];

    //        //var reversed = new string(array);

    //        //return reversed;

    //        //This code is the same as above
    //        //Since the name of this Method (ReverseName) indicates what it is doing,
    //        //So we don't need to store it in a seperate variable like the code above
    //        //Here, the code is much easier to read
    //        return new string(array);
    //    }
    //}


    //Demo 2
    internal class ProceduralProgramming
    {
        static void Main(string[] args)
        {
            var numbers = new List<int>();

            while (true)
            {
                Console.WriteLine("Enter a number (or type 'Quit' to Exit): ");
                var input = Console.ReadLine();

                if (input.ToLower() == "quit")
                    break;

                numbers.Add(Convert.ToInt32(input));
            }

            //We can put this code snippet below right into the CW Method
            //var uniques = GetUniqueNumbers(numbers);

            Console.WriteLine("Unique Numbers: ");
            foreach (var number in GetUniqueNumbers(numbers)) 
                Console.WriteLine(number);
        }

        public static List<int> GetUniqueNumbers(List<int> numbers)
        {
            var uniques = new List<int>();
            foreach (var number in numbers)
            {
                if (!uniques.Contains(number))
                    uniques.Add(number);
            }
            return uniques;
        }
    }

}

