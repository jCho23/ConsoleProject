using System;

//Formatting
//ToLower() "hello world"
//ToUpper() "HELLO WORLD"
//Trim() Gets rid of white space around the String

//Searching
//Both these Methods have Overloads and they accept Characters and Strings
//And they Return an Index of the First or Last character in the String
//IndexOf('a')
//LastIndexOf("Hello")

//SubStrings
//These methods have a couple of overloads
//Substring(startIndex) <Retrives all the characters in the string>
//Substring(startIndex, length) <the length arguement here limits the amount of characters to retrive>

//Replacing
//Replace ('a', '!')
//i.e Replace ('june', 'june23')

//Null Checking
//String.IsNullOrEmpty(str)
//String.ISNullOrWhiteSpace(str)

//Splitting
//Summarize longer String into a shorter one
//str.Split(' ')

//Converting Strings to numbers
//string s = "1234";
//Here, these are the two ways to Convert Strings to Numbers
//int i = int.Parse(s);
//Easier and safer to use Int32 becuase if the string is null or empty,
//This method returns the default value, which is 0
//int j = Convert.Int32(s);

namespace ConsoleProject.Dates
{
    public class Strings
    {
        public Strings()
        {
        }
    }
}
