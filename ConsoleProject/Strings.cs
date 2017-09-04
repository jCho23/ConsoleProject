using System;
using System.Runtime.InteropServices;

namespace ConsoleProject
{
    //Strings are Immutable
    //Once created, Strings can't be changed 
    //public class Strings
    //{
        #region StringFormat
        //string firstName = "June";

        //StringFormat
        //Placeholders are indicated by curly braces {}
        //string name = string.Format("{0} {1}", firstName, lastName);
        #endregion

        #region Using StringJoin
        //Using String Join
        //var numbers = new int[3] { 1, 2, 3 };
        //First argument is a sepeator
        //Second argument is the array that we want to combine
        //string list = string.Join(",", numbers);
        #endregion

        #region VerbatimStrings
        //VerbatimStrings

        //string path = "c:\\projects\\project1\\folder1";
        //The @ symbol creates VerbatimStrings
        //string path = @"c:\projects\projects1\folder1";
        #endregion
    //}

    class StringDemo
    {
        static void Main (string[] args)
        {
            //Notice that Strings are CLASSES
            //These two formats are exactly the same
            //var knows that this variable is a string
            var firstName = "June";
            string lastName = "Cho";

            var fullName = firstName + " " + lastName;

            var myFullName = string.Format("My name is {0} {1}", firstName, lastName);

            //String.Join
            var names = new string[3] { "Mike", "Magic", "Kobe" };
            //First Argurment is the seperator ","
            //Second Argument is the array (names)
            var formattedNames = string.Join(",", names);
            Console.WriteLine(formattedNames);

        }
    }

}
