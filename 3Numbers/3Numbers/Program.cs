using System;

namespace _3Numbers
{
    class Program
    {
        static void Main(string[] args)
        {
            var A = 5;
            var B = 7;
            var C = 1;
            int largest = 0;

            if (A > largest)
                largest = A;
            if (B > largest)
                largest = B;
            if (C > largest)
                largest = C;
            Console.WriteLine("The largest number is " + largest);
            Console.ReadLine();

        }

    }
}

