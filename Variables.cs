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

        }
    }
}
