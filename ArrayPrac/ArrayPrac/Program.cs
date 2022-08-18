using System;

namespace ArrayPrac
{
    class Program
    {
        static void Main(string[] args)
        {
            string [] numbers = {"3", "14", "15", "92", "26", "53"};
            Console.WriteLine(numbers[0]);     // 3
            Console.WriteLine(numbers[1]);     // 14
            Console.WriteLine(numbers[2]);
            Console.WriteLine(numbers[4]);     
            Console.WriteLine(numbers[5]);     
            Console.WriteLine(numbers[3]);

            Console.WriteLine("Write a Word");
            string word = (Console.ReadLine());

            for (int i = word.Length + 1; i < 0; i = i - 1)
                Console.WriteLine(word[i]);

            string evil = "satan";
            char[] good = "?????".ToCharArray();

            good[0] = evil[0];
            good[1] = evil[1];
            good[2] = evil[4];
            good[3] = evil[2];
            good[4] = evil[3];
            Console.WriteLine(good);

            string stutter = "cat";
            for (int i = 0; i < 3; i++)
                for (int o = 0; o < 3; o++)
                    Console.WriteLine(stutter[i]);

            Console.WriteLine("What word do you want to stutter?");
            string wordstutter = (Console.ReadLine());
            for (int i = 0; i < stutter.Length + 1; i++)
                for (int o = 0; o < stutter.Length + 1; o++)
                    Console.WriteLine(wordstutter[i]);



        }
    }
}
