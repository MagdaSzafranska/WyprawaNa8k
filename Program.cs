﻿using System;

namespace WyprawaNa8k
{
    class Program
    {
        static void Main(string[] args)
        {
            // Assignment_2();

            DoubleRadius();

            // WorkWithIntegers();

            // OperationsOnTypes();

            // TestLimits();

            // WorkWithDoubles();

            // WorkWithDecimals();
        }

        private static void DoubleRadius()
        {
            double radius = 2.5;
            double field = Math.PI * radius * radius;
            Console.WriteLine($"Field of the circle is {field} centimetres.");
        }

        private static void WorkWithDecimals()
        {
            decimal min = decimal.MinValue;
            decimal max = decimal.MaxValue;
            Console.WriteLine($"The range of decimal type is {min} to {max}");

            double a = 1.0;
            double b = 3.0;
            Console.WriteLine(a / b);

            decimal c = 1.0M;
            decimal d = 3.0M;
            Console.WriteLine(c / d);
        }

        private static void OperationsOnTypes()
        {
            //int a = 5, b = 4, c = 2;
            //Console.WriteLine(a + b * c);
            //Console.WriteLine((a + b) - 6 * c + (12 * 4)/ 3 + 12);

            //int e = 7, f = 4, g = 3;
            //int h = (e + f) / g;
            //Console.WriteLine(h);

            //int a = 7, b = 4, c = 3;
            //int d = (a + b) / c;
            //int e = (a + b) % c;
            //Console.WriteLine($"quotient: {d}");
            //Console.WriteLine("remainder: " + e);
            //Console.WriteLine();

            double a = 5, b = 4, c = 2, d = (a + b) / c;
            double e = 19, f = 23, g = 8, h = (e + f) / g;
            Console.WriteLine(d);
            Console.WriteLine(h);
        }

        private static void TestLimits()
        {
            int max = int.MaxValue;
            int min = int.MinValue;
            Console.WriteLine($"The range of integers is {min} to {max}");

            int what = max + 3;
            Console.WriteLine($"An example of overflow: {what}");
        }

        private static void WorkWithDoubles()
        {
            double maxD = double.MaxValue;
            double minD = double.MinValue;
            Console.WriteLine($"The range of double is {minD} to {maxD}");

            // Błędy zaokrągleń
            double third = 1.0 / 3.0;
            Console.WriteLine("Błędy zaokrągleń: " + third);
        }

        static void WorkWithIntegers()
        {
            int a = 8;
            int b = 4;
            int c = a + b;
            c = a - b;
            c = a * b;
            c = a / b;
            c = a + b - 12 * 17;
            Console.WriteLine(c);
        }

        static void Assignment_2()
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
            Console.WriteLine($"Method Substring makes {name.Substring(name.IndexOf(": ") + 2)}");
            Console.WriteLine($"Method Contains makes {name.Contains("a")}");
            Console.WriteLine($"Method Replace makes {name.Replace("a", "A")}");
        }

    }
}
