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

            Console.WriteLine();
            //This starts the search from the beginning of the list
            Console.WriteLine("Index of 1: " + numbers.IndexOf(1));
            //This starts the search from the end of the list
            Console.WriteLine("Last Index of 1: " + numbers.LastIndexOf(1));

            //Here COUNT is a PROPERTY and Returns the number of objects in the list
            Console.WriteLine("Count: "+ numbers.Count);

   //         numbers.Remove(1);
			//foreach (var number in numbers)
                //Notice that it onle removed the 1st "1"
				//Console.WriteLine(number);


            //This is how you Remove All the "1's" in the list
            foreach (var number in numbers)
            {
                if (number == 1)
                    numbers.Remove(number);
            }

			foreach (var number in numbers)
				Console.WriteLine(number);
        }
    }
}
