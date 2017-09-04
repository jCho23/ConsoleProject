﻿using System;
using System.Runtime.InteropServices;

namespace ConsoleProject
{
    //Strings are Immutable
    //Once created, Strings can't be changed 
    public class Strings
    {
		#region StringFormat
		//string firstName = "June";

		//StringFormat
		//Placeholders are indicated by curly braces {}
		//string name = string.Format("{0} {1}", firstName, lastName);
		#endregion

		#region Using StringJoin
		//Using String Join
		//var numbers = new int[3] { 1, 2, 3 };
		//First argument is a sepeator
		//Second argument is the array that we want to combine
		//string list = string.Join(",", numbers);
		#endregion

		//VerbatimStrings

		//string path = "c:\\projects\\project1\\folder1";
		//The @ symbol creates VerbatimStrings
		//string path = @"c:\projects\projects1\folder1";



    }
}