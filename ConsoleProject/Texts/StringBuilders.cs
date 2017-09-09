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

namespace ConsoleProject.Texts
{
    public class StringBuilders
    {
        static void Main(string[] args)
        {
            var builder = new StringBuilder();
            //Methods of StringBuilders
            //This '-' is repeated 10 times here
            builder.Append('-', 10);

            //This will insert "Header"
            builder.AppendLine();
            builder.Append("Header");
            builder.AppendLine();
            builder.Append('-', 10);

            //Replace
            builder.Replace('-', '*');

            Console.WriteLine(builder);
        }
    }
}
