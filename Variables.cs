using System;

namespace app
{
    class Program
    {
        static void Main(string[] args)
        {
            // Variables in C# are declared by first defining the data type, then giving it a name:
            int myAge;
            // The variable is then assigned a value matching it's data type.
            myAge = 32;
            // The value of the variable can be retrieved like so:
            Console.WriteLine("I am " + myAge + " years old.");
            // The variable value can be reassigned:
            myAge = 33;
            // This next WriteLine will use the latest value of 33:
            Console.WriteLine("Next year I will be " + myAge + " years old!");
            //
            // Variables can be initialised, declaring and setting the value in one line:
            string myName = "Mitchell";
            Console.WriteLine("My name is " + myName + ".");
            //
            // C# Variables have the following naming conventions:
            //
            // Are generally defined in camelCase
            // Can contain any alphanumeric character and _
            // Cannot contain # or $
            // Must begin with an alphanumeric or _, not a number ( _ is generally for special cases)
            // Variables are case sensitive.
            // Must not be a C# keyword, e.g. string string
            // 
            // Variables can also be implicitly typed, that is, it's data type is implied by the assigned value:
            var myGreeting = "Hello World!";
            // myGreeting will be typed as string and cannot be changed
            // Other languages like JavaScript use var differently.
            // In C#, variables are type locked upon declaration, whether explicitly or implicitly typed.
            // Variables declared with var must be initialised:
            // var = message;
            // Logging the above variable will result in an error as it was not initialised with a value and thus cannot be implicitly typed.
            Console.WriteLine("I'm using C# to write " + myGreeting);
            //
            // The var keyword is useful in C# if the variable type is obvious when initialised, or during development when required types are still ambigiuous.
        }
    }
}
