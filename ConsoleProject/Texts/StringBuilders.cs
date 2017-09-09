using System;
using System.Text;

//StringBuilder
//1) Defined in System.Text
//2) A mutable String
//3) Easy and Fast to create and manipulate strings
//4) NOT for Searching

//=\
//Append()
//Insert()
//Remove()
//Replace()
//Clear()

//namespace ConsoleProject.Texts
//{
//    public class StringBuilders
//    {
//        static void Main(string[] args)
//        {
//            //You can also start the StringBuilder with a String
//            var builder = new StringBuilder("StringBuilder");

//            //**NOTE: You CANNOT search within StringBuilder**

//            //Methods of StringBuilders
//            //This '-' is repeated 10 times here
//            builder.Append('-', 10);

//            //This will insert "Header"

//            //**NOTE: Since StringBuilder(hover over Append) Returns StringBuilder,
//            //we can CHAIN these methods**
//            builder
//                .AppendLine()
//                .Append("Header")
//                .AppendLine()
//                .Append('-', 10);

//            //Replace
//            builder.Replace('-', '*');

//            //Remove
//            //This Removes the top row of characters since there are only 10
//            builder.Remove(0, 10);

//            //Insert
//            //Here we are adding 10 '-' at the beginning of the StringBuilder
//            builder.Insert(0, new string('-', 10));
//            Console.WriteLine(builder);

//            //Indexer
//            //This is how you access indiviual characters in a StringBuilder
//            //Here, we are getting the first character
//            Console.WriteLine("First Character: " + builder[0]);
//        }
//    }
//}
