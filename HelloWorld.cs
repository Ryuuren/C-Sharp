// using System; allows the program to access classes and methods defined in the System namespace, including the Console class used in this program.
using System;

namespace app
{
    // The Program class is the entry point of the application.
    class Program
    {
        // The Main method is the entry point of the program. It takes an array of strings 'args' as a parameter.
        static void Main(string[] args)
        {
            // WriteLine - Adds a line feed for each statement
            Console.WriteLine("Hello World!");

            // Write - Doesn't add line feeds, so all three statements will appear on one line.
            Console.Write("Congratulations!");
            Console.Write(" ");
            Console.Write("You wrote your first lines of code.");
        }
    }
}
