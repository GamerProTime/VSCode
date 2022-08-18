using System;

namespace Array
{
    class Program
    {
        static void Main(string[] args)
        {
            string word = "beast";
            for (int i = 0; i < 5; i++)
                Console.WriteLine(word[i]);

            char[] mutant = "steam".ToCharArray();
            Console.WriteLine(mutant);
            mutant[0] = 'm';
            mutant[1] = 'e';
            mutant[2] = 'a';
            mutant[3] = 't';
            mutant[4] = 's';
            Console.WriteLine(mutant);

            char[] holiday = "devil".ToCharArray();
            char[] changed = "devil".ToCharArray();
            Console.WriteLine(holiday);
            holiday[0] = changed[4];
            holiday[1] = changed[3];
            holiday[2] = changed[2];
            holiday[3] = changed[1];
            holiday[4] = changed[0];
            Console.WriteLine(holiday);
        }

    }
}
