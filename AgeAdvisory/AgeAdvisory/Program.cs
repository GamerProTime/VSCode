using System;

namespace AgeAdvisory
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("What is your age?");
            int age = int.Parse(Console.ReadLine());

            if (age < 8)
                Console.WriteLine("You are in kindergarden!");
            else if (age < 19)
                Console.WriteLine("Go to school!");
            else if (age < 26)
                Console.WriteLine("Go to collage!");
            else if (age < 66)
                Console.WriteLine("Work Hard!");
            else Console.WriteLine("Enjoy your retirement!");
        }
    }
}
