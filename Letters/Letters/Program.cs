using System;

namespace Letters
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter word");
            string word = Console.ReadLine();
            for (int i = 0; i < word.Length; i++)
                Console.Write(word[i]);
            Console.WriteLine("\n Backwards!");
            for (int i = word.Length - 1; i > -1; i--)
                Console.Write(word[i]);
        }
    }
}
