using System;
using System.Collections;
using System.Collections.Generic;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace _01_Types
{
    [TestClass]
    public class TypeExamples
    {
        [TestMethod]
        public void ValueTypes()
        {
            //-- Whole Numbers
            byte oneBytesworth;
            oneBytesworth = 255;
            short smallWholeNumber = 16;    //Int16
            Int16 anotherSmallNumber = 16;
            int wholeNumber = 32;           //Int32
            long largeWholeNumber = 64;     //Int64

            //-- Decimals
            float floatExample = 1.234567f;
            double doubleExample = 1.223344d;
            decimal decimalExample = 1.31490m;

            //-- Character
            char letter = 'e';


            //-- Operators
            int numOne = 17;
            int numTwo = 5;

            int sum = numOne + numTwo;
            Console.WriteLine(sum);
            int diff = numOne - numTwo;
            Console.WriteLine(diff);
            int prod = numOne * numTwo;
            Console.WriteLine(prod);
            int quot = numOne / numTwo;
            Console.WriteLine(quot);
            int remainder = numOne % numTwo;
            Console.WriteLine(remainder);

            Console.WriteLine("Hello");
        }

        [TestMethod]
        public void ReferenceTypes()
        {
            //-- Strings
            string stringExample = "This is a string.";
            string name = "Emilie";

            string declared;
            declared = "Now it's initialized.";

            //--Formatting Strings
            string concatenate = stringExample + " " + name;                        // This is a string. Emilie
            string interpolate = $"{name}. Here is the string: {stringExample}";   // Emilie. Here is the string: This is a string.
            Console.WriteLine(concatenate);
            Console.WriteLine(interpolate);

            //-- Other Object Examples
            DateTime now = DateTime.Now;
            Console.WriteLine(now);

            DateTime randomDate = new DateTime(2021, 01, 21);

            TimeSpan waitTime = randomDate - now;
            Console.WriteLine(waitTime.TotalSeconds);


            //-- Collections
            // Arrays
            string anotherExampleString = "Hello World";
            string stringArray = { anotherExampleString, "Hello", "World", "!" };
            string[] students = new string[15];

            Console.WriteLine(stringArray);

            // Lists                            // -- Control Period - using system.collection.generic
            List<string> listOfStrings = new List<string>();
            listOfStrings.Add("Lawrence");      // -- add as many as you want

            // Queues
            Queue<string> firstInFirstOut = new Queue<string>();
            firstInFirstOut.Enqueue("David");

            // Dictionaries
            Dictionary<char, string> keyValuePair = new Dictionary<char, string>();
            keyValuePair.Add('e', "Emilie");

            // Other Collections
            SortedList<int, string> sortedKeyValuePair = new SortedList<int, string>();
            Stack<string> firstInLastOut = new Stack<string>();

        }   

    }
}
