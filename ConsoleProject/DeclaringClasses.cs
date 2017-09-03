using System;
using System.Linq.Expressions;
namespace ConsoleProject
{
    public class DeclaringClasses
    {
        //creating Objects
        //Objects are INSTANCES of Classes
        public DeclaringClasses()
        {
            int number;

            Person person = new Person();
            //this is the same as above BUT cleaner
            var person = new Person();
        }
    }
}
