using System;

namespace Overflow
{
    class Program
    {
        static void Main(string[] args)
        {
            int i = int.MaxValue;
            Console.WriteLine(i);
            i++;
            Console.WriteLine(i);
            i++;
            Console.WriteLine(i);
        }
    }
}
