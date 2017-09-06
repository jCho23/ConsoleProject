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

            //IndexOf(): This is the IndexOf Method 
            //This method finds the positions of an element in the Array
            var index= Array.IndexOf(numbers, 9);
            //Index of 9 is 2, since it's the third nubmer
            Console.WriteLine("Index of 9: " + index);

            //Clear Method: Clear()
            Array.Clear(numbers, 0, 2);

            foreach (var n in numbers)
                Console.WriteLine(n);
        }
    }
}
