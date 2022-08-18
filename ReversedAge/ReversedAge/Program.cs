using System;

namespace ReversedAge
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("What is your age?");
            int age = int.Parse(Console.ReadLine()); 
            if (age > 64)
                Console.WriteLine("Enjoy your retirement!");
            else if (age > 25)
                Console.WriteLine("Work hard!");
            else if (age > 18)
                Console.WriteLine("Go to collage!");
            else if (age > 7)
                Console.WriteLine("Go to school!");
            else Console.WriteLine("Your are in kindergarden!");
            

        }
    }
}
