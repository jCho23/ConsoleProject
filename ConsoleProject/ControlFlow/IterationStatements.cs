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
#endregion

namespace ConsoleProject.ControlFlow
{
    #region ForLoopsDemo
    class ForLoops
    {
        static void Main(string[] args)
        {
            //Increment
            for (var i = 1; i <= 10; i++)
            {
                if (i % 2 == 0)
                {
                    Console.WriteLine(i);
                }
            }

            //Decrement
            for (var i = 10; i >= 1; i--)
            {
                if (i % 2 == 0)
                {
                    Console.WriteLine(i);
                }
            }
        }
    }
    #endregion

}
