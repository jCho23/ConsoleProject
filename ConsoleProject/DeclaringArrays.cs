using System;
namespace ConsoleProject
{

    #region DeclaringArrays
    public class DeclaringArrays
    {
        int number1;
        int number2;
        int number3;

        //This array is the same as above 
        // [] This tells the complier to declare an Arrary
        // [3] Is the size of the array, thus Arrays have a fixed size
        //Array is an Object
        int[] numbers = new int[3];
    }
    #endregion

    #region AccessingArrays
    //public class AccessingArrays
    //{
    //    int[] numbers = new int[3] { 1, 2, 3 };
    //}
    #endregion

    //Array Demo
    class ArrayDemo
    {
        static void Main(string[] args)
        {
            //var numbers = new int[3];
            //numbers[0] = 1;

            //When you declare an Array all the elements are set to the DEFAULT 
            //value of the Data Type of that Array  
            //Console.WriteLine(numbers[0]);
            //Console.WriteLine(numbers[1]);
            //Console.WriteLine(numbers[2]);

            //Bool Example
            //var flags = new bool[3];
            //flags[0] = true; 

            //Notice that Only the first Index[0] is the only one true
            //The other two are set to their DEFAULT value of false
            //Console.WriteLine(flags[0]);
            //Console.WriteLine(flags[1]);
            //Console.WriteLine(flags[2]);
        }

    }
}
