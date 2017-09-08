//using System;
//namespace ConsoleProject.Dates
//{
//    public class Dates
//    {
//        static void Main(string[] args)
//        {
//            var dateTime = new DateTime(2017, 1, 1);
//            var now = DateTime.Now;
//            var today = DateTime.Today;

//            Console.WriteLine("Hour: " + now.Hour);
//            Console.WriteLine("Minute: " + now.Minute);

//            //DateTime is Immutable
//            //So how do you modify DateTime?
//            //With Add Methods
//            var tomorrow = now.AddDays(1);
//            var yesterday = now.AddDays(-1);

//            //Formatting DateTime Objects to a String
//            //Google "C# DateTime Format Specifier" for more Method options
//            Console.WriteLine(now.ToString());
//        }
//    }
//}
