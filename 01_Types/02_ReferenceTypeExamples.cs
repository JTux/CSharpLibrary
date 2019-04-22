using System;
using System.Collections;
using System.Collections.Generic;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace _01_Types
{
    /// <summary>
    /// Reference Types are types that reference the address to a value.
    /// A reference type variable is one that does not directly hold the value, but instead stores a reference to the designated value.
    /// </summary>
    [TestClass]
    public class ReferenceTypeExamples
    {
        /// <summary>
        /// Here we cover groups of text characters, called strings
        /// </summary>
        [TestMethod]
        public void StringsExamples()
        {
            //-- When we want to have more than one character together we don't want to be forced to declare every single one by itself so instead we use strings
            //-- A string is a collection of characters (we'll come back to this concept later)
            //-- We enclose the value of a string inside double quotes
            string myName = "Joshua Tucker";
            Console.WriteLine($"I can save a value as a string and later use it when I need the value.\n" +
                $"For example, when I need to input my name I won't have to write '{myName}' each time if it is saved as a string variable.");

            //-- Inside strings we sometimes want to use characters that we cannot render in the string
            //-- For example, how do we write " inside a quote when that's used to dictate the beginning and end of a string?
            //-- When we want to use characters that already have a use, we use the backslash or \
            string stringWithSpecialCharacters = "Here I have a string with a \" inside of it by using the \\";
            Console.WriteLine(stringWithSpecialCharacters);

            #region Escape Sequence Examples
            //-- Special characters include:
            //-- Single Quotes: \'
            //-- Double Quotes: \"
            //-- Backslash: \\
            //-- Null (not C# null, the character): \0
            //-- Bell: \a
            //-- Backspace: \b
            //-- Form Feed: \f
            //-- Newline: \n
            //-- Carriage Return: \r
            //-- Horizontal Tab: \t
            //-- Verital Tab: \v
            #endregion Escape Sequence Examples

            //-- Another thing we can do with C# strings is use the @ symbol to get the verbatim literal
            //-- Verbatim literals make escape sequences translate as normal characters to enhance readability
            //-- This is especially useful when it comes to a long collection of backslashes, such as a file path

            //-- Compare this:
            string path = "C:\\Users\\Josh\\Documents\\fileName.exe";
            //-- To this:
            string literalPath = @"C:\Users\Josh\Documents\fileName.exe";

            Console.WriteLine($"By using the @ symbol we can clean up the readability of our strings when we need.\n" +
                $"Both {path} and {literalPath} ouput the same value while the literal is easier to read in the code.");
        }

        /// <summary>
        /// Collections can be used to reference a group same type items
        /// </summary>
        [TestMethod]
        public void Collections()
        {
            //-- We mentioned strings are collections of char types, now we want to look at other collection types

            //-- ArrayLists in C# is one of the most basic types of Collections in C#
            //-- It takes in any type of object and stores in an a randomly accessible collection
            //-- This means the order of the indexes does not really matter
            ArrayList arrayList = new ArrayList();
            arrayList.Add(24);
            arrayList.Add("Joshua");
            Console.WriteLine($"The first value in my ArrayList is: {arrayList[0]}.");

            //-- Most programming languages have what are called arrays and C# is no different
            //-- We can create an array multiple instances of one type
            //-- In C# arrays are a fixed size that is decided at creation
            string[] array = new string[5];

            //-- With C# collections we can use the index of an item to access its value
            //-- This can be done by calling the collection by its name and putting the index of the desired item inside square brackets
            //-- This can be used to GET or SET a value
            array[0] = "Hello world";
            Console.WriteLine($"The first value in my array is: {array[0]}.");

            //-- Lists are a collection type that allows us to keep adding any like type item to the List and storing them
            //-- While items are added to the list at the next available index the order is not considered important
            //-- Unlike Arrays, Lists can keep growing in size as you need where an Array is a fixed size
            //-- Lists can have items added to them using a built in .Add() method
            //-- We will talk about Methods more soon
            List<string> listExample = new List<string>();
            listExample.Add("Joshua");
            listExample.Add("Ransford");
            Console.WriteLine($"The object in our List with the index of 1 is: {listExample[1]}.");

            //-- Queues are an ordered type of collection built around a first in first out concept
            //-- You can think about this like any sort of line or queue. Whoever has been in line the longest will go next
            //-- Items can easily be added to the end of a Queue as well as the first item in the Queue can easily be removed using prebuilt methods
            //-- To add to a queue you use the .Enqueue() method
            //-- To grab the next item on the queue you use the .Dequeue() method
            Queue<string> queueExample = new Queue<string>();
            queueExample.Enqueue("Paul");
            queueExample.Enqueue("Kenn");
            Console.WriteLine($"The first object on the Queue is: {queueExample.Dequeue()}.");

            //-- Stacks are also an ordered type of collection but they are built our last in first out
            //-- You can think about this as a stack of plates. The last one you add to the stack is the first one you'll grab when you need a plate
            //-- To add something to the top of the Stack you use the .Push() method
            //-- To remove the top item you use the .Pop() method
            Stack<string> stackExample = new Stack<string>();
            stackExample.Push("Lawrence");
            stackExample.Push("Ingeborg");
            Console.WriteLine($"The next item on the Stack is: {stackExample.Pop()}.");

            //-- Dictionaries are a collection of values with a personally defined index, or key
            //-- We refer to them as Key Value pairs, where in this example our keys are defined as integers and our values are defined as strings
            //-- Dictionary keys, like all indexes, must be unique
            //-- Items can be added to the Dictionary using the .Add() method
            Dictionary<int, string> dictionaryExample = new Dictionary<int, string>();
            dictionaryExample.Add(1, "Joshua");
            dictionaryExample.Add(37, "Lawrence");
            dictionaryExample.Add(42, "Ransford");
            Console.WriteLine($"The object in this dictionary with the key of 37 has the value of: {dictionaryExample[37]}.");

            //-- HashSets are collections that do not contain duplicates
            //-- You can add items to it using the .Add() method but it will only add to the HashSet if the item does not already exist there
            HashSet<string> hashSetExample = new HashSet<string>();
            hashSetExample.Add("Jordan");
            hashSetExample.Add("Jordan");
            Console.WriteLine($"There are {hashSetExample.Count} item(s) in the HashSet.");
        }
    }
}
