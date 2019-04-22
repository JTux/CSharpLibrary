using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace _01_Types
{
    /// <summary>
    /// Value Types are types that hold the value directly.
    /// A value type variable stores the actual data as opposed to referencing a value from somewhere else.
    /// </summary>
    [TestClass]
    public class ValueTypeExamples
    {
        [TestMethod]
        /// <summary>
        /// Here we go over C#'s multiple different ways to represent numbers.
        /// </summary>
        public void Numbers()
        {
            //-- Some number types have u or s in front of them. U is for unsigned, and s is for signed.
            //-- Unsigned numbers always start at 0 and go up where signed numbers can have a negative value
            //-- In C# we split our numbers into two main categories: Whole numbers and numbers with decimals

            #region Whole Number Types
            //-- byte is an 8 bit number that goes from 0 - 255, containing 256 different possible numbers
            byte byteLow = 0;
            byte byteHigh = 255;
            Console.WriteLine($"A byte will range from {byteLow} to {byteHigh}.");

            //-- sbyte is also 8 bit, but instead of starting at 0 we spread our center the possible numbers around 0
            //-- Again, this is a signed byte which means it can have a negative sign where byte cannot
            sbyte sbyteLow = -128;
            sbyte sbyteHigh = 127;
            Console.WriteLine($"A signed byte (sbyte) will range from {sbyteLow} to {sbyteHigh}.");

            //-- short, or Int16 is a 16 bit number that can range from -32,768 to 32,767
            short shortLow = -32768;
            Int16 int16High = 32767;
            Console.WriteLine($"A short, or Int16, will range from {shortLow} to {int16High}.");

            //-- ushort is a similar concept to short the same way byte and sbyte are similar to each other
            //-- ushort starts at 0 but contains the same possible numbers, starting at 0 and ending at 65,535
            //-- This is our unsigned short which means it cannot have a negative sign
            ushort ushortLow = 0;
            ushort ushortHigh = 65535;
            Console.WriteLine($"An unsigned short, or ushort, will range from {ushortLow} to {ushortHigh}.");

            //-- A very common type to use in C# is an integer, or just int
            //-- int is a 32 bit number with a total of 4,294,967,296 possible values, going from -2,147,483,648 to 2,147,483,647
            int intLow = -2147483648;
            int intHigh = 2147483647;
            Console.WriteLine($"An int, or Int32, will range from {intLow} to {intHigh}.");

            //-- uints are our unsigned integers. Also 32 bit, but no varying signs
            uint uintLow = 0;
            uint uintHigh = 4294967295;
            Console.WriteLine($"A unsigned int, or unint, will range from {uintLow} to {uintHigh}.");

            //-- Next up is long, or Int64, are 64 based integers
            //-- This means they cover a range of 18,446,744,073,709,551,616 different values: from -9,223,372,036,854,775,808 to 9,223,372,036,854,775,807.
            long longLow = -9223372036854775808;
            Int64 int64High = 9223372036854775807;
            Console.WriteLine($"A long, or Int64, will range from {longLow} to {int64High}.");

            //-- Last up in our whole numbers is our unsigned long, or ulong
            //-- This means ulong covers the range from 0 to 18,446,744,073,709,551,615
            ulong ulongLow = 0;
            ulong ulongHigh = 18446744073709551615;
            Console.WriteLine($"An unsigned long, or ulong, will range from {ulongLow} to {ulongHigh}.\n");
            #endregion Whole Number Types

            //-- All of these are great if we have whole numbers, but if we want something between two integers we'll have to use another type that supports decimal values

            #region Decimal Types
            //-- The first type that supports decimals we'll discuss is a float, or a 32 bit floating point value
            //-- Values that support decimals are a little harder to visualize their range, as floats range from ±1.5 x 10^−45 to ±3.4 x 10^38
            //-- While there are some exceptions, floats generally maintain a precision up to 7 digits
            //-- Floats have a suffix of f
            float floatExample = 3.141592653589793238462643383279f; //This value, when used, will have a value of 3.512346 as it gets rounded to 7 digits
            Console.WriteLine($"3.141592653589793238462643383279f gets rounded to {floatExample} consisting of 7 digits.");

            //-- Another type C# has is called double
            //-- Doubles are 64 bit numbers that cover a range of 5.0 x 10^-324 to 1.7 x 10^308
            //-- This allows them to be precise up to 15-16 digits on average
            //-- Doubles can be notated with a suffix of d. If a number with a decimal is not given a suffix, it will default to double
            double doubleExample = 3.141592653589793238462643383279d;
            Console.WriteLine($"3.141592653589793238462643383279d will get rounded to {doubleExample} when used. Notice it has 15 total digits.");

            //-- The last decimal type we'll be using will be the decimal type
            //-- Decimals are 128 bit numbers that cover a range of 1.0 x 10^-28 to 7.9 x 10^28
            //-- Generally this allows them to be accurate up to 28-29 decimal places
            //-- Because of the size of a decimal, we only use them when we need a high level of accuracy such as dealing with financial calculations
            //-- Decimals have the suffix of m
            decimal decimalExample = 3.141592653589793238462643383279m;
            Console.WriteLine($"3.141592653589793238462643383279m will get rounded to {decimalExample} when used. Notice it has 28 digits after the decimal.");
            #endregion Decimal Types
        }

        /// <summary>
        /// Here we cover booleans which will have a true false value.
        /// </summary>
        [TestMethod]
        public void Booleans()
        {
            //-- Boolean types are declared with the keyword of bool
            //-- A bool is either going to have the value of true or false
            bool isTrue = true;
            bool isFalse = false;
            Console.WriteLine($"We can have a bool set to {isTrue} as well as {isFalse}.");

            //-- Booleans can also refer to anything with a true false value, not just an instance of the bool type
            //-- If I make a statement such as "I am 24 years old" then we know that this can either be true or false
            //-- Let's look at an example
            int age = 24;
            bool isAge = (24 == age);
            bool isNotAge = (24 != age);
            Console.WriteLine($"Here we can state that my age is 24 and see it is a {isAge} statement. If we try to state that 24 is not our age we see it gives us {isNotAge}.");

            //-- Later on we can see how this interacts with Conditionals
        }

        /// <summary>
        /// Here we cover single text characters using the keyword char
        /// </summary>
        [TestMethod]
        public void Characters()
        {
            //-- In C# we have a type called char, short for characters
            //-- A char is a single text character and we enclose them in single quotes
            //-- A char can include any character, be it a letter, number, symbol, and even a space
            char letter = 'C';
            char number = '1';
            char symbol = '$';
            char space = ' ';
            Console.WriteLine($"We can use the char type to contain a single character such as {letter}, {number}, {symbol}, and even the '{space}' from a spacebar.");
        }
    }
}
