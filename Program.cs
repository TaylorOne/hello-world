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
            // The code provided will print ‘Hello World’ to the console.
            // Press Ctrl+F5 (or go to Debug > Start Without Debugging) to run your app.
            Console.WriteLine("Hello World,, my name is Jordon!");
            Console.WriteLine("\nWhat is your name? ");
            var name = Console.ReadLine();
            var date = DateTime.Now;

            Console.WriteLine($"\nHello, {name}, on {date:d} at {date:t}!");
            Console.WriteLine("Please enter a number: ");
            string input = Console.ReadLine();
            int a;
            int b;
            if (Int32.TryParse(input, out a))
                Console.WriteLine($"The number you entered is {a}");
            else
                Console.WriteLine("String could not be parsed.");
            Console.WriteLine("Please enter a number: ");
            input = Console.ReadLine();
            if (Int32.TryParse(input, out b))
                Console.WriteLine($"The number you entered is {b}");
            else
                Console.WriteLine("String could not be parsed.");
            Console.WriteLine("The numbers you entered ({0},{1}) add together equal {2}.", a, b, a + b);
            Console.WriteLine("\nPress any key to exit...");
            Console.ReadKey(true);
 
        }
    }
}
