using System;

namespace app
{
    class Program
    {
        static void Main(string[] args)
        {
            int value = 0;
            // Adding 5 to the current value
            value = value + 5; // The same as value += 5;
            // Output: 10
            Console.WriteLine(value);

            // Incrementing the value by 1
            value++;
            // Output: 11
            Console.WriteLine(value);

            // Arithmetic operations (* and /) work similarly for updating values

            // Increment and decrement operators can be used before or after the variable.
            // ++value increments the value before it's used, while value++ increments the value after it's used.

            // Example demonstrating the difference between prefix and postfix increments:

            int counter = 1;
            counter++; // Incrementing counter by 1
            // Output: 2 - The result of counter++ above is logged here
            Console.WriteLine("First: " + counter);
            // Output: 2 - The value of counter is returned and then incremented, so it remains 2 in this line
            Console.WriteLine($"Second: {counter++}");
            // Output: 3 - The increment was performed in the previous line, so the value of counter is now 3
            Console.WriteLine("Third: " + counter);
            // Output: 4 - The counter is incremented and then returned, so it becomes 4 in this line
            Console.WriteLine($"Fourth: " + (++counter));
        }
    }
}
