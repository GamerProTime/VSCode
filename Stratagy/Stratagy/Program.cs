using System;

namespace Stratagy
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("What is your experience (1-50)?");
            int points = int.Parse(Console.ReadLine());

            if (points < 5)
                Console.WriteLine("You're Infantry");
            else if (points < 20)
                Console.WriteLine("You're Cavalry");
            else if (points < 50)
                Console.WriteLine("You're a General");
            else
                Console.WriteLine("You're a Emperor");
        }
    }
}
