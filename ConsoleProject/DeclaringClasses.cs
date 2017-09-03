﻿using System;
using System.Linq.Expressions;

namespace ConsoleProject
{
    //We created a new class here
    public class Person
    {
        //Here we are delaring a couple of Fields
        public string FirstName;
        public string LastName;

        public void Introduce()
        {
            Console.WriteLine("My name is" + FirstName + "" + LastName);
        }
    }

    class DeclaringClasses
    {
        #region CreatingObjects
        //creating Objects
        //Objects are INSTANCES of Classes

        //public DeclaringClasses()
        //{
        //    int number;

        //    Person person = new Person();
        //    //this is the same as above BUT cleaner
        //    var person = new Person();
        //}
        #endregion

        #region StaticModifier
        //Static Modifier
        //We use Static Modifiers when we only want ONE Instance of 
        //that object in memory
        //class Program
        //{
        //    //We use Static here because we only want ONE Instance of Main
        //    //Another Example to use Static is Date/Time
        //    //Static also allows you to access the member of the class itself
        //    static void Main()
        //    {

        //    }
        //}
        #endregion

        static void Main (string[] args)
        {
            
        }
    }
}
