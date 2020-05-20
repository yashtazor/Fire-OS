using System;
using System.Collections.Generic;
using System.Text;

namespace OSProject
{
    class Calculator
    {
        public static void main()
        {
            Boolean checker = true;
            double a, b;
            String choice, exitornah;

            while(checker)
            {
                Console.WriteLine("Enter two numbers");
                a = double.Parse(Console.ReadLine());
                b = double.Parse(Console.ReadLine());

                starter:

                Console.WriteLine("Operation?\n");
                Console.WriteLine("1. Addition");
                Console.WriteLine("2. Subtraction");
                Console.WriteLine("3. Multiplication");
                Console.WriteLine("4. Division");
                Console.WriteLine("5. Modulus");
                Console.WriteLine("6. Power");
                /*Console.WriteLine("7. LCM");
                Console.WriteLine("8. HCF");*/ // If time, then code.

                choice = Console.ReadLine();

                switch(choice)
                {
                    case "1": // Add.
                        Console.WriteLine((a + b).ToString());
                        break;

                    case "2":
                        Console.WriteLine(a - b);
                        break;

                    case "3":
                        Console.WriteLine(a * b);
                        break;

                    case "4":
                        if (b == 0)
                            Console.WriteLine("Divison by 0 not possible!");
                        else
                            Console.WriteLine(a / b);
                        break;

                    case "5":
                        Console.WriteLine((a % b).ToString());
                        break;

                    case "6":
                        Console.WriteLine(Math.Pow(a, b));
                        break;

                    default:
                        goto starter;
                        break;
                        
                }

                Console.WriteLine("More calculations?");
                Console.WriteLine("Y - YES");
                Console.WriteLine("N - NO");

                exitornah = Console.ReadLine();

                if (exitornah == "N")
                    checker = false;
                else
                    checker = true;
            }
            Console.Clear();
            return;
        }
    }
}
