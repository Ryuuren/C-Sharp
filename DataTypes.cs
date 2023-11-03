using System;

namespace app
{
    class Program
    {
        static void Main(string[] args)
        {
            // Double Quotes (" ") - String Data Type            
            Console.WriteLine("Hello World!");

            // Single Quotes (' ') - Character/Char Literal Type
            Console.WriteLine('A');

            // Number Value (123) - Integer/Int Data Type
            Console.WriteLine(123);

            // Floating Point - Decimal Number Type
            // There are three types of floating point:
            //
            // Float - ~6-9 digits
            // Double - ~15-17 digits
            // Decimal - 28-29 digits
            //
            // Float Literal (f/F) - Suffix for float type
            Console.WriteLine(0.25F);
            // Float is least precise - Best for fixed values
            //
            // Double Literal (.) - No suffix for double type
            Console.WriteLine(2.625);
            //
            // Decimal Literal (m/M) - Suffix for decimal type
            Console.WriteLine(12.39816m);
            //
            // Boolean Literal (true/false) - Boolean/Bool Data Type
            Console.WriteLine(true);
            Console.WriteLine(false);
            //
            // Data Types are enforced in C# to avoid data ambiguity, of which can occur in languages like JavaScript.
        }
    }
}
