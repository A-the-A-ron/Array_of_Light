using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] Medals = new string[3];
            for (int i = 0; i < 3; i++)
            {
                if (i == 0) { Console.WriteLine("Enter the Gold medal winner:"); }
                else if (i == 1) { Console.WriteLine("Enter the Silver medal winner:"); }
                else { Console.WriteLine("Enter the Bronze medal winner:"); }
                Medals[i] = Console.ReadLine();
            }
            Console.WriteLine("Thank you.");
            string theywanttoleave = "no";
            do
            {
                Console.WriteLine(); Console.WriteLine();
                Console.WriteLine("What medal winner would you like to see:");
                Console.WriteLine("1.Gold");
                Console.WriteLine("2.Silver");
                Console.WriteLine("3.Bronze");
                Console.WriteLine("0.exit");
                string caseSwitch = Console.ReadLine();
                switch (caseSwitch)
                {
                    case "1":
                        Console.WriteLine("The Gold medal winner was " + Medals[0]);
                        break;
                    case "2":
                        Console.WriteLine("The Silver medal winner was " + Medals[1]);
                        break;
                    case "3":
                        Console.WriteLine("The Bronze medal winner was " + Medals[2]);
                        break;
                    case "0":
                        theywanttoleave = "yes";
                        break;
                    default:
                        Console.WriteLine("Invalid input.");
                        break;

                }
            } while (theywanttoleave == "no");
            Console.Clear();
            Console.WriteLine("Goodbye");
            Console.ReadKey();

        }
    }
}
