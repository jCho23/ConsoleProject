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


            //**Notice that .Length object is called in the method and ONLY accessible by this Object
            //THUS, .Length is an INSTANCE property

            //ALL the other Methods are getting on the Array class itself because it's Static
            //THUS, if a Method / Property/ Fill gets called on the class itself then its Static
            //i.e Static classes are accessible throughout the whole class 

            //Overloads: VERSIONS

            //Index Method: IndexOf()
            //This method finds the positions of an element in the Array
            var index= Array.IndexOf(numbers, 9);
            //Index of 9 is 2, since it's the third nubmer
            Console.WriteLine("Index of 9: " + index);

            //Clear Method: Clear()
            Array.Clear(numbers, 0, 2);

            foreach (var n in numbers)
                Console.WriteLine(n);

            //Copy Method: Copy()
            //We had to make this new Array as Destination
            //(See Copy parameter)
            int[] another = new int[3];
            Array.Copy(numbers, another, 3);

            Console.WriteLine("Effect of Copy()");
            foreach (var n in another)
                Console.WriteLine(n);

            //Sort Method: Sort()
            Array.Sort(numbers);

            Console.WriteLine("Effect of Sort()");
            foreach (var n in numbers)
                Console.WriteLine(n);

            //Reverse Method: Reverse()
            Array.Reverse(numbers);

            Console.WriteLine("Effect of Reverse()");
            foreach(var n in numbers)
                Console.WriteLine(n);
        }
    }
}
