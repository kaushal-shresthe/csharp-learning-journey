using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _01_csharp_basics
{
    internal class ConsoleClass
    {
        public static void Run()
        {
            // Properties of Console Class are Title, ForgroundColor, BackGroundColor, CursorSize

            // Methods of Console Class are Clear(), Beed(), ResetColor(), Write(), WriteLine(), Read(), ReadLine(), ReadKey()
            Console.ForegroundColor = ConsoleColor.Blue;
            Console.BackgroundColor = ConsoleColor.Black;
            Console.ResetColor();
            Console.Title = "Console Class"; // Set Console Title
            string Currenttitle = Console.Title; // Get Console Title
            Console.WriteLine($"Current Title of Console is {Currenttitle}");
            Console.Beep();
            Console.Beep();
            Console.CursorSize = 50;
            Console.ReadLine();

            // ReadKey() Method 
            Console.WriteLine("Enter a Key");
            int var1 = Console.Read();
            Console.WriteLine($"ASCII Value of the Entered Key is: {var1}");
            Console.WriteLine("Enter Another Key");
            ConsoleKeyInfo var2 = Console.ReadKey();
            Console.WriteLine($"\nEntered Key: {var2.Key} KeyChar:{var2.KeyChar} ASCII:{(int)var2.KeyChar}");

            Console.WriteLine("Press any key to exit...");
            Console.ReadKey();
        }
    }
}
