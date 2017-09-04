//using System;
//using System.Globalization;
//namespace ConsoleProject

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

#region ReferenceTypesAndValueTypes2 Demo2
//{
    //public class Person
    //{
    //    public int Age;
    //}

    //class ReferenceTypesAndValueTypes2
    //{
    //    static void Main(string[] args)
    //    {
    //        //This "number" is a value type with the Scope of the Main Method
    //        //Outside of the Main Method, this variable, (number), has no meaning
    //        var number = 1;
    //        Increment(number);
    //        Console.WriteLine(number);

    //        //This is ReferenceType
    //        var person = new Person() { Age = 20 };
    //        MakeOld(person);
    //        Console.WriteLine(person.Age);
    //    }

    //    //This "number" is stored in a different memory than above
    //    //this "number" is limited to this Increment Method
    //    public static void Increment(int number)
    //    {
    //        number += 10;
    //    }

    //    public static void MakeOld(Person person)
    //    {
    //        person.Age += 10;
    //    }
    //}
//}
#endregion

