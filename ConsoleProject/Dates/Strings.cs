using System;

#region Formatting
//Formatting
//ToLower() "hello world"
//ToUpper() "HELLO WORLD"
//Trim() Gets rid of white space around the String
#endregion

#region Searching
//Searching
//Both these Methods have Overloads and they accept Characters and Strings
//And they Return an Index of the First or Last character in the String
//IndexOf('a')
//LastIndexOf("Hello")
#endregion

#region SubStrings
//SubStrings
//These methods have a couple of overloads
//Substring(startIndex) <Retrives all the characters in the string>
//Substring(startIndex, length) <the length arguement here limits the amount of characters to retrive>
#endregion

#region Replacing
//Replacing
//Replace ('a', '!')
//i.e Replace ('june', 'june23')
#endregion

#region NullChecking
//Null Checking
//String.IsNullOrEmpty(str)
//String.ISNullOrWhiteSpace(str)
#endregion

#region Splitting
//Splitting
//Summarize longer String into a shorter one
//str.Split(' ')
#endregion

#region ConvertingStringsToNumbers
//Converting Strings to Numbers
//string s = "1234";
//Here, these are the two ways to Convert Strings to Numbers
//int i = int.Parse(s);
//Easier and safer to use Int32 becuase if the string is null or empty,
//This method returns the default value, which is 0
//int j = Convert.Int32(s);
#endregion

#region ConvertingNumbersToStrings
//Converting Numbers to Strings
//int i = 1234;

//string s = i.ToString(); == "1234"
//You can use Format String
//Here, "C" represents Currency
//string t =i.ToString("C"); == "$1,234.00"
//IF you don't want decimal points, you can use "C0"
//string t = i.ToString("C0"); == "$1,234"
#endregion

namespace ConsoleProject.Dates
{
    class StringsDemo
    {
        static void Main(string[] args)
        {
            //Note that there is a White-Space character at the end of this string
            var fullName = "June Cho ";

            //This Trims the White-Space Before or After the String
            Console.WriteLine("Trim: '{0}'", fullName.Trim());

            //Changes String to ALL-CAPS
            Console.WriteLine("ToUpper: '{0}'", fullName.ToUpper());

            //This is how you split Strings, in this case fullName
            //Notice that we are using SubString here
            var index = fullName.IndexOf(' ');
            var firstName = fullName.Substring(0, index);
            var lastName = fullName.Substring(index + 1);
            Console.WriteLine("First Name: " + firstName);
            Console.WriteLine("Last Name: " + lastName);

            //This code is the same as above BUT
            //We are using the Split String
            var names= fullName.Split(' ');
            Console.WriteLine("First Name: " + names[0]);
            Console.WriteLine("Last Name: " + names[1]);

            //Replace
            //All these Method calls returns NEW strings
            Console.WriteLine(fullName.Replace("June", "MJ"));

            //Validating
            //NullOrWhiteSpace takes care of the space for entry fields
            if (String.IsNullOrWhiteSpace(" "));
                Console.WriteLine("Invalid");

        }
    }
}
