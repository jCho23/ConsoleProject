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
            //Console.WriteLine("{0} {1}", byte.MinValue, byte.MaxValue);

            //Float
            //Console.WriteLine("{0} {1}", float.MinValue, float.MaxValue);
            #endregion

            #region Constants
            //Constants
            //Notice that the prefix for Constants is Const
            //const float Pi = 3.14f;
            #endregion

            #region Implict Type Conversion
            //Implict Type Conversion
            //byte b = 1;
            //int i = b;
            //Console.WriteLine(i);
            #endregion

            #region Explicit Type Conversion
            //Explict Type Conversion
            //Notice that we are CASTING byte since 1 falls into the 255 limit of byte
            //int i = 1;
            //byte b = (byte)i;
            //Console.WriteLine(b);
            #endregion

            //Non-Compatiable Types
            //Notice that we have to CONVERT the type
            var number = "1234";
            int i = Convert.ToInt32(number);
            Console.WriteLine(i);




        }
    }
}
