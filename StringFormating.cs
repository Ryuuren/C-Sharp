using System;

namespace app
{
    class Program
    {
        static void Main(string[] args)
        {
            // Escape sequences will insert special characters at runtime, that affect string outputs.
            // C# escape sequences begin with \
            // \n adds a new line
            // \t adds a tab
            //
            Console.WriteLine("Hello\nWorld!");
            Console.WriteLine("Hello\tWorld!");
            //
            // \" escapes quotes in a string, allowing for extra quotes:
            Console.WriteLine("Hello \"World\"!");
            // Output of the above is Hello "World"!
            // \\ displays a single \, to display things like file paths:
            Console.WriteLine("c:\\users\\bob");
            // Output of the above is c:\users\bob
            //
            // A verbatim string literal starts with @ and keeps all whitespace and characters, so backslashes aren't required:
            Console.WriteLine(@"    Look here: 
            c:\users\bob");
            //
            // Encoded characters can be added in literal strings using \u and a four-character code
            // These codes represent a character in UTF-16, such as Japanese characters:
            Console.WriteLine("\u3053\u3093\u306B\u3061\u306F World!");
            // The above will display こんにちは World!
            // Some characters require UTF-32 and not all consoles will display these characters properly.
            //
            // String interpolation uses a template to concatenate multiple values into a single literal string
            string greeting = "Hello";
            string firstName = "Mitchell";
            // Instead of writing:
            // string message = greeting + " " + firstName + "!";
            // Use string interpolation via the $ and {} syntax, to combine strings, variables, etc. concisely:
            string message = $"{greeting} there, {firstName}!";
            Console.WriteLine(message);
            // Hello there, Mitchell!
            // String interpolation can be directly logged, without needing the intermediate variable, like so:
            Console.WriteLine($"{greeting} there, {firstName}!");
            //
            // Finally, you can combine verbatim literals with string interpolation:
            string projectName = "First-Project";
            Console.WriteLine($@"C:\Output\{projectName}\Data");
            // The above lets us reference the variable for the file path, while also avoiding the need for escape characters by using @
        }
    }
}
