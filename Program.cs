using System;

namespace WyprawaNa8k
{
    class Program
    {
        static void Main(string[] args)
        {
            string hello = "Hej ekipa!";
            Console.WriteLine(hello);
            hello = hello.Replace("Hej", "Siema");
            Console.WriteLine(hello);

            // Contains - method of String
            Console.WriteLine(hello.Contains("Hej"));
            Console.WriteLine(hello.Contains("Siema"));
            Console.WriteLine();

            // Assignment 2
            string greeting = "Hej Ekipa z Kursu 8k.";
            Console.WriteLine(greeting.StartsWith("Hej"));
            Console.WriteLine(greeting.EndsWith("8k."));
            Console.WriteLine();

            // Playground with String methods

            string name = "Name: Magda";
            string friendName = "Kukuczka";

            Console.WriteLine($"Hi, my name is {name} and this is my friend {friendName}!");
            Console.WriteLine($"The name {name} has {name.Length} letters.");
            Console.WriteLine($"The name {friendName} has {friendName.Length} letters.");
            Console.WriteLine($"Method Substring makes {name.Substring(name.IndexOf(": ")+2)}");
            Console.WriteLine($"Method Contains makes {name.Contains("a")}");
            Console.WriteLine($"Method Replace makes {name.Replace("a", "A")}");

        }
    }
}
