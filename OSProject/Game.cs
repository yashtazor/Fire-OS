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
    class Game
    {
        static string[] pos = new string[10] { "0", "1", "2", "3", "4", "5", "6", "7", "8", "9" };
        public static void UpdateBoard()
        {
            Console.Clear();
            Console.WriteLine("   {0}  |  {1}  |  {2}   ", pos[1], pos[2], pos[3]);
            Console.WriteLine("-------------------");
            Console.WriteLine("   {0}  |  {1}  |  {2}   ", pos[4], pos[5], pos[6]);
            Console.WriteLine("-------------------");
            Console.WriteLine("   {0}  |  {1}  |  {2}   ", pos[7], pos[8], pos[9]);
        }
        public static void Main()
        {
            Console.Clear();
            Console.WriteLine("Welcome to tic-tac-toe");
            Console.WriteLine("Select Player 1 name..");
            string n1 = Console.ReadLine();
            Console.WriteLine("Select Player 2 name..");
            string n2 = Console.ReadLine();
            string p1 = "X";
            string p2 = "O";
            bool win = false;
            int count = 0;
            while(!win)
            {
                UpdateBoard();
                Console.WriteLine(n1 + " \'s turn:"+p1);
                Console.WriteLine("Enter position to place");
                int pos1 = int.Parse(Console.ReadLine());
                pos[pos1] = p1;
                UpdateBoard();
                //Checking condition
                if((pos[1]==pos[2])&&(pos[2]==pos[3]))
                {
                    Console.WriteLine(n1 + " Wins!");
                    break;
                }
                else if((pos[4] == pos[5]) && (pos[5] == pos[6]))
                {
                    Console.WriteLine(n1 + " Wins!");
                    break;
                }
                else if ((pos[7] == pos[8]) && (pos[8] == pos[9]))
                {
                    Console.WriteLine(n1 + " Wins!");
                    break;
                }
                else if ((pos[1] == pos[4]) && (pos[4] == pos[7]))
                {
                    Console.WriteLine(n1 + " Wins!");
                    break;
                }
                else if ((pos[2] == pos[5]) && (pos[5] == pos[8]))
                {
                    Console.WriteLine(n1 + " Wins!");
                    break;
                }
                else if ((pos[3] == pos[6]) && (pos[6] == pos[9]))
                {
                    Console.WriteLine(n1 + " Wins!");
                    break;
                }
                else if ((pos[1] == pos[5]) && (pos[5] == pos[9]))
                {
                    Console.WriteLine(n1 + " Wins!");
                    break;
                }
                else if ((pos[3] == pos[5]) && (pos[5] == pos[7]))
                {
                    Console.WriteLine(n1 + " Wins!");
                    break;
                }
                else if ((pos[1] == pos[2]) && (pos[2] == pos[3]))
                {
                    Console.WriteLine(n1 + " Wins!");
                    break;
                }
                else
                {
                    count = count + 1;
                }
                if (count == 9)
                    break;
                UpdateBoard();
                Console.WriteLine(n2 + " \'s turn:" + p2);
                Console.WriteLine("Enter position to place");
                int pos2 = int.Parse(Console.ReadLine());
                pos[pos2] = p2;
                UpdateBoard();
                //Checking condition
                if ((pos[1] == pos[2]) && (pos[2] == pos[3]))
                {
                    Console.WriteLine(n2 + " Wins!");
                    break;
                }
                else if ((pos[4] == pos[5]) && (pos[5] == pos[6]))
                {
                    Console.WriteLine(n2 + " Wins!");
                    break;
                }
                else if ((pos[7] == pos[8]) && (pos[8] == pos[9]))
                {
                    Console.WriteLine(n2 + " Wins!");
                    break;
                }
                else if ((pos[1] == pos[4]) && (pos[4] == pos[7]))
                {
                    Console.WriteLine(n2 + " Wins!");
                    break;
                }
                else if ((pos[2] == pos[5]) && (pos[5] == pos[8]))
                {
                    Console.WriteLine(n2 + " Wins!");
                    break;
                }
                else if ((pos[3] == pos[6]) && (pos[6] == pos[9]))
                {
                    Console.WriteLine(n2 + " Wins!");
                    break;
                }
                else if ((pos[1] == pos[5]) && (pos[5] == pos[9]))
                {
                    Console.WriteLine(n2 + " Wins!");
                    break;
                }
                else if ((pos[3] == pos[5]) && (pos[5] == pos[7]))
                {
                    Console.WriteLine(n2 + " Wins!");
                    break;
                }
                else if ((pos[1] == pos[2]) && (pos[2] == pos[3]))
                {
                    Console.WriteLine(n2 + " Wins!");
                    break;
                }
                else
                {
                    count = count + 1;
                }
                if (count == 9)
                    break;
            }
            if(count==9)
            {
                Console.WriteLine("Its a draw!!");
            }
            for(int i=1;i<=9;i++)
            {
                pos[i] = i.ToString();
            }
            Console.WriteLine("Press Enter to play again and any other key to exit!");
            if(Console.ReadKey().Key==ConsoleKey.Enter)
            {
                Main();
            }
            else
            {
                Console.Clear();
                return;
            }
        }
    }
}