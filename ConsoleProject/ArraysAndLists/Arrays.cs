using System;

//Array: Represents a fixed number of variables of a particular type
//TWO TYPES of Arrays: Single Dimension and Multi Dimension
//MultiDimension Arrays: Rectangular and Jagged (Array of Arrays)
//Array types are Classes

namespace ConsoleProject.ArraysAndLists
{
    class Arrays
    {
        static void Main(string[] args)
        {
            var numbers = new[] { 3, 7, 9, 2, 14, 6 };

            //Length: Returns the size of the Array
            Console.WriteLine("Length: " + numbers.Length);
        }
    }
}
