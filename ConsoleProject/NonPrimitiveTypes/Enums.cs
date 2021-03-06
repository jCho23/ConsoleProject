﻿//using System;

//namespace ConsoleProject
//{
    #region Enums
    //Enum is a set of name/vale pairs (constants)

    //const int RegularAirMail = 1;
    //const int RegisteredAirMail = 2;
    //const int Express = 3;

    //This is an Enum statement that is the same as above
    //Use Enums when you have a number of related constants
    //public enum ShippingMethod
    //{
    //    RegularAirMail = 1,
    //    RegisteredAirMail = 2,
    //    Express = 3;
    //}

    //Enums are internally an integer
    //var method = ShippingMethod.Express;
    #endregion

    #region EnumsInt
    //This is how you convert an enum TO and FROM an int

    //public enum ShippingMethod
    //{
    //    RegularAirMail = 1,
    //    RegisteredAirMail = 2,
    //    ExpressMail = 3
    //}

    //class EnumsDemo
    //{
    //    static void Main(string[] args)
    //    {
    //        var method = ShippingMethod.ExpressMail;
    //        //Here we are CASTING method to an int
    //        //This will output the consol to 3, ExpressMail
    //        Console.WriteLine((int)method);

    //        //We are converting the number (methodId) into a ShippingMethod
    //        //Thus we are using CASTING to convert an integer to a ShippingMethod
    //        var methodId = 3;
    //        Console.WriteLine((ShippingMethod)methodId);
    //    }
    //}
    #endregion

    #region EnumsString
    //public enum ShippingMethod
    //{
    //    RegularAirMail = 1,
    //    RegisteredAirMail = 2,
    //    Express = 3
    //}

    //class EnumsString
    //{
    //    static void Main(string[] args)
    //    {
    //        var method = ShippingMethod.Express;
    //        Console.WriteLine((int)method);

    //        var methodId = 3;
    //        Console.WriteLine((ShippingMethod)methodId);

    //        //ToString converts an enum to a string
    //        Console.WriteLine(method.ToString());

    //        //This is how you turn a string into an enum
    //        //Parsing= String coverting into different types
    //        var methodName = "Express";
    //        //Notice that Parse has two objects
    //        //typeOf can be used with "Type" objects
    //        var shippingMethod = (ShippingMethod)Enum.Parse(typeof(ShippingMethod),methodName);
    //    }
    //}
    #endregion
//}
