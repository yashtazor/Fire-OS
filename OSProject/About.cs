using System;
using System.Collections.Generic;
using System.Text;

namespace OSProject
{
    class About
    {
        public static void main()
        {
            Console.WriteLine("\nVersion 1.0.0\n");
            Console.WriteLine("This miniature operating system has been created as a part of J-Componenet ");
            Console.WriteLine("for the course Operating Systems.\n");
            Console.WriteLine("This OS has been made so as to give a feel for miniature OS containing");
            Console.WriteLine("features like file system, basic display drivers, some programs like paint,");
            Console.WriteLine("calculator & music player and games like XnO. Obviously, it also has the most");
            Console.WriteLine("important shutdown and reboot features as well!\n");
            Console.WriteLine("We hope you enjoy using our mini-OS.\n\n");
            Console.WriteLine("Created & Copyrighted by");
            Console.WriteLine("Ayanabha Jana\t\tYash Dekate ");
            Console.WriteLine("18BCE1044\t\t\t18BCE1307\n");
            Console.WriteLine("Vellore Institute of Technology, Chennai.");
            if(Console.ReadKey().Key == ConsoleKey.Enter)
                    return;
        }
    }
}
