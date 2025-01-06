using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LarningCSharp.Class_006
{
    public class ExampleString
    {
        public void Main()
        {
            // Original string
            string original = "Hello, World!";

            // Characters to search for
            char[] charsToFind = { 'o', 'r', 'h' };

            // Use IndexOfAny to find the first occurrence
            //int index = original.IndexOfAny(charsToFind);
            //int index = original.IndexOfAny(charsToFind, 5);
            int index = original.IndexOfAny(charsToFind, 1, 0);
            // Output the result
            if (index != -1)
            {
                Console.WriteLine($"First matching character: '{original[index]}' found at index {index}");
            }
            else
            {
                Console.WriteLine("No matching characters found.");
            }
        }
    }
}
