using System;
namespace ConsoleProject.ControlFlow
{
    class Randoms
    {
        static void Main(string[] args)
        {
            //var random = new Random();

            ////Here, "random.Next" has multiple types
            //for (var i = 0; i < 10; i++)
            ////We are CASTING "char" to get a character from the random number
            //Console.Write((char)random.Next(97, 122));

            ////"0, 26" represents the 26 letters in the alphabet
            //Console.Write((char)('a'+random.Next(0, 26)));

            //Storing results in Array and Creating a String from that Array
            var random = new Random();
            //This is a char Array called buffer (highlight var)
			var buffer = new char[10];

            for (var i = 0; i < 10; i++) 
			Console.Write((char)('a'+random.Next(0, 26)));





		}
    }
}
