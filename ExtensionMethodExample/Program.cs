
// Amir Moeini Rad
// May 3, 2025

// Main Concept: Extension Methods in C#


namespace ExtensionMethodExample
{
    // Extension methods allow you to add new methods to existing types without modifying their source code.
    // These methods are defined as static methods in static classes, and the first parameter specifies the type they extend.
    // The following example demonstrates how to create an extension method that reverses a string.
    // In practice, the 'ReverseString()' method is added to the 'string' class, allowing you to call it on any string instance.
    internal static class StringExtensions
    {
        // Extension method to reverse a string
        public static string ReverseString(this string str)
        {
            char[] charArray = str.ToCharArray(); // Converting 'str' to a character array
            Array.Reverse(charArray);             // Reversing the character array
            return new string(charArray);         // Converting back the character array to a string
        }
    }



    //////////////////////////////////////////////////



    // The main program demonstrates the use of the extension method defined above.
    class Program
    {
        static void Main()
        {
            Console.WriteLine("----------------------------");
            Console.WriteLine("Extension Methods in C#.NET.");
            Console.WriteLine("----------------------------\n");

            string original = "Hello, World!";

            // Using the extension method
            string reversed = original.ReverseString();

            Console.WriteLine("Original String: " + original);
            Console.WriteLine("Reversed String: " + reversed);

            Console.WriteLine("\nDone!");
        }
    }
}
