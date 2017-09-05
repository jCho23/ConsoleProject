using System;
namespace ConsoleProject.ControlFlow
{
    class Randoms
    {
        static void Main(string[] args)
        {
            var random = new Random();

            for (var i = 0; i < 10; i++)
                Console.WriteLine(random.Next());
        }
    }
}
