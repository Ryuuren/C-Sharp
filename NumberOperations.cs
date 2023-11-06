using System;

namespace app
{
    class Program
    {
        static void Main(string[] args)
        {
            // The addition operator + works differently depending on the given data types
            // When used with int values, it will add them together:
            int firstNumber = 12;
            int secondNumber = 7;
            Console.WriteLine(firstNumber + secondNumber);
            // If used with strings or string AND int values, it will concatenate them:
            string firstName = "Mitchell";
            int books = 9;
            Console.WriteLine(firstName + " sold " + books + " books.");
            // Mitchell sold 9 books.
            //
            // When using multiple data types that need to be handled differently, use parentheses:
            string nickname = "Mitch";
            int shoes = 3;
            Console.WriteLine(nickname + " sold " + (shoes + 12) + " books.");
            // Mitch sold 15 books.
            //
            // () Can be used as the order of operations operator
            // In the above example, it tells the compiler to resolve the operation inside the parentheses first
            // Once complete, the result will be concatenated to the others as a string
            //
            // It's best not to do calculations and concatenations in one line
            //
            // For precise calculations, use decimal type rather than int
            decimal decimalQuotient = 7.0m / 5;
            Console.WriteLine($"Decimal quotient: {decimalQuotient}");
            // The result is Decimal quotient: 1.4
            // At least one of the divided numbers must be a decimal, or both can be decimal.
            //
            // If you want to calculate two int types but don't want to lose the decimal values...
            // ...you can cast the type from int to decimal, a temporary conversion.
            int first = 7;
            int second = 5;
            decimal quotient = (decimal)first / (decimal)second;
            Console.WriteLine(quotient);
            // Result is 1.4, as the temporary casting prevented the .4 from being truncated, as it would be if they remained int at the time of compilation.
            //
            // () has many uses such as: method invocation, order of operations and casting, as seen above.
            //
            // The modulus operator % indicates the remainder of int division, to see if one number is divisible by another.
            // This can be useful for things like data record searching, where a progress update is provided to the user after every 100 records are searched.
            Console.WriteLine($"Modulus of 200 / 5 : {200 % 5}");
            Console.WriteLine($"Modulus of 7 / 5 : {7 % 5}");
            // The results are 0, then 2, as 200 is completely divisible by the divisor, while 7 has 2 remaining at the end.
            //
            // The order of operations in C# is:
            // Parentheses
            // * & / from left to right
            // + & - from left to right
            int value1 = 3 + 4 * 5;
            int value2 = (3 + 4) * 5;
            Console.WriteLine(value1);
            // value1 uses order of operations to calculate * first, then +.
            // 4 * 5 (20) + 3 = 23
            Console.WriteLine(value2);
            // value2 uses order operations to calculate () first, then *.
            // 3 + 4 (7) * 5 = 35
        }
    }
}
