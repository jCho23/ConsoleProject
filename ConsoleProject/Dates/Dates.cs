using System;
namespace ConsoleProject.Dates
{
    public class Dates
    {
        static void Main(string[] args)
        {
            var dateTime = new DateTime(2017, 1, 1);
            var now = DateTime.Now;
            var today = DateTime.Today;

            Console.WriteLine("Hour: " + now.Hour);
            Console.WriteLine("Minute: " + now.Minute);

        }
    }
}
