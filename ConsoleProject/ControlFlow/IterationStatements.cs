using System;

#region ForLoops
//For Loops
//Have 3 parts: 
//Initization Clause: How many times the loop goes 
//Condition Clause: Loop will keep going as long as condition is still valid
//Iteration Clause: Increment or Decrement the Counter 

//Foreach Loops
//Used to iterate Enumerable Objects: Anything that has a list or an Array nature
//i.e.
//foreach (var number in numbers)
//"number" is local or temporary variable and "numbers" is the list
//notice the "in" keyword
#endregion

#region WhileLoops
//While Loops
//similar to ForLoop but different syntax
#endregion

#region DoWhileLoops
//Do-While Loops
//Condition is evaulated at the end of the loop
//You don't need a counter
#endregion

#region BreakAndContinue
//Break and Continue
//Break: jumps out of the loop
//Continue: jumps into the next iteration
using System.Security.Cryptography;
#endregion

namespace ConsoleProject.ControlFlow
{
    #region ForLoopsDemo
    //class ForLoops
    //{
    //    static void Main(string[] args)
    //    {
    //        //Increment
    //        for (var i = 1; i <= 10; i++)
    //        {
    //            if (i % 2 == 0)
    //            {
    //                Console.WriteLine(i);
    //            }
    //        }

    //        //Decrement
    //        for (var i = 10; i >= 1; i--)
    //        {
    //            if (i % 2 == 0)
    //            {
    //                Console.WriteLine(i);
    //            }
    //        }
    //    }
    //}
    #endregion

    #region ForEachLoopsDemo
    //class ForEachLoops
    //{
    //static void Main(string[] args)
    //{
    //var name = "Michael Jordan";

    //ForLoops
    //for (var i = 0; i < name.Length; i++)
    //{
    //    Console.WriteLine(name[i]);
    //}

    //ForEachLoops are great when we have an Enum Object (string, list, array)
    //Notice that this code is the same as above
    //foreach (var character in name)
    //Console.WriteLine(character);

    //Second Example ForEachLoop
    //This is iterating an Array
    //var numbers = new int[] { 1, 2, 3, 4 };

    //foreach (var number in numbers)
    //Console.WriteLine(number);
    //    }

    //}
    #endregion

    class WhileLoops
    {
        static void Main(string[] args)
        {
            //ForLoops are used when you know the specific amount of times to iterate
            //In this case, it's 10
            //for (var i = 1; i <= 10; i++)
            //{
            //    if (i % 2 == 0)
            //        Console.WriteLine(i);
            //}

            //This is the same code as above but written in WhileLoops
            //WhileLoops are used when you don't know the amount of times to iterate
            //var i = 0;
            //while (i <= 10)
            //{
            //    if (i % 2 == 0)
            //        Console.WriteLine(i);
            //    i++;
            //}

            while (true)
            {
                Console.Write("Type your name: ");
                var input = Console.ReadLine();

                //"!" This is the "not" operator
                //The "continue" keyword makes the loop go back to the start
                //Meaning, it'll never reach break
                if (!String.IsNullOrWhiteSpace(input))
                {
					Console.WriteLine("@Echo: " + input);
                    continue;
                }
                    break;

            }
        }
    }
}
