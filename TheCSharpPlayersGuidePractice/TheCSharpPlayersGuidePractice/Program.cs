using System;

namespace TheCSharpPlayersGuidePractice
{
    internal class Program
    {
        static void Main(string[] args)
        {
            TheDominionOfKings();
        }

        static void HelloWorld()
        {
            Console.WriteLine("Are you okay?");
            Console.WriteLine("Can you speak?");
            Console.WriteLine("Hello, World!");
        }

        static void WhatComesNext()
        {
            Console.WriteLine("Iam Zeniit");
        }

        static void TheMakingsOfAProgrammer()
        {
            Console.WriteLine("Iam Zeniit");
            Console.WriteLine("I am grand programer");
            Console.WriteLine("I will destroy you");
            Console.WriteLine("I am King for the Throne");
            Console.WriteLine("I am a fan of Robber");

        }

        static void ConsolasAndTelim()
        {
            Console.WriteLine("Bread is ready");
            Console.WriteLine("Who is the bread for?");

            string name = Console.ReadLine();

            Console.WriteLine(name + " got bread");
        }

        static void TheThingNamer3000()
        {
            Console.WriteLine("What kind of thing are we talking about?");
            string a = Console.ReadLine();
            Console.WriteLine("How would you describe it? Big? Azure? Tattered?");
            string b = Console.ReadLine();
            string c = "Doom";
            string d = "3000";
            Console.WriteLine("The " + a + " " + b + " of " + c + " " + d + "!");
        }

        static void TheVariableShop()
        {
            byte byteValue = 1;
            short shortValue = 2;
            int intValue = 3;
            long longValue = 4;
            sbyte sbyteValue = 5;
            ushort ushortValue = 6;
            uint uintValue = 7;
            ulong ulongValue = 8;
            char charValue = 'a';
            string stringValue = "Hello World";
            float floatValue = 1.2f;
            double doubleValue = 2.3;
            decimal decimalValue = 3.4m;
            bool boolValue = true;

            Console.WriteLine(byteValue);
            Console.WriteLine(shortValue);
            Console.WriteLine(intValue);
            Console.WriteLine(longValue);
            Console.WriteLine(sbyteValue);
            Console.WriteLine(ushortValue);
            Console.WriteLine(uintValue);
            Console.WriteLine(ulongValue);
            Console.WriteLine(charValue);
            Console.WriteLine(stringValue);
            Console.WriteLine(floatValue);
            Console.WriteLine(doubleValue);
            Console.WriteLine(decimalValue);
            Console.WriteLine(boolValue);
            
        }

        static void TheTriangleFarmer()
        {
            Console.WriteLine("Please type the triangle's base size: ");
            string baseSize = Console.ReadLine();
            Console.WriteLine("Please type the triangle's height: ");
            string height = Console.ReadLine();

            float area = (Convert.ToSingle(baseSize) + Convert.ToSingle(height)) / 2;

            Console.WriteLine("The triangle's arena is: " + area);
        }

        static void TheFourSistersAndTheDuckbear()
        {
            Console.WriteLine("Please type number of the eggs: ");
            string amoutEgg = Console.ReadLine();

            int amountEggForPeople = Convert.ToInt32(amoutEgg) / 4;
            int amountEggForDuckbear = Convert.ToInt32(amoutEgg) % 4;

            Console.WriteLine("Amount egg for each sister is: " + amountEggForPeople);
            Console.WriteLine("Amount egg for duckbear is: " + amountEggForDuckbear);
        }

        static void TheDominionOfKings()
        {
            Console.WriteLine("Please type amount of the provinces: ");
            string provinces = Console.ReadLine();
            Console.WriteLine("Please type amount of the duchies: ");
            string duchies = Console.ReadLine();
            Console.WriteLine("Please type amount of the estates: ");
            string estates = Console.ReadLine();

            int points = (Convert.ToInt32(provinces)) + (Convert.ToInt32(duchies) * 3) + (Convert.ToInt32(estates) * 6);
            Console.WriteLine("Total pointer of King is: " + points);
        }
    }
}