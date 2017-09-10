//using System;

//System.IO

//Common Classes
//File, FileInfo: Provide methods for creating, copying, deleting, moving, and opening of files
//File: Provides STATIC Methods (good for small operations)
//FileInfo: Provides INSTANCE Methods (large number of operations)

//Directory, DirectoyInfo
//Directory: Provides STATIC Methods (good for small operations)
//DirectoryInfo: Provides INSTANCE Methods (large number of operations)

//Path: Provides Methods to work with a String that contains a File or Directory Path information
//using System.IO;
//using System.Runtime.InteropServices;

//namespace ConsoleProject.FilesAndDirectory
//{
    //public class SystemIONamespace
    //{
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


        //static void Main(string[] args)
        //{
        ////Directory
        //    var path = @"c:\users\junecho\projects";

        //    Directory.CreateDirectory(path);
        //    //Here, "*.*" means ALL FILES, you also search by File Types (i.e. "*.sln*")
        //    var files = Directory.GetFiles(path, "*.*", SearchOption.AllDirectories);
        //    foreach (var file in files)
        //        Console.WriteLine(file);

        //    var directories = Directory.GetDirectories(path, "*.*", SearchOption.AllDirectories);
        //    foreach (var directory in directories)
        //        Console.WriteLine(directory);

        //    Directory.Exists("...");


        ////DirectoryInfo
        //    var directoryInfo = new DirectoryInfo("...");
        //    directoryInfo.GetFiles();
        //    directoryInfo.GetDirectories();
        //}


        ////Path
        //static void Main(string[] args)
        //{
        //    var path = @"c:\projects\someFile\ConsoleProject.sln";

        //    //Here, I can use PATH to get the extension of the file (.sln)
        //    Console.WriteLine("Extension: " + Path.GetExtension(path)); 

        //    //GetFileName
        //    Console.WriteLine("File Name: " +Path.GetFileName(path));

        //    //GetFileNameWithoutExtension
        //    Console.WriteLine("File Name without Extension: " + Path.GetFileNameWithoutExtension(path));

        //    //GetDirectoryName
        //    Console.WriteLine("Directory Name: " + Path.GetDirectoryName(path));
        //}

//    }
//}
