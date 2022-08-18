using System;

namespace BinarySearch
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Think of a number between 1-100");
            int guess = 0;
            int top = 100;
            int bottom = 0;
            while (true)
            {
                guess = (top + bottom) / 2;
                Console.WriteLine("Is it " + guess + "?");
                string answer = Console.ReadLine();

                if (answer == "g")
                {
                    bottom = guess;
                }
                else if (answer == "l")
                {
                    top = guess;
                }
                else
                {
                    Console.WriteLine("I WIN");
                    break;
                }
            }
           
        }
    }
}
