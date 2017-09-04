using System;
namespace ConsoleProject

//Two different Types

//Structures (Value Types):
//Allocated on Stack, Memory management done automatically
//Primitive
//Small, lightweight
//Custom Structures

//Classes (Reference Types):
//You need to allocate memory youself! ( new operator)
//Memory allocated on HEAP (more sustainable then Stack) won't be removed immediately
//Garbage collected by CLR that takes care of the HEAP
//Once in a while, CLR looks at the objects that are no longer used and removes them
//Arrays
//Strings
//Custom classes

#region ReferenceTypesAndValueTypes Demo1

    //public class ReferenceTypesAndValueTypes
    //{
        //static void Main(string[] args)
        //{
            //var a = 10;
            //var b = a;
            //b++;
            //When you copy a Value type to s different variable, 
            //a COPY of that Value is taken and stored in the targer variable
            //Thus in this case, a is 10
            //When value types are COPIED, they become independent
            //Thus when you change something in "a" it won't translate to "b"

    //        Console.WriteLine(string.Format("a: {0}, b: {1}", a, b));

    //        //int Array
    //        var array1 = new int[3] { 1, 2, 3 };
    //        var array2 = array1;
    //        array2[0] = 0;
    //        //Notice here we are setting BOTH arrays to [0]
    //        //Thus it will be BOTH 0 on the console
    //        Console.WriteLine(string.Format("array1[0]: {0}, array2[0]: {1}", array1[0], array2[0]));
    //    }
    //}
    #endregion

{
    class ReferenceTypesAndValueTypes2
    {
        
    }
}
