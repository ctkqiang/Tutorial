using System;
// I am learning C#
namespace tutorial{
    class Program {
        static void Main(string[] args) {
            String HELLO_WORLD;
            HELLO_WORLD = " Hello World";
            Console.WriteLine(HELLO_WORLD);
            //////////////////////////////
            string friend = "John";
            // Instead of ```Console.WriteLine("Hello" + aFriend);```
            Console.WriteLine($"Hello {friend}");

            string testing = "testing";
            string testing_two = "TESTING TWO";
            Console.WriteLine($"This is Testing Number One : {testing}\n" +
                $"This is Testing Number Two : {testing_two}");

            /////////////////////////////////////////////////////////
           

            string greeting = "      Hello World!       ";
            Console.WriteLine($"[{greeting}]");

            string trimmedGreeting = greeting.TrimStart();
            Console.WriteLine($"[{trimmedGreeting}]");

            trimmedGreeting = greeting.TrimEnd();
            Console.WriteLine($"[{trimmedGreeting}]");

            trimmedGreeting = greeting.Trim();
            Console.WriteLine($"[{trimmedGreeting}]");

            // TO LOWER CASE 
            string HAHAH = "HAHAHA";
            string H = HAHAH.ToLower();
            Console.WriteLine($"This Is Lower CaSe : {H} ");
        }
    }
}
