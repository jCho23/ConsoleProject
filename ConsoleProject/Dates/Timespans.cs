using System;
namespace ConsoleProject.Dates
{
    public class Timespans
    {
        static void Main(String[] args)
        {
            //1 hour, 2 min, 3 sec
            var timeSpan = new TimeSpan(1, 2, 3);
            var timeSpanNoValue = new TimeSpan(1, 0, 0);

            //To make the code above more clear,
            //Use the static methods on the TimeSpan Structure
            var timeSpanNoValue2= TimeSpan.FromHours(1);
        }
    }
}
