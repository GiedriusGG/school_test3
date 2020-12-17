using System;

namespace school_test3
{
    class Program
    {
        public static string Reverse( string s )
        {
            char[] charArray = s.ToCharArray();
            Array.Reverse( charArray );
            return new string( charArray );
        }
        
        static void Main(string[] args)
        {
            Console.WriteLine("Task 3: Write a C# program that takes a word as an input and displays it reversed.");
            Console.WriteLine("Please enter Test Data:");
            var EnteredText = Console.ReadLine();
            Console.WriteLine("Output: " + Reverse(EnteredText));
        }

    }
}
