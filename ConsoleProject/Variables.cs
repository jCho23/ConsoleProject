using System;

namespace ConsoleProject
{
    class Variables
    {
        static void Main(string[] args)
        {
            #region Basic Variables
            //This is how to write Variables 
            //byte number = 8;
            //int count = 10;
            //float totalPrice = 20.95f;
            //char character = 'J';
            //string firstName = "June";
            //bool isWorking = true;

            //You can alaso write Variables like this.
            //Notice that you can hover over var and see what the type is
            //var number = 8;
            //var count = 10;
            //var totalPrice = 20.95f;
            //var character = 'J';
            //var firstName = "June";
            //var isWorking = true;

            //Console.WriteLine(number);
            //Console.WriteLine(count);
            //Console.WriteLine(totalPrice);
            //Console.WriteLine(character);
            //Console.WriteLine(firstName);
            //Console.WriteLine(isWorking);
            #endregion

            #region Format String
            //Format String
            //0 represents the FIRST argument after the Format String which is byte.MinValue
            //1 represents the SECOND argument which is byte.MaxValue
            Console.WriteLine("{0} {1}", byte.MinValue, byte.MaxValue);

            //Float
            Console.WriteLine("{0} {1}", float.MinValue, float.MaxValue);
            #endregion

            //Constants
            Console.WriteLine();

        }
    }
}
