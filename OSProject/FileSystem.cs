using System;
using System.Collections.Generic;
using System.Text;
using System.IO;

namespace OSProject
{
    class FileSystem
    {
        String currentp = @"0:\";

        public void makedir() // Create a folder.
        {
            String foldername;
            String currpath = Directory.GetCurrentDirectory();
            Directory.SetCurrentDirectory(currpath);
            Console.WriteLine("Enter the name of the folder you want to create.");
            foldername = Console.ReadLine();
            Directory.CreateDirectory(foldername);
        }

        public void current() // Get the current path.
        {
            String ans = Directory.GetCurrentDirectory();
            Console.WriteLine(ans);
        }

        // Fix error that can't go inside nested folders. Will have to use string concatenation kinda.
        public void changedir() // Changes the directory.
        {
            String folname;
            //String currpath = Directory.GetCurrentDirectory();
            Console.WriteLine("Enter the folder name to enter.");
            folname = Console.ReadLine();

            //if (Directory.Exists(folname))
            Directory.SetCurrentDirectory(currentp + folname); // To go back, just put the folname as blank when prompted.
            //else
                //Console.WriteLine("No such directory exists!");
        }

        public void list() // To check the list of files and folders.
        {
            String currpath = Directory.GetCurrentDirectory();
            string[] filePaths = Directory.GetFiles(currpath);

            Console.WriteLine("All files");
            for (int i = 0; i < filePaths.Length; ++i)
            {
                string path = filePaths[i];
                Console.WriteLine(System.IO.Path.GetFileName(path));
            }

            Console.WriteLine("\nAll folders");
            foreach (var d in System.IO.Directory.GetDirectories(currpath))
            {
                var dir = new DirectoryInfo(d);
                var dirName = dir.Name;

                Console.WriteLine(dirName + " <DIR>");
            }
        }

        // Bugging.
        public void deletef() // To delete files.
        {
            String currpath = Directory.GetCurrentDirectory();
            Console.WriteLine("Enter the name of the file to be deleted.");
            String fname = Console.ReadLine();

            if (File.Exists(currpath + fname))
                File.Delete(currpath + fname);
            else
                Console.WriteLine(fname + " does not exist!");
        }
        
        public void deleted() // To delete directories.
        {
            String currpath = Directory.GetCurrentDirectory();
            Console.WriteLine("Enter the name of the folder to be deleted.");
            String folname = Console.ReadLine();

            if (Directory.Exists(currpath + folname))
                Directory.Delete(currpath + folname);
            else
                Console.WriteLine(folname + " does not exist!");

        }

        public void copy() // Copies a file from a directory to a specified destination provided it exists. Over-writing not permitted.
        {
            String currpath = Directory.GetCurrentDirectory();
            Console.WriteLine("Enter the name of the file you want to copy.");
            String cpfile = Console.ReadLine();
            Console.WriteLine("Enter the destination path.");
            String dest = Console.ReadLine();

            if (File.Exists(cpfile) && Directory.Exists(dest))
                File.Copy(currpath + cpfile, dest);
            else
                Console.WriteLine("Enither the file or the destination directory does not exist!");
        }

        /*public void move() // Moves a file from a directory to a specified destination provided it exists. Bugging out idk why.
        {
            String currpath = Directory.GetCurrentDirectory();
            Console.WriteLine("Enter the name of the file you want to move.");
            String cpfile = Console.ReadLine();
            Console.WriteLine("Enter the destination path.");
            String dest = Console.ReadLine();

            if (File.Exists(cpfile) && Directory.Exists(dest))
                File.Move(currpath + cpfile, dest);    
            else
                Console.WriteLine("Enither the file or the destination directory does not exist!");
        }*/

        public void search() // Searches whether a file exists in a directory.
        {
            String currpath = Directory.GetCurrentDirectory();
            Console.WriteLine("Enter the name of the file you want to search.");
            String sfile = Console.ReadLine();

            if (File.Exists(sfile))
                Console.WriteLine("The file " + sfile + " exists in this directory!");
            else
                Console.WriteLine("The file " + sfile + " does not exist in this directory!");            
        }

        public static void checkstat() // To check the status of the file system.
        {
            string[] filePaths = Directory.GetFiles(@"0:\");
            var drive = new DriveInfo("0");

            Console.WriteLine("\nDirectory " + @"0:\");
            Console.WriteLine("\n");

            Console.WriteLine("All files");
            for (int i = 0; i < filePaths.Length; ++i)
            {
                string path = filePaths[i];
                Console.WriteLine(System.IO.Path.GetFileName(path));
            }

            Console.WriteLine("\nAll folders");
            foreach (var d in System.IO.Directory.GetDirectories(@"0:\"))
            {
                var dir = new DirectoryInfo(d);
                var dirName = dir.Name;

                Console.WriteLine(dirName + " <DIR>");
            }
            Console.WriteLine("\n");
            Console.WriteLine("Total Space");
            Console.WriteLine($"{drive.TotalSize}" + " bytes.\n");
            Console.WriteLine("Total Space Free");
            Console.WriteLine($"{drive.AvailableFreeSpace}" + " bytes.\n\n");
        }
    }
}
