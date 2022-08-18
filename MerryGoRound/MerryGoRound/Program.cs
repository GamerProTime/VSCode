using System;

namespace MerryGoRound
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] visitors = { "Don Giovanni", "Sir Ryan from the Second Puzzle", "Friar Jack" };
            foreach (string name in visitors)
            {
                Console.WriteLine("Woof! Hi, " + name);
            }

            for (int i = 0; i < 10; i++)
                Console.WriteLine("Howdy");

            for (int i = 0; i < 11; i++)
                Console.WriteLine(i);

            string[] friends = { "Kirill", "Aiden", "Tanner" };
            foreach (string name in friends)
                Console.WriteLine(name);

            int[] ages = { 12, 19, 28 };
            foreach (int number in ages)
                Console.WriteLine(number);

            for (int i = 7; i > -1; i = i - 1)
                Console.WriteLine(i);

            for (int i = 0; i < 10000; i++)
            {
                string bored = ("Are You Bored Yet? Y/N?");
                Console.WriteLine(bored);
                string answer = (Console.ReadLine());
                if (answer == "y")
                {
                    Console.WriteLine("How Rude Of You!");
                    break;
                }
            }
            for (int i = 0; i < 11; i++)
                Console.WriteLine("The number is: " + i + ". It doubled is " + i * 2);

            for (int i = 0; i < 11; i++)
                Console.WriteLine("The number is: " + i + ". It squared is " + i * i);

            for (int i = 1; i < 11; i++)
            {
                for (int o = 1; o < 11; o++)
                {
                    Console.Write(i * o + " ");
                }
                Console.WriteLine();
            }
            Console.WriteLine("Every Second Number: ");
            for (int i = 0; i < 11; i = i + 2)
                Console.WriteLine(i);

            Console.WriteLine("Every Third Number Backwards: ");
            for (int i = 9; i > -1; i = i - 3)
                Console.WriteLine(i);

            Console.WriteLine("Every Even Number: ");
            for (int i = 0; i < 11; i = i + 2)
                Console.WriteLine(i);

            Console.WriteLine("Every Odd Number: ");
            for (int i = 1; i < 11; i = i + 2)
                Console.WriteLine(i);
        }
    }
}
