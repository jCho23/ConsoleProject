using System;

//System.IO

//Common Classes
//File, FileInfo: Provide methods for creating, copying, deleting, moving, and opening of files
//File: Provides STATIC Methods (good for small operations)
//FileInfo: Provides INSTANCE Methods (large number of operations)

//Directory, DirectoyInfo
//Directory: Provides STATIC Methods (good for small operations)
//DirectoryInfo: Provides INSTANCE Methods (large number of operations)

//Path: Provides Methods to work with a String that contains a File or Directory Path information
using System.IO;
using System.Runtime.InteropServices;

namespace ConsoleProject.FilesAndDirectory
{
    public class SystemIONamespace
    {
        //File and FileInfo
        //static void Main(string[] args)
        //{
        ////File (Static Methods)
        //var path = @"c:\somefile.jpg";

        //File.Copy(@"c:\temp\myfile.jpg", @"d:\temp\myfile.jpg", true);

        //File.Delete(path);
        //if (File.Exists(path))
        //{
        //    //
        //}
        //var content = File.ReadAllText(path);


        ////FileInfo (Instance Methods)
        //var fileInfo = new FileInfo(path);
        //fileInfo.CopyTo("...");
        //fileInfo.Delete();

        ////This is not a Method, this is a Property
        //if (fileInfo.Exists)
        //{
        //    //
        //}

        //Directory and DirectoryPath


        static void Main(string[] args)
        {
			var path = @"c:\temp\someFile";

            Directory.CreateDirectory(path);
        }

    }
}
