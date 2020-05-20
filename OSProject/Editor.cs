using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.IO;
using System.Windows.Input;
using Sys = Cosmos.System;
using System.Threading;
using Cosmos.Core.IOGroup;

namespace OSProject
{
    class Editor
    {
        // The current text inside the editor is stored in a string
        public static string text = "";
        // Boolean to see whether Editor is running or not
        public static bool running = true;
        private static void DrawScreen()
        {
            Console.Clear();
            Console.CursorTop = 0;
            Console.BackgroundColor = ConsoleColor.Gray;
            Console.WriteLine(" Text Editor ");
            Console.Clear();
            Console.CursorTop = 3;
        }
        //Main method for editor
        public static void Main()
        {
            Console.WriteLine("1.Create a new file\n2.Open an existing file\n3.Delete a file\n4.View all files\n5.Exit");
            string c = Console.ReadLine();
            if (c == "1")
            {
                Console.WriteLine("Enter file name you want to create:");
                string file = Console.ReadLine();
                Run(file);
            }
            else if(c == "2")
            {
                Console.WriteLine("Enter file you want to view:");
                string file = Console.ReadLine();
                ViewFile(file);
            }
            else if (c == "3")
            {
                Console.WriteLine("Enter file you want to delete:");
                string file = Console.ReadLine();
                DeleteFile(file);
            }
            else if(c == "4")
            {
                AllFiles();
            }
            return;
        }
        public static void AllFiles()
        {
            string[] files = Directory.GetFiles(@"0:\");
            foreach(string fileName in files)
            {
                Console.WriteLine(fileName);
            }
            Console.WriteLine("Press Enter to continue");
            if (Console.ReadKey().Key == ConsoleKey.Enter)
            {
                Console.Clear();
                Main();
            }
                
        }
        public static void DeleteFile(string file)
        {
            DrawScreen();
            if (File.Exists(@"0:\" + file))
            {
                File.Delete(@"0:\" + file);
                Console.WriteLine("File successfully deleted!");
                Console.WriteLine("Press Enter to continue");
                if (Console.ReadKey().Key == ConsoleKey.Enter)
                {
                    Console.Clear();
                    Main();
                }
            }
            else if (!File.Exists(@"0:\" + file))
            {
                Console.WriteLine("No such file exists!");
                Console.WriteLine("Press Enter to continue");
                if(Console.ReadKey().Key == ConsoleKey.Enter)
                {
                    Console.Clear();
                    Main();
                }
            }
        }
        public static void ViewFile(string file)
        {
            DrawScreen();
            try
            {
                if (File.Exists(@"0:\" + file))
                {
                    string[] lines = File.ReadAllLines(@"0:\" + file);
                    foreach (string line in lines)
                    {
                        Console.WriteLine(line);
                        if (Console.ReadKey().Key == ConsoleKey.Enter)
                        {
                            Console.Clear();
                            Main();
                        }
                    }
                }
                else if (!File.Exists(@"0:\" + file))
                {
                    Console.WriteLine("File doesn't exist!!");
                    Console.WriteLine("Press Enter to continue");
                    if (Console.ReadKey().Key == ConsoleKey.Enter)
                    {
                        Console.Clear();
                        Main();
                    }
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
            Main();
        }
        public static void Run(string file)
        {
            DrawScreen();
            Console.WriteLine("Welcome to Trieme text editor!");
            Console.WriteLine("Once you have finished you can type '@SAVE' to save your file or '@END'");
            Console.WriteLine("to close without saving. '@RESET' can be used to reset the file");
            Console.WriteLine("Press Enter key to begin!");
            if (Console.ReadKey().Key == ConsoleKey.Enter)
            {
                DrawScreen();
                text = "";
                string line;
                var num = 1;
                while (running == true)
                {
                    Console.Write(num + ": ");
                    num = num + 1;
                    line = Console.ReadLine();
                    if (line == "@END")
                    {
                        Console.WriteLine("Would you like to save first?");
                        string notsaved = Console.ReadLine();
                        if (notsaved == "y")
                        {
                            File.Create(@"0:\" + file);
                            File.WriteAllText(@"0:\" + file, text);
                            Console.WriteLine("File saved!!");
                            running = false;
                            break;
                        }
                        else if (notsaved == "n")
                        {
                            running = false;
                            break;
                        }
                    }
                    if (line == "@RESET")
                    {
                        text = "";
                        DrawScreen();
                    }
                    if (line == "@SAVE")
                    {
                        File.Create(@"0:\" + file);
                        File.WriteAllText(@"0:\" + file, text);
                        running = false;
                        break;
                    }
                    text = text + (Environment.NewLine + line);
                    if (Console.CursorTop == 24)
                    {
                        DrawScreen();
                    }
                }
                Console.BackgroundColor = ConsoleColor.Black;
                running = true;
                Console.Clear();
                Main();
            }
        }
    }
}