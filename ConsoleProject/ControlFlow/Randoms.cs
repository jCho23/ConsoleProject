using System;
namespace ConsoleProject.ControlFlow
{
    class Randoms
    {
        static void Main(string[] args)
        {
            var random = new Random();

            //Here, "random.Next" has multiple types
            for (var i = 0; i < 10; i++)
                //We are CASTING "char" to get a character from the random number
                Console.WriteLine((char)random.Next(97, 122));


        }
    }
}
