using System;
using System.Runtime.InteropServices;
namespace ConsoleProject
{
    public class Strings
    {
        //string firstName = "June";

        //StringFormat
        //Placeholders are indicated by curly braces {}
        //string name = string.Format("{0} {1}", firstName, lastName);

        //Using String Join
        var numbers = new int[3] { 1, 2, 3 };
        //First arg
        string list = string.Join(",", numbers);

    }
}
