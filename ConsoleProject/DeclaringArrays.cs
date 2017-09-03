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
    public class AccessingArrays
    {
        int[] numbers = new int[3] { 1, 2, 3 };
    }
    #endregion
}
