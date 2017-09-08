using System;
namespace ConsoleProject.Dates
{
    public class Timespans
    {
        //Creating TimeSpan Objects
        static void Main(String[] args)
        {
            //1 hour, 2 min, 3 sec
            var timeSpan = new TimeSpan(1, 2, 3);
            var timeSpanNoValue = new TimeSpan(1, 0, 0);

            //To make the code above more clear,
            //Use the static methods on the TimeSpan Structure
            var timeSpanNoValue2= TimeSpan.FromHours(1);

            //IF you have 2 DateTime objects,
            //And you subtract them...
            //The Result is a TimeSpan
            var start = DateTime.Now;
            var end = DateTime.Now.AddMinutes(2);
            var duration = end - start; 

            Console.WriteLine("Duration: " + duration);

        }
    }
}
