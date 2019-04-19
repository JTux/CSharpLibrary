using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace _01_Data_Types
{
    [TestClass]
    public class DataTypeExamples
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
            Console.WriteLine($"An unsigned long, or ulong, will range from {ulongLow} to {ulongHigh}.");
            #endregion Whole Number Types

            Console.WriteLine();
            //-- All of these are great if we have whole numbers, but if we want something between two integers we'll have to use another type that supports decimal values
        }
    }
}
