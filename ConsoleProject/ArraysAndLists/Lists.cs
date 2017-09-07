using System;

//Array: Fixed Size
//Lists: Dynamic Size

//Useful List Methods
//Add()
//AddRange()
//Remove()
//RemoveAt()
//IndexOf()
//Contains()
//Count()
using System.Collections.Generic;

namespace ConsoleProject.ArraysAndLists
{
    class Lists
    {
        static void Main(string[] args)
        {
            var numbers = new List<int>() { 1, 2, 3, 4 };
            //Notice that in Lists you can ADD objects
            //In Arrays, you can't add object since it is fixed
            numbers.Add(1);
            //When you see IEnumerable (hover AddRange), add an Array or List
            //Capital I = interface
            numbers.AddRange(new int[3] { 5, 6, 7 });

            foreach (var number in numbers)
                Console.WriteLine(number);
        }
    }
}
