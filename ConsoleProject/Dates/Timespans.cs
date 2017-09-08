using System;
namespace ConsoleProject.Dates
{
    public class Timespans
    {

        static void Main(String[] args)
        {   //Creating TimeSpan Objects
            //1 hour, 2 min, 3 sec
            var timeSpan = new TimeSpan(1, 2, 3);
            var timeSpanNoValue = new TimeSpan(1, 0, 0);

            //To make the code above more clear,
            //Use the static methods on the TimeSpan Structure
            var timeSpanNoValue2 = TimeSpan.FromHours(1);

            //IF you have 2 DateTime objects,
            //And you subtract them...
            //The Result is a TimeSpan
            var start = DateTime.Now;
            var end = DateTime.Now.AddMinutes(2);
            var duration = end - start;

            Console.WriteLine("Duration: " + duration);


            //TimeSpan Properties
            //timeSpan. = Properties

            //Pair Properties that start with "Total"
            //Here, the "Minutes" property returns the minutes componet of the TimeSpan Object
            //Since we have TimeSpan(1, 2, 3) above, the TimeSpan Object is 2 
            Console.WriteLine("Minutes: " + timeSpan.Minutes);

            //TotalMinutes converts the same TimeSpan Object to TOTAL MINUTES of that Object
            //Thus 1= 60min
            //2= 2min
            //3=  3sec
            //==62.05
            Console.WriteLine("Total Minutes: " + timeSpan.TotalMinutes);

            //ADD
            //Modify TimeSpan Methods
            //Here == 1 hour, 10 min, and 3 sec
            Console.WriteLine("Add Example: "+ timeSpan.Add(TimeSpan.FromMinutes(8)));

            //Subtract
            //Here == 1 hour, 3sec
            Console.WriteLine("Subtract Example: " + timeSpan.Subtract(TimeSpan.FromMinutes(2)));

            //Convert TimeSpan to String
            //Use ToString Method
            Console.WriteLine("ToString" + timeSpan.ToString());
        }


    }
}
