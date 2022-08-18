using System;

namespace VarPractice
{
    class Program
    {
        static void Main(string[] args)
        {
            var A = 'A';
            var a = 'a';
            Console.WriteLine(A + "b"); // Ab
            Console.WriteLine(a + "b"); // ab
            Console.WriteLine(A + 1); // A1
            Console.WriteLine(a + 1); // a1
            char b1 = (char)('a' + 1);
            Console.WriteLine(b1);

            //for (var i = a; i < a + 26; i++)
            for (var i = 'a'; i <= 'z'; i++)
                Console.Write(i);

            
            

        }
    }
}
